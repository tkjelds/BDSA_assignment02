using System.Text.RegularExpressions;

namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri uri) => uri.Scheme == Uri.UriSchemeHttps;
    public static int WordCount(this string words) => Regex.Matches(words, @"\p{L}+").Count();
}
