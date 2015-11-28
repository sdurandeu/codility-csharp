private const int maxLength = 100000;
private const int isPermutation = 1;
private const int isNotPermutation = 0;

public int solution(int[] A)
{
    int length = A.Length;

    int[] countingArray = new int[maxLength]; // initialized to 0 by default

    for (int i = 0; i < length; i++)
    {
        if (A[i] > maxLength)
        {
            return isNotPermutation;
        }
        else
        {
            countingArray[A[i] - 1] = 1;
        }
    }

    for (int i = 0; i < length; i++)
    {               
        if (countingArray[i] == 0)
        {
            return isNotPermutation;
        }
    }

    return isPermutation;
}