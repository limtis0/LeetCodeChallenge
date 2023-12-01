namespace LeetCodeChallenge;

// 238. https://leetcode.com/problems/product-of-array-except-self/
public class ProductsExceptSelf
{
    public static int[] Product(int[] nums)
    {
        int[] result = new int[nums.Length];

        result[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            ;
            result[i] = result[i - 1] * nums[i - 1];
        }

        // ^1 index is already filled with the right value, so we use a variable instead
        int rightProduct = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return result;
    }

    // O(n) memory with Stack
    public static int[] ProductLinearMemory(int[] nums)
    {
        int[] result = new int[nums.Length];
        Stack<int> productsRight = new();

        // Fill in the stack with consequtive products until index == 0
        productsRight.Push(nums[^1]);
        for (int i = nums.Length - 2; i > 0; i--)
        {
            productsRight.Push(productsRight.Peek() * nums[i]);
        }

        int productLeft = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            result[i] = productLeft * productsRight.Pop();

            productLeft *= nums[i];

            // Array is already pre-filled with zeroes, no need to go further
            if (productLeft == 0)
            {
                return result;
            }
        }

        result[^1] = productLeft;

        return result;
    }

    public static int[] ProductWithDivision(int[] nums)
    {
        int[] result = new int[nums.Length];

        int lastZeroIndex = -1; // -1 indicates zero is not found at all

        // Calculate product to the right of last zero
        int productRight = 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] == 0)
            {
                lastZeroIndex = i;
                break;
            }

            productRight *= nums[i];
        }

        // If no zero, output productRight / currentNum
        if (lastZeroIndex == -1)
        {
            // Edge-case for the index 0
            productRight /= nums[0];
            result[0] = productRight;

            for (int i = 1; i < nums.Length; i++)
            {
                productRight *= nums[i - 1];
                productRight /= nums[i];

                result[i] = productRight;
            }
        }
        else
        // If there is one zero, fill only the index of it
        {
            int productLeft = 1;

            // Calculate the product to the left of last zero
            for (int i = 0; i < lastZeroIndex; i++)
            {
                // If there is more than one zero, leave zero-filled array as a result
                if (nums[i] == 0)
                {
                    return result;
                }

                productLeft *= nums[i];
            }

            result[lastZeroIndex] = productLeft * productRight;
        }

        return result;
    }
}
