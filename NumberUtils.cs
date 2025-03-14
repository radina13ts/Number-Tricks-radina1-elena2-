using System;

public class NumberUtils
{
	public NumberUtils()
	{
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
