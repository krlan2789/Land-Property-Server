using Land_Property.API.Entities;
using Land_Property.API.Helper;

namespace Land_Property.Tests;

public static class PropertyGenerator
{
    public static List<Property> Create(int count)
    {
        var list = new List<Property>();
        for (int i = 0; i < count; i++)
        {
            string title = Faker.Name.FullName();
            list.Add(new()
            {
                Title = title,
                Address = Faker.Address.StreetAddress(true),
                BuildingArea = Faker.RandomNumber.Next(20, 200),
                LandArea = new(Faker.RandomNumber.Next(4, 20), Faker.RandomNumber.Next(4, 20)),
                Slug = SlugHelper.Create(title),
                UserId = Faker.RandomNumber.Next(1, 128),
            });
        }
        return list;
    }
}
