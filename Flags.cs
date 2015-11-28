using System;
using System.Collections.Generic;
using System.Linq;

// using simple binary search similar to JS solution here: http://stackoverflow.com/questions/19466115/peak-and-flag-codility-latest-chellange
public static int solution(int[] A)
{
    if (A.Length < 3)
    {
        return 0;
    }

    // get a new array with peaks
    List<int> peaks = new List<int>();
    for (int i = 1; i < A.Length - 1; i++)
    {
        if (A[i] > A[i - 1] && A[i] > A[i + 1])
        {
            peaks.Add(i);
        }
    }

    // if a 1-2 peaks, we can return them directly
    if (peaks.Count <= 2)
    {
        return peaks.Count;
    }

    // start binary search
    int maxFlags = peaks.Count;
    int minFlags = 1;
    int result = 0;
    while (maxFlags >= minFlags)
    {
        int flags = (minFlags + maxFlags) / 2; // get middle of interval (binary search)
        if (CheckFlags(flags, peaks))
        {
            result = flags;
            minFlags = flags + 1;
        }
        else
        {
            maxFlags = flags - 1;
        }
    }

    return result;
}

private static bool CheckFlags(int flagsCount, List<int> flags)
{
    int i = 1;
    // assume first flag in first position
    int lastFlag = flags[0]; 
    int actualFlags = flagsCount - 1;
    while (actualFlags > 0 && i < flags.Count)
    {
        if (flags[i] - lastFlag >= flagsCount)
        {
            actualFlags--; // can put one flag
            lastFlag = flags[i];
        }

        i++;
    }

    return actualFlags == 0; // all flags were placed
}