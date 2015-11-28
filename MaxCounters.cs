using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    const int maxSize = 100000;

    public int[] solution(int N, int[] A)
    {
        int[] counters = new int[maxSize];
        int maxCounterValue = 0;
        int maxCounterOverride = 0;

        foreach (int number in A)
        {
            if (number == N + 1)
            {
                maxCounterOverride = maxCounterValue;
            }
            else
            {
                counters[number - 1] = counters[number - 1] < maxCounterOverride ? maxCounterOverride + 1 : counters[number - 1] + 1;
                maxCounterValue = counters[number - 1] > maxCounterValue ? counters[number - 1] : maxCounterValue;
            }
        }

        for (int i = 0; i < N; i++)
        {
            counters[i] = counters[i] < maxCounterOverride ? maxCounterOverride : counters[i];
        }

        return counters.Take(N).ToArray();
    }
}