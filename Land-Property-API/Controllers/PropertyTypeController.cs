using Land_Property.API.Data;
using Land_Property.API.Dtos;
using Land_Property.API.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyTypeController : ControllerBase
    {
        private readonly ILogger<PropertyTypeController> _logger;
        private readonly PropertyDatabaseContext dbContext;

        public PropertyTypeController(ILogger<PropertyTypeController> logger, PropertyDatabaseContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        [HttpGet]
        public async Task<IResult> GetPropertyTypes()
        {
            ResponsePropertyTypeDto[]? existingPropertyTypes = await dbContext.PropertyTypes.Select(pt => pt.ToDto()).ToArrayAsync();
            if (existingPropertyTypes is null) return Results.NotFound();
            return Results.Ok(new ResponseDataArray<ResponsePropertyTypeDto>("Success", existingPropertyTypes));
        }
    }
}
