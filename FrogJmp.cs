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

    public static int solution(int X, int Y, int D)
    {
        if (D == 0)
        {
            return 0;
        }

        int jumps = (int)Math.Ceiling((double)(Y - X) / D);

        return jumps;
    }
}