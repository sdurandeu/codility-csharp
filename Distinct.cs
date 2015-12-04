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
        if (A.Length == 0)
        {
            return 0;
        }

        Array.Sort(A);

        int distinctCount = 1;
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] != A[i - 1])
            {
                distinctCount++;
            }
        }

        return distinctCount;
    }
}

// tests
[TestMethod]
public void TestSolution()
{
	Assert.AreEqual(Solution.solution(new[] { 2, 1, 1, 2, 3, 1 }), 3);

	Assert.AreEqual(Solution.solution(new[] { -3, 1, 2, -2, 5, 6 }), 6);

	Assert.AreEqual(Solution.solution(new[] { 1, 1, 2 }), 2);

	Assert.AreEqual(Solution.solution(new[] { 1, 2, 2, 2 }), 2);

	Assert.AreEqual(Solution.solution(new[] { -5, 5, -5, 4 }), 3);

	Assert.AreEqual(Solution.solution(new[] { 0, 0, 0, 0 }), 1);
}
