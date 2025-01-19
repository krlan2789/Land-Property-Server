using Land_Property.API.Data;
using Land_Property.API.Dtos;
using Land_Property.API.Entities;
using Land_Property.API.Mapping;
using Land_Property.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly ILogger<PropertyController> _logger;
        private readonly TokenService _tokenService;
        private readonly PropertyDatabaseContext dbContext;

        public PropertyController(ILogger<PropertyController> logger, TokenService tokenService, PropertyDatabaseContext context)
        {
            _logger = logger;
            dbContext = context;
            _tokenService = tokenService;
        }

        [HttpGet("paginate/{Page?}/{Count?}")]
        public async Task<IResult> GetPropertyPaginate(int Page = 1, int Count = 8)
        {
            int defaultCount = dbContext.Properties.Count();
            if (Count < 1 || Count > defaultCount) return Results.BadRequest();
            var existingProperty = await dbContext.Properties.Skip((Page - 1) * Count).Take(Count).ToListAsync();
            if (existingProperty is null) return Results.NotFound();
            return Results.Ok(new ResponseDataArray<ResponsePropertyDto>("Success", existingProperty.ToArray().ToResponseDto()));
        }

        [HttpGet("{Slug}")]
        public async Task<IResult> GetPropertyBySlug(string Slug)
        {
            Property? existingProperty = await dbContext.Properties.Where(property => property.Slug == Slug).FirstOrDefaultAsync();
            if (existingProperty is null) return Results.NotFound();
            return Results.Ok(new ResponseData<ResponsePropertyDto>("Success", existingProperty.ToResponseDto()));
        }

        [HttpGet("search/{Keyword?}")]
        public async Task<IResult> SearchProperty(string? Keyword)
        {
            Property[]? existingProperty = await dbContext.Properties.Where(property => Keyword == null || property.ContainsKeyword(Keyword)).ToArrayAsync();
            if (existingProperty is null) return Results.NotFound();
            return Results.Ok(new ResponseData<ResponsePropertyDto[]>("Success", existingProperty.ToResponseDto()));
        }

        [Authorize]
        [HttpPost(Name = nameof(PostProperty))]
        public async Task<IResult> PostProperty([FromBody] CreatePropertyDto dto)
        {
            var userId = _tokenService.GetUserIdFromToken(HttpContext);
            User? currentUser = await dbContext.Users.Where(user => user.Id == userId).FirstOrDefaultAsync();
            if (currentUser is null) return Results.NotFound("User not found");

            PropertyType? buildingType = await dbContext.PropertyTypes.Where(type => type.Id == dto.BuildingTypeId).FirstOrDefaultAsync();
            if (buildingType is null) return Results.NotFound("PropertyType not found");

            AdvertisementType? advertisementType = await dbContext.AdvertisementTypes.Where(type => type.Id == dto.AdvertisementTypeId).FirstOrDefaultAsync();
            if (advertisementType is null) return Results.NotFound("AdvertisementType not found");

            dbContext.Properties.Add(dto.ToEntity(currentUser, buildingType, advertisementType));
            await dbContext.SaveChangesAsync();
            return Results.Ok(new ResponseData<ResponsePropertyDto>("Property Added Successfully"));
        }

        [Authorize]
        [HttpPut("{Slug}")]
        public async Task<IResult> PutProperty(string Slug, [FromBody] UpdatePropertyDto dto)
        {
            var userId = _tokenService.GetUserIdFromToken(HttpContext);
            User? currentUser = await dbContext.Users.Where(user => user.Id == userId).FirstOrDefaultAsync();
            if (currentUser is null) return Results.NotFound("User not found");

            PropertyType? buildingType = await dbContext.PropertyTypes.Where(type => type.Id == dto.BuildingTypeId).FirstOrDefaultAsync();
            if (buildingType is null) return Results.NotFound("PropertyType not found");

            AdvertisementType? advertisementType = await dbContext.AdvertisementTypes.Where(type => type.Id == dto.AdvertisementTypeId).FirstOrDefaultAsync();
            if (advertisementType is null) return Results.NotFound("AdvertisementType not found");

            Property? existingProperty = await dbContext.Properties.Where(property => property.Slug == Slug).FirstOrDefaultAsync();
            if (existingProperty is null) return Results.NotFound("Property not found");

            dbContext.Entry(existingProperty).CurrentValues.SetValues(dto.ToEntity(Slug, currentUser, buildingType, advertisementType));
            await dbContext.SaveChangesAsync();
            return Results.Ok(new ResponseData<ResponsePropertyDto>("Property Updated Successfully"));
        }

        [Authorize]
        [HttpDelete("{Slug}")]
        public async Task<IResult> DeleteProperty(string Slug)
        {
            await dbContext.Properties.Where(property => property.Slug == Slug).ExecuteDeleteAsync();
            return Results.Ok(new ResponseData<ResponsePropertyDto>("Property deleted Successfully"));
        }
    }
}
