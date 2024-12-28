using Land_Property.API.Data;
using Land_Property.API.Dtos;
using Land_Property.API.Entities;
using Land_Property.API.Mapping;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly ILogger<PropertyController> _logger;
        private readonly PropertyDatabaseContext dbContext;

        public PropertyController(ILogger<PropertyController> logger, PropertyDatabaseContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        [HttpGet("{Slug}")]
        public async Task<IResult> GetProperty(string Slug)
        {
            Property? existingProperty = await dbContext.Properties.Where(property => property.Slug == Slug).FirstOrDefaultAsync();
            if (existingProperty is null) return Results.NotFound();
            return Results.Ok(new ResponseData<ResponsePropertyDto>("Success", existingProperty.ToResponseDto()));
        }

        [HttpGet("search")]
        public async Task<IResult> SearchProperty(string keyword)
        {
            Property[]? existingProperty = await dbContext.Properties.Where(property => property.ContainsKeyword(keyword)).ToArrayAsync();
            if (existingProperty is null) return Results.NotFound();
            return Results.Ok(new ResponseData<ResponsePropertyDto[]>("Success", existingProperty.ToResponseDto()));
        }

        [Authorize]
        [HttpPost(Name = nameof(PostProperty))]
        public async Task<IResult> PostProperty([FromBody] CreatePropertyDto dto)
        {
            dbContext.Properties.Add(dto.ToEntity());
            await dbContext.SaveChangesAsync();
            return Results.Ok(new ResponseData<ResponsePropertyDto>("Property Added Successfully"));
        }

        [Authorize]
        [HttpPut("{Slug}")]
        public async Task<IResult> PutProperty(string Slug, [FromBody] UpdatePropertyDto dto)
        {
            Property? existingProperty = await dbContext.Properties.Where(property => property.Slug == Slug).FirstOrDefaultAsync();
            if (existingProperty is null) return Results.NotFound();
            dbContext.Entry(existingProperty).CurrentValues.SetValues(dto.ToEntity(Slug));
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
