class Solution {    
    const int maxSize = 1000000000;
    public  int solution(int[] A)
    {
        int total = 0;
        int preSum = 0;

        foreach (int car in A)
        {
            if (car == 0)
            {
                preSum++;
            }
            else
            {
                total += preSum;
            }

            if (total > maxSize)
            {
                return -1;
            }
        }

        return total;
    }
}