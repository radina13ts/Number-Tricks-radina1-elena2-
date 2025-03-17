// See https://aka.ms/new-console-template for more information
NumberUtils test = new NumberUtils();
Console.WriteLine("all prime nums to");
int n = int.Parse(Console.ReadLine());
test.Eratosten(n);


Console.WriteLine("Hello, World!");

NumberUtils test = new NumberUtils();
Console.WriteLine(test.BabylonNRoot(1024, 2));


Console.ReadKey(true);


long baseNumber = long.Parse(Console.ReadLine());

long exponent = long.Parse(Console.ReadLine());

long result = test.FastExponentationUsingSquares(baseNumber, exponent);
Console.WriteLine(result);
Console.ReadKey(true);