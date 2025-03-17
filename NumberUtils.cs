using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

    public int sumRow(int[,] array, int row)
    {
        int n = array.GetLength(0);
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[row, i];
        }
        return sum;
    }
    public int sumCol(int[,] array, int col)
    {
        int n = array.GetLength(0);
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i, col];
        }
        return sum;
    }

    public void IsItAMagicSquare(int[,] array)
    {
        int n = array.GetLength(0);
        
        int sumD1 = 0;
        int sumD2 = 0;
        
        for (int i = 0; i < n; i++)
        {
            sumD1 += array[i, i];
            sumD2 += array[i, n - 1 - i];
        }

        List<int>AllSums = new List<int>();
        if (sumD1 == sumD2)
        {
            for (int i = 0; i < n; i++)
            {
                AllSums.Add(sumRow(array, i));
                AllSums.Add(sumCol(array, i));
            }
            if (AllSums.Distinct().Skip(1).Any())
            {
                Console.WriteLine("not magic");
            }
            else
            {
                Console.WriteLine("magic");
            }
        }
        else Console.WriteLine("not magic!");


    }
}








