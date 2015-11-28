public static int solution(int N)
{
    var sqrt = (long)Math.Floor(Math.Sqrt(N));

    for (long i = sqrt; i > 0; i--)
    { 
        if (N % i == 0) // is divisible by i
        {
            return (int)(2 * ((i) + (N / i)));
        }
    }

    return 0;
}