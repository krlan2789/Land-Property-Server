using Land_Property.API.Data;
using Land_Property.API.Entities;
using Land_Property.API.Helper;

namespace Land_Property.API.Seeders;

public static class UserSeeder
{
    public static async Task Seed(PropertyDatabaseContext context)
    {
        try
        {
            if (!context.Users.Any())
            {
                // Create Users
                const byte userCount = 64;
                var emails = new HashSet<string>();
                var phoneNumbers = new HashSet<string>();
                emails.Add("bella@lavendery.com");
                emails.Add("berliana@redbell.com");
                phoneNumbers.Add("081234567890");
                phoneNumbers.Add("081234567891");
                while (emails.Count < userCount)
                {
                    var email = Faker.Internet.Email();
                    emails.Add(email);
                }
                while (phoneNumbers.Count < userCount)
                {
                    var phoneNumber = Faker.Phone.Number();
                    phoneNumbers.Add(phoneNumber);
                }
                var users = Enumerable.Range(0, userCount).Select(x =>
                {
                    return new User
                    {
                        Name = Faker.Name.FullName(),
                        Email = emails.ElementAt(x),
                        PhoneNumber = phoneNumbers.ElementAt(x),
                        PasswordHash = "12345678".Hash(),
                        Address = Faker.Address.StreetAddress(),
                    };
                }).ToList();
                context.Users.AddRange(users);
                await context.SaveChangesAsync();
                Console.WriteLine($"Seeded {users.Count} users.");
            }
            else
            {
                Console.WriteLine("Users already exist, skipping seeding.");
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"User seeding failed: {ex.Message}");
        }
    }
}
