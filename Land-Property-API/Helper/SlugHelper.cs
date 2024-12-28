using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Land_Property.API.Helper;

public static class SlugHelper
{
    public static string Create(string phrase)
    {
        string str = RemoveAccents(phrase).ToLower();
        str = Regex.Replace(str, @"[^a-z0-9\s-]", ""); // Remove invalid characters
        str = Regex.Replace(str, @"\s+", " ").Trim(); // Convert multiple spaces into one space
        str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim(); // Cut to 45 chars
        str = Regex.Replace(str, @"\s", "-"); // Hyphens
        return str;
    }

    private static string RemoveAccents(string text)
    {
        var normalizedString = text.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder();

        foreach (var c in normalizedString)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
    }
}
