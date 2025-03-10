// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
Console.ReadKey(true);
*/

long baseNumber = long.Parse(Console.ReadLine());

long exponent = long.Parse(Console.ReadLine());

long result = NumberUtils.FastExponentationUsingSquares(baseNumber, exponent);
Console.WriteLine(result);
Console.ReadKey(true);