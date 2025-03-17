using System;
using System.Security.Cryptography.X509Certificates;

public class NumberUtils
{
    public NumberUtils()
    {

    }
    public void Eratosten(int n)
    { 
        List<int> non = new List<int>();

        for (int i = 2; i < n; i++)
        {
            for (int y = i * 2; y < n; y = y + i)
            {
                if (non.Contains(y) == false)
                {
                    non.Add(y);
                }
            }
        }
        for (int z = 2; z < n; z++)
        {
            if (non.Contains(z) == false)
            {
                Console.Write(z + ", ");
            }
        }
    }


    public long FastExponentationUsingSquares(long baseNum, long exp)
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
	
	public double BabylonNRoot(int num, int n)
	{
		double guess = 1;
		double x = num;
		if (guess == 0)
		{
			return 0;
		}
		while (x - guess > 0.001)
		{
			x = (x + guess) / 2;
			guess = num / x;
		}
		return x;
    }
}
