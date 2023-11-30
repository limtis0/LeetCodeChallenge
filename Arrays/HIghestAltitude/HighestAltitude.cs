namespace LeetCodeChallenge;

public class HighestAltitude {
    public static int LargestAltitude(int[] gain) {
        int currentAltitude = 0;
        int highestAltitude = 0;

        foreach (int altitudeChange in gain)
        {
            currentAltitude += altitudeChange;
            highestAltitude = Math.Max(highestAltitude, currentAltitude);
        }

        return highestAltitude;
    }
}