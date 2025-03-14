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


}
