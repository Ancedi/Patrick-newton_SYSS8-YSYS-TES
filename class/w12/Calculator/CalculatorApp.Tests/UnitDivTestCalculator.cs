namespace CalculatorApp.Tests;

[TestClass]
public class UnitDivTestCalculator
{
    [TestMethod]
    public void TestDivision2PositiveNumbers()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 10;
        int b = 5;

        // Act
        int result = calculator.Division(a, b);

        // Assert
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void TestTwoNegativeNumbers()
    {
        // Arrange
        var calculator = new Calculator();
        int a = -10;
        int b = -5;

        // Act
        int result = calculator.Division(a, b);

        // Assert
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void TestDivisionOnePositiveNumberOneNegativeNumber()
    {
        // Arrange
        var calculator = new Calculator();
        int a = -10;
        int b = 5;

        // Act
        double result = calculator.Division(a, b);

        // Assert
        Assert.AreEqual(-2, result);
    }

    [TestMethod]
    public void TestDivisionByZero()
    {
        var calculator = new Calculator();
        int a = 10;
        int b = 0;
    
        Assert.ThrowsException<DivideByZeroException>(() => calculator.Division(a, b));
    }
}