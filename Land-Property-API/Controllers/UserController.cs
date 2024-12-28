using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Land_Property.API.Data;
using Land_Property.API.Dtos;
using Land_Property.API.Entities;
using Land_Property.API.Mapping;
using Land_Property.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly PropertyDatabaseContext dbContext;
    private readonly TokenService _tokenService;

    public UserController(ILogger<UserController> logger, TokenService tokenService, PropertyDatabaseContext context)
    {
        _logger = logger;
        dbContext = context;
        _tokenService = tokenService;
    }

    [Authorize]
    [HttpGet("{Email}")]
    public async Task<IResult> GetUserByEmail(string Email)
    {
        User? currentUser = await dbContext.Users.Where(User => User.Email == Email).FirstAsync();
        return currentUser is null ? Results.NotFound() : Results.Ok(new ResponseData<ResponseUserDto>("Success", currentUser.ToResponseDto()));
    }

    [Authorize]
    [HttpGet("properties")]
    public async Task<IResult> GetProperty()
    {
        try
        {
            string token = "" + HttpContext.Request.Headers["Authorization"].ToString().Split(" ")[1];
            var claim = _tokenService.GetPrincipalFromToken(token).Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value;
            var userClaim = User.FindFirst(claim => claim.Type == ClaimTypes.NameIdentifier);
            if (userClaim == null) return Results.Unauthorized();
            var userId = int.Parse(userClaim.Value);
            Property[]? existingProperty = await dbContext.Properties.Where(property => property.UserId == userId).ToArrayAsync();
            if (existingProperty is null) return Results.NotFound();
            return Results.Ok(new ResponseData<ResponsePropertyDto[]>("Success", existingProperty.ToResponseDto()));
        }
        catch (Exception e)
        {
            return Results.BadRequest(new ResponseData<object>(e.Message));
        }
    }
}
