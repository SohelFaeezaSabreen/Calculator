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
}