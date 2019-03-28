class Solution {
    public int solution(int[] A) {
        
        Array.Sort(A);
        int result = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > result + 1)
            {
                return result + 1;
            }
            result = A[i] > result ? A[i] : result;
        }
        
        return result + 1;
    }
}
