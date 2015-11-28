using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public void Main(string[] args)
    {
        var response = solution(new int[] { 4, 4, 5, 5, 1 }, new int[] { 3, 2, 4, 3, 1 });

        Console.WriteLine(string.Join(",", response));
    }

    public int[] solution(int[] A, int[] B)
    {
        int maxLadderSize = A.Max();

        ulong[] fibo = BuildFiboSecuence(maxLadderSize +2);
        int[] result = new int[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            ulong positionResult = fibo[A[i]];

            result[i] = (int)(positionResult & (ulong)((1 << B[i]) - 1));
        }

        return result;
    }

    public ulong[] BuildFiboSecuence(int ladderSize)
    {
        ulong[] fibo = new ulong[ladderSize];

        fibo[0] = 1;
        fibo[1] = 1;

        for (int i = 2; i < ladderSize; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }

        return fibo;
    }
}