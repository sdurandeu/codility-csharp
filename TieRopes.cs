using System;

class Solution
{
    public static void Main(string[] args)
    {
        var response = solution(4, new int[] { 1, 2, 3, 4, 1, 1, 3 });

        Console.WriteLine(string.Join(",", response));
    }

    public static int solution(int k, int[] A)
    {
        int numberOfRopes = 0;
        int currentRopeLenght = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] >= k)
            {
                numberOfRopes++;
                currentRopeLenght = 0;
                continue;
            }

            currentRopeLenght += A[i];
            if (currentRopeLenght >= k)
            {
                numberOfRopes++;
                currentRopeLenght = 0;
            }
        }

        return numberOfRopes;
    }
}
