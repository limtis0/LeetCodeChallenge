namespace LeetCodeChallenge;

// 661. https://leetcode.com/problems/image-smoother/
public class ImageSmoother
{
    public static int[][] Solution(int[][] img)
    {
        (int height, int width) = (img.Length, img[0].Length);

        int[][] answer = new int[height][];

        for (int row = 0; row < height; row++)
        {
            answer[row] = new int[width];

            for (int col = 0; col < width; col++)
            {
                answer[row][col] = GetSmoothedValue(img, row, col, height, width);
            }
        }

        return answer;
    }

    private static int GetSmoothedValue(int[][] img, int row, int col, int height, int width)
    {
        int count = 0;
        int sum = 0;

        int top = Math.Max(row - 1, 0);
        int bottom = Math.Min(row + 1, height - 1);

        int left = Math.Max(col - 1, 0);
        int right = Math.Min(col + 1, width - 1);


        for (int r = top; r <= bottom; r++)
        {   
            for (int c = left; c <= right; c++)
            {
                sum += img[r][c];
                count++;
            }
        }

        return sum / count;
    }
}
