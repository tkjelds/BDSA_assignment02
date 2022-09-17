namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void LocalFunctionStringReverseReturnTrue()
    {
        string StringReverse(string str) => String.Concat(str.Reverse());
        var str = "abc";

        var result = StringReverse(str);

        Assert.Equal("cba",result);
    }

    [Fact]
    public void LocalFunctionTakesTwoAndReturnsProduct()
    {
        // Given
        decimal Product(decimal d1, decimal d2) => d1 * d2;
        decimal d1 = 5;
        decimal d2 = 5;
        // When
        var result = Product(d1,d2);
        // Then
        Assert.Equal(25,result);
    }

    [Fact]
    public void LocalFunctionStringAndIntNumericallyEqual()
    {
        // Given
        bool NumericallyEqual(string str, int number) => Int32.Parse(str) == number;
        // When
        var result = NumericallyEqual("0042",42);
        // Then
        Assert.True(result);
    }
        [Fact]
    public void DelegateStringReverseReturnTrue()
    {
        Func<string,string> StringReverse = str => String.Concat(str.Reverse());
        var str = "abc";

        var result = StringReverse(str);

        Assert.Equal("cba",result);
    }

    [Fact]
    public void DelegateTakesTwoAndReturnsProduct()
    {
        // Given
        Func<Decimal,Decimal,Decimal> Product = (d1,d2) => d1 * d2;
        decimal d1 = 5;
        decimal d2 = 5;
        // When
        var result = Product(d1,d2);
        // Then
        Assert.Equal(25,result);
    }

    [Fact]
    public void DelegateStringAndIntNumericallyEqual()
    {
        // Given
        Func<string,int,bool> NumericallyEqual = (str, number) => Int32.Parse(str) == number;
        // When
        var result = NumericallyEqual("0042",42);
        // Then
        Assert.True(result);
    }
}
