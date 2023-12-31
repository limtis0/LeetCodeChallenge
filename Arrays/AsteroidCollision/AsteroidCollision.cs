namespace LeetCodeChallenge;

// 735. https://leetcode.com/problems/asteroid-collision/
public class AsteroidCollision
{
    public static int[] Solution(int[] asteroids)
    {
        Stack<int> stack = new();

        foreach (int asteroid in asteroids)
        {
            if (asteroid > 0)
            {
                stack.Push(asteroid);
            }
            else
            {
                // Remove all smaller positive-headed asteroids in-behind
                while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < -asteroid)
                {
                    stack.Pop();
                }

                // If none left, or previous is negative-headed
                if (stack.Count == 0 || stack.Peek() < 0)
                {
                    stack.Push(asteroid);
                }
                // If they destroy each other
                else if (stack.Peek() == -asteroid)
                {
                    stack.Pop();
                }
            }
        }

        return stack.Reverse().ToArray();
    }
}
