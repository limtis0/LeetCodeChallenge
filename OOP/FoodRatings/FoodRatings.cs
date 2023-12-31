namespace LeetCodeChallenge;

// 2353. https://leetcode.com/problems/design-a-food-rating-system/
public class FoodRatings
{
    class FoodObject : IComparable<FoodObject>
    {
        public string food;
        public string cuisine;
        public int rating;

        public FoodObject(string food, string cuisine, int rating)
        {
            this.food = food;
            this.cuisine = cuisine;
            this.rating = rating;
        }

        // Return the opposite due to SortedSet being sorted increasingly
        public int CompareTo(FoodObject? other)
        {
            // Compare based on rating first
            int valueComparison = rating.CompareTo(other?.rating);

            if (valueComparison == 0)
            {
                // If values are equal, compare based on name
                return food.CompareTo(other?.food);
            }

            return -valueComparison;
        }
    }

    private readonly Dictionary<string, FoodObject> foodByName = new();
    private readonly Dictionary<string, SortedSet<FoodObject>> cuisineRatings = new();

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
    {
        for (int i = 0; i < foods.Length; i++)
        {
            string food = foods[i];
            string cuisine = cuisines[i];
            int rating = ratings[i];

            FoodObject foodObject = new(food, cuisine, rating);

            foodByName.Add(food, foodObject);

            if (!cuisineRatings.ContainsKey(cuisine))
            {
                cuisineRatings.Add(cuisine, new());
            }
            
            cuisineRatings[cuisine].Add(foodObject);
        }
    }
    
    public void ChangeRating(string food, int newRating)
    {
        FoodObject foodObject = foodByName[food];

        var set = cuisineRatings[foodObject.cuisine];
        
        set.Remove(foodObject);
        foodObject.rating = newRating;
        set.Add(foodObject);
    }
    
    public string HighestRated(string cuisine)
    {
        return cuisineRatings[cuisine].ElementAt(0).food;
    }
}
