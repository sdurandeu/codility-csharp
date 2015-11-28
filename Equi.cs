using System;

class Solution
{
    static void Main(string[] args)
    {
        int sol = solution(new int[] { -1, 3, -4, 5, 1, -6, 2, 1 });

        Console.WriteLine(sol);
    }

    static int solution(int[] A)
    {
        if (A.Length == 0)
        {
            return -1;
        }

        if (A.Length == 1)
        {
            return 0;
        }

        // calculate prefix sums
        long prefixSum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            prefixSum += (long)A[i];
        }

        // find equi
        long leftSum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            long rightSum = prefixSum - (leftSum + A[i]);

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += (long)A[i];
        }

        return -1;
    }
}