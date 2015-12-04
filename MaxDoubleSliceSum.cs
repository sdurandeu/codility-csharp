using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {

    }

    public static int solution(int[] A)
    {
        // see http://codesays.com/2014/solution-to-max-double-slice-sum-by-codility/
        if (A.Length < 4)
        {
            return 0;
        }

        // get starting max slice
        int[] endingMaxSum = new int[A.Length];
        for (int i = 1; i < A.Length; i++)
        {
            endingMaxSum[i] = Math.Max(0, endingMaxSum[i - 1] + A[i]);
        }

        // get ending max slice
        int[] startingMaxSum = new int[A.Length];
        for (int i = A.Length - 2; i >= 0; i--)
        {
            startingMaxSum[i] = Math.Max(0, startingMaxSum[i + 1] + A[i]);
        }

        // find max
        int maxDoubleSlice = 0;
        for (int i = 0; i < A.Length - 2; i++)
        {
            maxDoubleSlice = Math.Max(maxDoubleSlice, endingMaxSum[i] + startingMaxSum[i + 2]);
        }

        return maxDoubleSlice;
    }
}

// tests
[TestMethod]
public void TestSolution()
{
    Assert.AreEqual(Solution.solution(new[] { 6, 1, 5, 6, 4, 2, 9, 4 }), 26);

    Assert.AreEqual(Solution.solution(new[] { 3, 2, 6, -1, 4, 5, -1, 2 }), 17);

    Assert.AreEqual(Solution.solution(new[] { 2, 1, 1, 2, 3, 1 }), 6);

    Assert.AreEqual(Solution.solution(new[] { -3, 1, 2, -2, 5, 6 }), 8);

    Assert.AreEqual(Solution.solution(new[] { 1, 1, 2 }), 0);

    Assert.AreEqual(Solution.solution(new[] { 1, 2, 2, 2 }), 2);

    Assert.AreEqual(Solution.solution(new[] { -5, 5, -5, 4 }), 5);

    Assert.AreEqual(Solution.solution(new[] { 0, 0, 0, 0 }), 0);

    Assert.AreEqual(Solution.solution(new[] { -1, -1, -1, -1 }), 0);

    Assert.AreEqual(Solution.solution(new[] { 1, 1, 0, 10, -100, 10, 0 }), 21);                   
}
