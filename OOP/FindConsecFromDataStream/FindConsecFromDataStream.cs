namespace LeetCodeChallenge.FindConsecFromDataStream;

// 2526. https://leetcode.com/problems/find-consecutive-integers-from-a-data-stream/
public class DataStream
{
    private int counter = 0;

    private readonly int value;
    private readonly int k; 

    public DataStream(int value, int k)
    {
        this.value = value;
        this.k = k;
    }

    public bool Consec(int num)
    {
        counter = num != value ? 0 : counter + 1;

        return counter >= k;
    }
}
