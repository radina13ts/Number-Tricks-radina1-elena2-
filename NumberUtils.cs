using System;

public class NumberUtils
{
	public NumberUtils()
	{
	}
	public static void DrawCircle(double r)
	{
		int bound = (int)Math.Ceiling(r);
		for (int y = bound - 1; y >= -bound; y--)
		{
			for (int x = -bound; x < bound; x++)
			{
				bool isInCicle = x * x + y * y < r * r;
				Console.WriteLine(isInCicle ? "##": "   ");
			}
            Console.WriteLine();
        }
	}
}
