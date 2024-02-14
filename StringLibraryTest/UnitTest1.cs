using UtilityLibraries;
namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = 3.5m;
        decimal number2 = 4.2m;
        decimal expectedSum = 7.7m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void Test_Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = -3.5m;
        decimal number2 = -4.2m;
        decimal expectedSum = -7.7m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void Test_Add_PositiveAndNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = 3.5m;
        decimal number2 = -4.2m;
        decimal expectedSum = -0.7m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void Test_Add_ZeroToNumber_ReturnsNumber()
    {
        // Arrange
        decimal number1 = 3.5m;
        decimal number2 = 0m;
        decimal expectedSum = 3.5m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void Test_Add_TwoLargeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = 12345678901234567890.123m;
        decimal number2 = 12345678901234567890.456m;
        decimal expectedSum = 24691357802469135780.579m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }

    // Subtraction Logic
    [TestMethod]
    public void Test_Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        decimal number1 = 8.9m;
        decimal number2 = 3.2m;
        decimal expectedDifference = 5.7m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }

    [TestMethod]
    public void Test_Subtract_TwoNegativeNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        decimal number1 = -8.9m;
        decimal number2 = -3.2m;
        decimal expectedDifference = -5.7m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }
    [TestMethod]
    public void Test_Subtract_PositiveAndNegativeNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        decimal number1 = 8.9m;
        decimal number2 = -3.2m;
        decimal expectedDifference = 12.1m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }

    [TestMethod]
    public void Test_Subtract_NumberFromZero_ReturnsNegativeNumber()
    {
        // Arrange
        decimal number1 = 0m;
        decimal number2 = 5.7m;
        decimal expectedDifference = -5.7m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }

    [TestMethod]
    public void Test_Subtract_LargeNumberFromSmallNumber_ReturnsCorrectDifference()
    {
        // Arrange
        decimal number1 = 1234567890.123m;
        decimal number2 = 1234.567m;
        decimal expectedDifference = 1234566655.556m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }

    // MULTIPLICATION LOGIC

    [TestMethod]
    public void Test_Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        decimal number1 = 2.5m;
        decimal number2 = 3.0m;
        decimal expectedProduct = 7.5m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }
     [TestMethod]
    public void Test_Multiply_PositiveAndNegativeNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        decimal number1 = -2.5m;
        decimal number2 = 3.0m;
        decimal expectedProduct = -7.5m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }

    [TestMethod]
    public void Test_Multiply_TwoNegativeNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        decimal number1 = -2.5m;
        decimal number2 = -3.0m;
        decimal expectedProduct = 7.5m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }

    [TestMethod]
    public void Test_Multiply_NumberByZero_ReturnsZero()
    {
        // Arrange
        decimal number1 = 2.5m;
        decimal number2 = 0m;
        decimal expectedProduct = 0m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }

[TestMethod]
    public void Test_Multiply_LargeNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        decimal number1 = 1234567890.0m;
        decimal number2 = 9876543210.0m;
        decimal expectedProduct = 12193263111263526900.0m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }
// DIVISION LOGIC
    [TestMethod]
    public void Test_Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        decimal dividend = 10.0m;
        decimal divisor = 2.0m;
        decimal expectedQuotient = 5.0m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }

    [TestMethod]
    public void Test_Divide_PositiveAndNegativeNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        decimal dividend = -10.0m;
        decimal divisor = 2.0m;
        decimal expectedQuotient = -5.0m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }

    [TestMethod]
    public void Test_Divide_ZeroByNumber_ReturnsZero()
    {
        // Arrange
        decimal dividend = 0.0m;
        decimal divisor = 5.0m;
        decimal expectedQuotient = 0.0m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }
  
    [TestMethod]
    public void Test_Divide_LargeNumberBySmallNumber_ReturnsCorrectQuotient()
    {
        // Arrange
       decimal dividend = 9876543210.0m;
        decimal divisor = 1234567890.0m;
        decimal expectedQuotient = 8.000000072900000663390006037m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }

    [TestMethod]
       public void Test_Divide_SmallDividendByLargeDivisor_ReturnsCorrectQuotient()
    {
        // Arrange
        decimal dividend = 100.0m;
        decimal divisor = 1000000.0m;
        decimal expectedQuotient = 0.0001m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }
}