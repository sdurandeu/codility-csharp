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
        Array.Sort(A);

        var topMaximum = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
        var bottomMaxium = A[0] * A[1] * A[A.Length - 1];

        return Math.Max(topMaximum, bottomMaxium);
    }
}

// Tests
[TestMethod]
public void TestSolution()
{
	Assert.AreEqual(Solution.solution(new[] { -3, 1, 2, -2, 5, 6 }), 60);

	Assert.AreEqual(Solution.solution(new[] { 1, 1, 2 }), 2);

	Assert.AreEqual(Solution.solution(new[] { -5, 5, -5, 4 }), 125);
}