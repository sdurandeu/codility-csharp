using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(solution("racecar"));
    }

    public static int solution(string word)
    {
        if (word.Length % 2 != 1)
        {
            return -1;
        }

        int midPoint = word.Length / 2;

        for (int i = 0; i < midPoint; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return -1;
            }
        }

        return midPoint;
    }
}

// tests
[TestMethod]
public void TestSolution()
{
	Assert.AreEqual(Solution.solution("aabaac"), -1);

	Assert.AreEqual(Solution.solution("racecar"), 3);

	Assert.AreEqual(Solution.solution("aabbcc"), -1);

	Assert.AreEqual(Solution.solution("aabbgbbaa"), 4);

	Assert.AreEqual(Solution.solution("atoyotasatoyota"), 7);
}