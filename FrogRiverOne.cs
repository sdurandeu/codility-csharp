using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        solution(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 });
    }

    public static int solution(int X, int[] A)
    {
        bool[] leavesInPosition = new bool[X + 1];

        int occupiedPositions = 0;
        for (int i = 0; i < A.Length; i++)
        {
            int position = A[i];
            if (position <= X && !leavesInPosition[position])
            {
                leavesInPosition[position] = true;
                occupiedPositions++;
            }

            if (occupiedPositions == X)
            {
                return i;
            }
        }

        return -1;
    }
}

// Separate test project
[TestMethod]
public void TestSolution()
{
	Assert.AreEqual(Solution.solution(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 }), 6);

	var bigRange = Enumerable.Range(1, 100000).ToArray();

	Assert.AreEqual(Solution.solution(3, bigRange), 2);       

	Assert.AreEqual(Solution.solution(1, new int[0]), -1);

	Assert.AreEqual(Solution.solution(1, new[] { 1 }), 0);
}