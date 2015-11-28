public static int solution(int[] A)
{
    int leader = 0;
    int size = 0;
    int leaderCount = 0;

    // find the leader
    for (int i = 0; i < A.Length; i++)
    {
        if (size == 0)
        {
            size++;
            leader = A[i];
        }
        else
        {
            if (A[i] == leader)
            {
                size++;
            }
            else
            {
                size--;
            }
        }
    }

    if (size == 0)
    {
        return 0;
    }

    leaderCount = A.Count(i => i == leader);

    if (leaderCount <= A.Length / 2)
    {
        return 0;
    }

    int equiCount = 0;

    int leftSideLeaders = 0;
    int rightSideLeaders = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] == leader)
        {
            leftSideLeaders++;
        }

        rightSideLeaders = leaderCount - leftSideLeaders;

        bool leftSideHasLeader = leftSideLeaders > (i + 1) / 2;
        bool rightSideHasLeader = rightSideLeaders > (A.Length - (i + 1)) / 2;

        if (leftSideHasLeader && rightSideHasLeader)
        {
            equiCount++;
        }
    }

    return equiCount;
}