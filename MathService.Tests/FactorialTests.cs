namespace MathService.Tests;

public class FactorialTests
{
    [Fact]
    public void FactorialZero()
    {
        Assert.Equal(1, MathService.FactorialService.Factorial(0));
    }
    [Fact]
    public void NegativeInput()
    {
        Assert.Throws<Exception>(() =>
        {
            MathService.FactorialService.Factorial(-1);
        });
    }

    [Fact]
    public void FactorialFour()
    {
        Assert.Equal(24, MathService.FactorialService.Factorial(4));
    }
}