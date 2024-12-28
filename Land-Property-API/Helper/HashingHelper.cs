using System.Security.Cryptography;
using System.Text;

namespace Land_Property.API.Helper;

public static class HashingHelper
{
    public static string Hash(this string input)
    {
        using var sha256 = SHA256.Create();
        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
        var builder = new StringBuilder();
        foreach (var b in bytes)
        {
            builder.Append(b.ToString("x2"));
        }
        return builder.ToString();
    }

    public static bool VerifyHashed(this string tohash, string hashed)
    {
        return Hash(tohash) == hashed;
    }
}
