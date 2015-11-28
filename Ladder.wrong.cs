// This is a Naive solution not using Fibonnacci, it uses the Combinatorial principle behind where k = (positions)! / (1's!)*(2's!)
public static int[] solution(int[] A, int[] B)
{
    ulong[] cache = new ulong[30001];
    int[] result = new int[A.Length];

    for (int i = 0; i < A.Length; i++)
    {
        ulong positionResult;
        if (cache[A[i]] > 0)
        {
            positionResult = cache[A[i]];
        }
        else
        {
            positionResult = CalculatePermutations(A[i]);
            cache[A[i]] = positionResult;
        }

        result[i] = (int)(positionResult % Math.Pow(2, int.MaxValue));
    }

    return result;
}

public static ulong CalculatePermutations(int ladderSize)
{
    if (ladderSize == 1)
    {
        return 1;
    }

    ulong combinationsResult = 0;
    int maxIterations = ladderSize / 2 + ladderSize % 2;
    for (int i = ladderSize; i >= maxIterations; i--)
    {
        int twosAmount = ladderSize - i;
        int onesAmount = i - twosAmount;
        ulong combinations = factorial(i) / (factorial(onesAmount) * factorial(twosAmount));

        combinationsResult += combinations;
    }

    return combinationsResult > 0 ? combinationsResult : 1;
}

public static ulong factorial(int number)
{
    ulong result = (ulong)number;

    for (int i = 1; i < number; i++)
    {
        result = result * (ulong)i;
    }

    return result > 0 ? result : 1;
}
}