class Solution {
    const int maxSize = 100000;
      
    public int solution(int[] A)
    {
        int[] counter = new int[maxSize];

        foreach (int number in A)
        {
            if (number > 0 && number <= maxSize)
            {
                counter[number - 1] = 1;
            }               
        }

        for (int i = 0; i < maxSize; i++)
        {
            if (counter[i] == 0)                
            {
                return i + 1;
            }
        }

        return maxSize + 1;
    }
}