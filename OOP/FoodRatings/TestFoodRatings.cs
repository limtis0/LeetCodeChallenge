namespace LeetCodeChallenge;

[TestClass]
public class TestFoodRatings
{
    [TestMethod]
    public void TestHighestRated()
    {
        // Arrange
        string[] foods = { "kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi" };
        string[] cuisines = { "korean", "japanese", "japanese", "greek", "japanese", "korean" };
        int[] ratings = { 9, 12, 8, 15, 14, 7 };

        FoodRatings foodRatings = new(foods, cuisines, ratings);

        string expected = "ramen";

        // Act
        string actual = foodRatings.HighestRated("japanese");

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestChangeRatingIncrease()
    {
        // Arrange
        string[] foods = { "kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi" };
        string[] cuisines = { "korean", "japanese", "japanese", "greek", "japanese", "korean" };
        int[] ratings = { 9, 12, 8, 15, 14, 7 };

        FoodRatings foodRatings = new(foods, cuisines, ratings);

        string expected = "miso";

        // Act
        foodRatings.ChangeRating(expected, 99);

        string actual = foodRatings.HighestRated("japanese");

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestChangeRatingDecrease()
    {
        // Arrange
        string[] foods = { "kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi" };
        string[] cuisines = { "korean", "japanese", "japanese", "greek", "japanese", "korean" };
        int[] ratings = { 9, 12, 8, 15, 14, 7 };

        FoodRatings foodRatings = new(foods, cuisines, ratings);

        string expected = "miso";

        // Act
        foodRatings.ChangeRating("ramen", 4);
        
        string actual = foodRatings.HighestRated("japanese");

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
