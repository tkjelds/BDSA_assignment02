namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void LocalFunctionStringReverseReturnTrue()
    {
        string StringReverse(string str) => str.Reverse().ToString();
        var str = "abc";

        var result = StringReverse(str);

        Assert.Equal("cba",result);
    }
}
