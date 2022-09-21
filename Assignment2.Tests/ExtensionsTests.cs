namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void FlattenXS()
    {
        IEnumerable<int>[] xs = {new []{1,2,3},new []{1,2,3},new []{1,2,3}};

        var result = xs.SelectMany(x => x);

        Assert.Equal(new [] {1,2,3,1,2,3,1,2,3}, result);
    }

    [Fact]
    public void FilterYSWithDiv7AndGreaterThan42()
    {
        // Given
        int[] ys = {70,77,65,7};
        // When
        var result = ys.Where(x => x % 7 == 0 && x > 42);
        // Then
        Assert.Equal(new [] {70,77},result);
    }

    [Fact]
    public void FilterLeapYear()
    {
        // Given
        int[] ys = {400,600,800,1000};
        // When
        var result = ys.Where(x => x % 4 == 0).Where(x => x % 100 != 0 || x % 400 == 0);
        // Then
        Assert.Equal(new [] {400,800},result);
    }

    [Fact]
    public void TestIfHTTPSReturnTrue()
    {
        // Given
        Uri uri = new Uri("https://[2607:f8b0:400d:c06::69]");
        // When
        var result = uri.IsSecure();
        // Then
        Assert.True(result);
    }

    [Fact]
    public void TestIfHTTPReturnFalse()
    {
        // Given
        Uri uri = new Uri("http://[2607:f8b0:400d:c06::69]");
        // When
        var result = uri.IsSecure();
        // Then
        Assert.False(result);
    }
    [Fact]
    public void WordCountReturns5()
    {
        // Given
        var testString = "And.And And! And 123 And";
        // When
        var result = testString.WordCount();
        // Then
        Assert.Equal(5,result);
    }
    [Fact]
    public void WordCountDoesNotRecognizeNumbersAndReturns5()
    {
        // Given
        var testString = "And And And 5 And And";
        // When
        var result = Extensions.WordCount(testString);
        // Then
        Assert.Equal(5,result);
    }
}
