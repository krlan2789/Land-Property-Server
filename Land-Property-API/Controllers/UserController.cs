using Land_Property.API.Data;
using Land_Property.API.Dtos;
using Land_Property.API.Entities;
using Land_Property.API.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(ILogger<UserController> logger, PropertyDatabaseContext context) : ControllerBase
{
    private readonly ILogger<UserController> _logger = logger;
    private readonly PropertyDatabaseContext dbContext = context;

    [HttpGet("{Id}", Name = nameof(GetUserById))]
    public async Task<IResult> GetUserById(int Id)
    {
        User? currentUser = await dbContext.Users.FindAsync(Id);
        return currentUser is null ? Results.NotFound() : Results.Ok(currentUser.ToResponseDto());
    }

    // [HttpGet("m/{Email}")]
    // public async Task<IResult> GetUserByEmail(string Email)
    // {
    //     User? currentUser = await dbContext.Users.Where(user => user.Email == Email).FirstAsync();
    //     return currentUser is null ? Results.NotFound() : Results.Ok(currentUser.ToResponseDto());
    // }

    [HttpPost("register", Name = nameof(PostRegister))]
    public async Task<IResult> PostRegister([FromBody] RegisterUserDto userDto)
    {
        if (await dbContext.Users.Where(user => user.Email == userDto.Email).AnyAsync())
        {
            return Results.Conflict();
        }
        dbContext.Users.Add(userDto.ToEntity());
        await dbContext.SaveChangesAsync();
        User? currentUser = await dbContext.Users.Where(user => user.Email == userDto.Email).FirstAsync();
        return currentUser is null ? Results.NotFound() : Results.CreatedAtRoute(nameof(GetUserById), new { Id = currentUser.Id }, currentUser.ToResponseDto());
    }

    [HttpPost("login", Name = nameof(PostLogin))]
    public async Task<IResult> PostLogin([FromBody] LoginUserDto userDto)
    {
        User? currentUser = await dbContext.Users.Where(user => user.Email == userDto.Email && user.VerifyPassword(userDto.Password)).FirstAsync();
        return currentUser is null ? Results.NotFound() : Results.CreatedAtRoute(nameof(GetUserById), new { Id = currentUser.Id }, currentUser.ToResponseDto());
    }
}
