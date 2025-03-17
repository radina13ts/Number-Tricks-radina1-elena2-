// See https://aka.ms/new-console-template for more information
NumberUtils test = new NumberUtils();
/**Console.WriteLine("all prime nums to");
int p = int.Parse(Console.ReadLine());
test.Eratosten(p);


Console.WriteLine("Hello, World!");
Console.WriteLine(test.BabylonNRoot(1024, 2));


Console.ReadKey(true);


long baseNumber = long.Parse(Console.ReadLine());

long exponent = long.Parse(Console.ReadLine());

long result = test.FastExponentationUsingSquares(baseNumber, exponent);
Console.WriteLine(result);
*/


Console.WriteLine("Magic Square:");
Console.Write("n: ");
int n = int.Parse(Console.ReadLine());


int[,] array = new int[n, n];

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < n; j++)
    {
        array[i, j] = input[j];
    }
}

test.IsItAMagicSquare(array);

Console.ReadKey(true);


