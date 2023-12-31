namespace LeetCodeChallenge;

// 1496. https://leetcode.com/problems/path-crossing/
public class PathCrossing
{
    public static bool IsPathCrossing(string path)
    {
        (int x, int y) coordinates = new(0, 0);

        HashSet<ValueTuple<int, int>> visited = new() { coordinates };

        foreach (char c in path)
        {
            switch (c)
            {
                case 'N':
                    coordinates.y++;
                    break;
                case 'S':
                    coordinates.y--;
                    break;
                case 'W':
                    coordinates.x--;
                    break;
                case 'E':
                    coordinates.x++;
                    break;
            }
            ;

            if (visited.Contains(coordinates))
            {
                return true;
            }

            visited.Add(coordinates);
        }

        return false;
    }

    private struct Coordinates
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(char c)
        {
            switch (c)
            {
                case 'N':
                    Y++;
                    break;
                case 'S':
                    Y--;
                    break;
                case 'W':
                    X--;
                    break;
                case 'E':
                    X++;
                    break;
                default:
                    throw new ArgumentException($"{c} must be in NSWE");
            }
            ;
        }
    }

    public static bool IsPathCrossingOOP(string path)
    {
        Coordinates coordinates = new(0, 0);

        HashSet<Coordinates> visited = new() { coordinates };

        foreach (char c in path)
        {
            coordinates.Move(c);

            if (visited.Contains(coordinates))
            {
                return true;
            }

            visited.Add(coordinates);
        }

        return false;
    }
}
