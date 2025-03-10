using System;

public class NumberUtils
{
	public NumberUtils()
	{
	}

    public static long FastExponentationUsingSquares(long baseNum, long exp)
    {
        long result = 1;

        while (exp > 0)
        {
            if ((exp & 1) == 1)
                result *= baseNum;

            baseNum *= baseNum;
            exp >>= 1;
        }

        return result;
    }
}
