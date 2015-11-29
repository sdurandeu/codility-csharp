using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        solution(new[] { 1, 4, 16 });
    }

    public static int solution(int[] A)
    {
        // calculate prefix sum
        long arraySum = 0; 
        foreach (int i in A) // A.Sum() breaks as it uses Int32
        {
            arraySum += i;
        }

        // calculate theorical sum
        long n = A.Length + 1;
        long theoricalSum = (n * (n + 1)) / 2; // notice long as return type to avoid overflow

        // return difference
        return (int)(theoricalSum - arraySum);
    }
}


// Separate test project
[TestMethod]
public void TestSolution()
{
	var bigRange = Enumerable.Range(2, 100000).ToArray();

	Assert.AreEqual(Solution.solution(bigRange), 1);

	Assert.AreEqual(Solution.solution(new[] { 1, 2, 3, 4 }), 5);

	Assert.AreEqual(Solution.solution(new[] { 2, 3, 1, 5 }), 4);

	Assert.AreEqual(Solution.solution(new[] { 2, 3, 4 }), 1);

	Assert.AreEqual(Solution.solution(new[] { 1, 2, 3, 4, 6 }), 5);

	Assert.AreEqual(Solution.solution(new int[0]), 1);

	Assert.AreEqual(Solution.solution(new[] { 2 }), 1);
}