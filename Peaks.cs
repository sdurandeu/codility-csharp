// see http://rafal.io/posts/codility-peaks.html for a better solution
public static int solution(int[] A)
{
    if (A.Length < 3)
    {
        return 0;
    }

    // get a new array with peaks
    bool[] peaks = new bool[A.Length];
    int peaksCounter = 0;
    for (int i = 1; i < A.Length - 1; i++)
    {
        if (A[i] > A[i - 1] && A[i] > A[i + 1])
        {
            peaks[i] = true;
            peaksCounter++;
        }
    }

    // start testing each possible division
    for (int groupSize = 1; groupSize <= A.Length; groupSize++)
    {
        if (A.Length % groupSize == 0) // is divisible
        {
            // test actual divisor
            if (PeaksCorrect(peaks, peaksCounter, groupSize))
            {
                return A.Length / groupSize;
            }                 
        }
    }

    return 0;
}

private static bool PeaksCorrect(bool[] peaks, int peaksCounter, int groupSize)
{
    int groupNumber = peaks.Length / groupSize;

    // should be at least one peak per group
    if (peaksCounter < groupNumber)
    {
        return false;
    }

    // this is what should be improved (should only store the peaks indexes, not the whole array)
    for (int i = 0; i < groupNumber; i++)
    {
        bool hasPeak = peaks.Skip(i * groupSize).Take(groupSize).Any(t => t == true);

        if (!hasPeak)
        {
            return false;
        }
    }

    return true;
}