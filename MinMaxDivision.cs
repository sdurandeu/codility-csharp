using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        var response = solution(2, 10, new int[] { 4, 4 });

        Console.WriteLine(response);
    }

    public static int solution(int K, int M, int[] A)
    {
        long sumLowerBound = A.Max();
        long sumUpperBound = A.Sum();

        long result = 0;
        // binary search in the large sums testing for the validity of the solution
        while (sumLowerBound <= sumUpperBound) 
        {
            long midVal = (sumLowerBound + sumUpperBound) / 2;
            bool isValid = isValidSolution(A, midVal, K);

            if (isValid)
            {
                sumUpperBound = midVal - 1;
                result = midVal;
            }
            else
            {
                sumLowerBound = midVal + 1;
            }
        }

        return (int)result;
    }

    public static bool isValidSolution(int[] A, long M, int K)
    {
        int partialSum = A[0];
        int intervals = 0;
        for (int i = 1; i < A.Length; i++)
        {
            if (partialSum + A[i] > M)
            {
                partialSum = A[i];
                intervals++;
            }
            else
            {
                partialSum += A[i];
            }

            if (intervals >= K)
            {
                return false;
            }
        }

        return true;
    }
}
