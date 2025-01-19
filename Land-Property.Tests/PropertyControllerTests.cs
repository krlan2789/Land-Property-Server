using FakeItEasy;
using Land_Property.API.Controllers;
using Land_Property.API.Data;
using Land_Property.API.Dtos;
using Land_Property.API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Land_Property.Tests;

public class PropertyControllerTests
{
    [Fact]
    public async Task GetProperty_Returns_The_Correct_Number_of_Properties()
    {
        // Arrange
        int count = 5;
        var fakeProperties = PropertyGenerator.Create(count);
        var contextOptions = new DbContextOptionsBuilder<PropertyDatabaseContext>()
            .UseInMemoryDatabase("InMemoryDbForTesting").Options;
        var dbFake = A.Fake<PropertyDatabaseContext>(options =>
            options.WithArgumentsForConstructor(() => new PropertyDatabaseContext(contextOptions))
        );
        A.CallTo(() => dbFake.Properties.ToList()).Returns([.. fakeProperties]);
        var fakeLogger = A.Fake<ILogger<PropertyController>>();
        var fakeService = A.Fake<TokenService>();
        var controller = new PropertyController(fakeLogger, fakeService, dbFake);

        // Act
        var actionResult = await controller.GetPropertyPaginate();

        // Assert
        var result = actionResult as ResponseDataArray<ResponsePropertyDto>;
        Assert.NotNull(result);
        Assert.NotNull(result.Data);
        Assert.Equal(count, result.Data.Length);
    }
}
