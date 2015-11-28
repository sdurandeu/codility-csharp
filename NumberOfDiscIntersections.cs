public static int solution(int[] A)
{
    // obtain ordered starts array
    long[] starts = new long[A.Length];
    for (int i = 0; i < A.Length; i++)
    {
        starts[i] = i - A[i];
    }
    Array.Sort(starts);

    // obtain ordered ends array
    long[] ends = new long[A.Length];
    for (int i = 0; i < A.Length; i++)
    {
        ends[i] = i + A[i];
    }
    Array.Sort(ends);

    // find intersections
    int intersections = 0;
    int counter = 0;
    int startsIndex = 0;
    int endsIndex = 0;

    while (startsIndex < starts.Length || endsIndex < ends.Length)
    {
        if (startsIndex < starts.Length && starts[startsIndex] <= ends[endsIndex])
        {
            counter++;
            startsIndex++;
        }
        else
        {
            counter--;
            intersections = intersections + counter;
            endsIndex = endsIndex <= (ends.Length - 1) ? endsIndex + 1 : endsIndex;
        }

        if (intersections > 10000000)
        {
            return -1;
        }
    }

    return intersections;
}