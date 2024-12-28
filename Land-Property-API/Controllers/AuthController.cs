using Land_Property.API.Data;
using Land_Property.API.Dtos;
using Land_Property.API.Entities;
using Land_Property.API.Mapping;
using Land_Property.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly PropertyDatabaseContext dbContext;
        private readonly TokenService _tokenService;

        public AuthController(ILogger<UserController> logger, TokenService tokenService, PropertyDatabaseContext context)
        {
            _logger = logger;
            dbContext = context;
            _tokenService = tokenService;
        }

        [HttpPost("login", Name = nameof(PostLogin))]
        public async Task<IResult> PostLogin(LoginUserDto dto)
        {
            User? currentUser = await dbContext.Users.Where(user => user.Email == dto.Email).FirstOrDefaultAsync();
            if (currentUser != null && currentUser.VerifyPassword(dto.Password))
            {
                var token = _tokenService.GenerateToken("" + currentUser.Id, TimeSpan.FromMinutes(60));
                return Results.Ok(new ResponseData<ResponseUserDto>("Login Successfully", token));
            }
            else
            {
                return Results.Unauthorized();
            }
        }

        [HttpPost("register", Name = nameof(PostRegister))]
        public async Task<IResult> PostRegister([FromBody] RegisterUserDto userDto)
        {
            if (await dbContext.Users.Where(user => user.Email == userDto.Email).AnyAsync()) return Results.Conflict();
            dbContext.Users.Add(userDto.ToEntity());
            await dbContext.SaveChangesAsync();
            User? currentUser = await dbContext.Users.Where(user => user.Email == userDto.Email).FirstAsync();
            return currentUser is null ? Results.NotFound() : Results.Ok(
                new ResponseData<ResponseUserDto>("Registration Successfully")
            );
        }
    }
}
