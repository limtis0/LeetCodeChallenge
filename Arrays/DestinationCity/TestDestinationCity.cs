namespace LeetCodeChallenge;

[TestClass]
public class TestDestinationCity
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        IList<IList<string>> paths =
            new List<IList<string>>()
            {
                new List<string>() { "London", "New York" },
                new List<string>() { "New York", "Lima" },
                new List<string>() { "Lima", "Sao Paulo" }
            };

        string expected = "Sao Paulo";

        // Act
        string actual = DestinationCity.DestCity(paths);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2()
    {
        // Arrange
        IList<IList<string>> paths =
            new List<IList<string>>()
            {
                new List<string>() { "B", "C" },
                new List<string>() { "D", "B" },
                new List<string>() { "C", "A" }
            };

        string expected = "A";

        // Act
        string actual = DestinationCity.DestCity(paths);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
