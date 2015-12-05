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

    public static int solution(int N)
    {
        string binaryRepresentation = Convert.ToString(N, 2);

        // search max binary gap
        int longestBinaryGap = 0;
        int binaryGapLenght = 0;
        for (int i = 1; i < binaryRepresentation.Length; i++)
        {
            if (binaryRepresentation[i-1] == '1' && binaryRepresentation[i] == '0')
            {
                binaryGapLenght = 1;
            }
            else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '0')
            {
                binaryGapLenght++;
            }
            else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '1')
            {
                longestBinaryGap = Math.Max(longestBinaryGap, binaryGapLenght);
            }
        }

        return longestBinaryGap;
    }
}

// tests
[TestMethod]
public void TestSolution()
{
	Assert.AreEqual(Solution.solution(9), 2);

	Assert.AreEqual(Solution.solution(2), 0);

	Assert.AreEqual(Solution.solution(5), 1);

	Assert.AreEqual(Solution.solution(1041), 5);

	Assert.AreEqual(Solution.solution(0), 0);

	Assert.AreEqual(Solution.solution(511), 0);

	Assert.AreEqual(Solution.solution(126), 0);

	Assert.AreEqual(Solution.solution(12320), 6);
}