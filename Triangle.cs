public static int solution(int[] A)
{
    Array.Sort(A);

    for (int i = 2; i < A.Length; i++)
    {
        long sum = (long)A[i - 1] + (long)A[i - 2];
        if (sum > A[i])
        {
            return 1;
        }
    }

    return 0;
}