using Land_Property.API.Data;
using Land_Property.API.Dtos;
using Land_Property.API.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementTypeController : ControllerBase
    {
        private readonly ILogger<PropertyTypeController> _logger;
        private readonly PropertyDatabaseContext dbContext;

        public AdvertisementTypeController(ILogger<PropertyTypeController> logger, PropertyDatabaseContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        [HttpGet]
        public async Task<IResult> GetAdvertisementTypes()
        {
            ResponseAdvertisementTypeDto[]? existingTypes = await dbContext.AdvertisementTypes.Select(pt => pt.ToDto()).ToArrayAsync();
            if (existingTypes is null) return Results.NotFound();
            return Results.Ok(new ResponseDataArray<ResponseAdvertisementTypeDto>("Success", existingTypes));
        }
    }
}
