using System;
using System.Linq;

class Solution
{
    // Complete the flatlandSpaceStations function below.
    static int flatlandSpaceStations(int n, int[] c)
    {
        Array.Sort(c); 
        int maxDistance = 0;

        
        maxDistance = Math.Max(maxDistance, c[0] - 0);

        
        for (int i = 1; i < c.Length; i++)
        {
            int dist = (c[i] - c[i - 1]) / 2;
            maxDistance = Math.Max(maxDistance, dist);
        }

        
        maxDistance = Math.Max(maxDistance, n - 1 - c[c.Length - 1]);

        return maxDistance;
    }

    static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().Trim().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int m = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

        int result = flatlandSpaceStations(n, c);

        Console.WriteLine(result);
    }
}
