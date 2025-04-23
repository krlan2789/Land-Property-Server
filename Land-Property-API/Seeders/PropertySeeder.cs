using System.Numerics;
using Land_Property.API.Data;
using Land_Property.API.Entities;
using Land_Property.API.Helper;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Seeders;

public class PropertySeeder
{
    public static async Task Seed(PropertyDatabaseContext context)
    {
        try
        {
            if (!context.Properties.Any())
            {
                // Create Posts
                var allProperties = new List<Property>();
                var usersCount = context.Users.Count();
                var userIds = new HashSet<int>();
                while (userIds.Count < usersCount / 2)
                {
                    userIds.Add(Faker.RandomNumber.Next(1, usersCount > usersCount * 2 / 3 ? usersCount * 2 / 3 : usersCount));
                }
                var users = await context.Users.Where(user => userIds.Contains(user.Id)).ToListAsync();
                users.ForEach(user =>
                {
                    var propertyCount = Faker.RandomNumber.Next(0, 16) % 4;
                    var properties = Enumerable.Range(0, propertyCount).Select(x =>
                    {
                        var content = Faker.Lorem.Sentence(Faker.RandomNumber.Next(1, 32));
                        return new Property
                        {
                            Title = content,
                            Description = content,
                            Address = Faker.Address.StreetAddress(),
                            LandArea = new Vector2(Faker.RandomNumber.Next(20, 300), Faker.RandomNumber.Next(20, 300)),
                            BuildingArea = Faker.RandomNumber.Next(20, 300),
                            Slug = SlugHelper.Create(content),
                            Bathroom = (byte)Faker.RandomNumber.Next(1, 3),
                            Bedroom = (byte)Faker.RandomNumber.Next(1, 5),
                            Floor = (byte)Faker.RandomNumber.Next(1, 3),
                            Price = (ulong)Faker.RandomNumber.Next(500_000, 1_000_000_000_000),
                            UserId = user.Id,
                            AdvertisementTypeId = Faker.RandomNumber.Next(1, 3),
                            BuildingTypeId = Faker.RandomNumber.Next(1, 5),
                        };
                    }).ToList();
                    allProperties.AddRange(properties);
                });
                context.Properties.AddRange(allProperties);
                await context.SaveChangesAsync();
                Console.WriteLine($"Seeded {allProperties.Count} properties.");
            }
            else
            {
                Console.WriteLine("Properties already exist, skipping seeding.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Database migration failed: {ex.Message}");
            return;
        }
    }
}
