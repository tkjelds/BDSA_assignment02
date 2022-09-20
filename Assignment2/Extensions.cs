namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(Uri uri) => uri.Scheme == Uri.UriSchemeHttp;
    public static int WordCount(string words) => words.Split(' ').Where(x => x.All(x => char.IsLetter(x))).Count();
}
