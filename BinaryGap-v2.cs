public static int Solution(int N)
{
    var sequenceCounter = 0;
    var iterations = Math.Floor(Math.Log(N, 2) + 1);
    var maxSequence = 0;
    var startingOne = false;

    for (int i = 0; i < iterations; i++)
    {
        // check if binary digit is 0
        var isCero = (N & (1 << i)) == 0;
        Console.Write(isCero ? "0" : "1");
        if (isCero && startingOne)
        {
            // we are in a 0, only count if there was a 1 before
            sequenceCounter++;
        }
        else if (!isCero)
        {
            // we are in a 1 and the sequence had already started
            if (startingOne && sequenceCounter > maxSequence)
            {
                maxSequence = sequenceCounter;
            }
            // restart the sequence
            startingOne = true;
            sequenceCounter = 0;
        }
    }

    return maxSequence;
}
