using System.Globalization;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        bool upperCaseNext = false;

        foreach (var c in identifier)
        {
            // Replace spaces with underscores
            if (c == ' ')
            {
                sb.Append('_');
                upperCaseNext = false;
                continue;
            }

            // Replace control characters with "CTRL"
            if (char.IsControl(c))
            {
                sb.Append("CTRL");
                upperCaseNext = false;
                continue;
            }

            // Convert kebab-case to camelCase
            if (c == '-')
            {
                upperCaseNext = true;
                continue;
            }

            // Omit Greek lowercase letters
            if (char.GetUnicodeCategory(c) == UnicodeCategory.LowercaseLetter && c >= 'α' && c <= 'ω')
            {
                upperCaseNext = false;
                continue;
            }

            // Omit characters that are not letters or underscores
            if (!char.IsLetter(c) && c != '_')
            {
                upperCaseNext = false;
                continue;
            }

            // Convert to uppercase if needed (for camelCase)
            if (upperCaseNext)
            {
                sb.Append(char.ToUpperInvariant(c));
                upperCaseNext = false;
            }
            else
            {
                sb.Append(c);
                upperCaseNext = false;
            }
        }
        return sb.ToString();
    }
}
