namespace LeetCodeChallenge;

[TestClass]
public class TestPhoneNumberCombinations
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        string digits = "23";

        List<string> expected = new() { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

        // Act
        IList<string> actual = PhoneNumberCombinations.LetterCombinations(digits);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        string digits = "";

        List<string> expected = new() { };

        // Act
        IList<string> actual = PhoneNumberCombinations.LetterCombinations(digits);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    [TestMethod]
    public void Test3()
    {
        // Arrange
        string digits = "2";

        List<string> expected = new() { "a", "b", "c" };

        // Act
        IList<string> actual = PhoneNumberCombinations.LetterCombinations(digits);

        // Assert
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}
