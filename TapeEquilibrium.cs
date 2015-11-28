private const int maxLenght = 100000;

public static int Solution(int[] A)
{
    int length = A.Length;

    int[] partialSums = new int[maxLenght];

    // calculate partial sums
    for (int i = 0; i < length; i++)
    {              
        partialSums[i] = i > 0 ? A[i] + partialSums[i - 1] : A[i];
    }

    int minimalValue = int.MaxValue;

    // get minimal value
    for (int i = 0; i < length -1 ; i++)
    {
        int difference = Math.Abs(partialSums[i] - (partialSums[length - 1] - partialSums[i]));

        minimalValue = difference < minimalValue ? difference : minimalValue;
    }

    return minimalValue;
}