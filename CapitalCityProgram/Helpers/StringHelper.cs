using System.Globalization;
using System.Text;

public static class StringHelper
{
    public static string Normalize(string input, bool normalizeAccents = true)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input; // Return null or empty if input is invalid
        }

        input = input.Trim();

        if (normalizeAccents)
        {
            // Normalize the string to remove accents
            string normalized = input.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (char c in normalized)
            {
                // Get the Unicode category for the character
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);

                // Check if the character is a non-spacing mark
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    if (c == 'ß')
                    {
                        stringBuilder.Append("SS");
                    }
                    else
                    {
                        stringBuilder.Append(c);
                    }
                }
            }

            // Convert to uppercase and return
            return stringBuilder.ToString().ToUpperInvariant();
        }
        else
        {
            // Return the input string capitalized without accent normalization
            return input.ToUpperInvariant();
        }
    }

    public static bool AreNormalizedEqual(string one, string two, bool normalizeAccents = true)
    {
        return Normalize(one, normalizeAccents).Equals(Normalize(two, normalizeAccents));
    }
}