using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> distinctModulo = new List<int>();
        for(int i = 0; i < 10; i++)
        {
            string strNum = Console.ReadLine();
            int num = Int32.Parse(strNum);
            int mod = num % 42;
            if(!distinctModulo.Contains(mod))
            {
                distinctModulo.Add(mod);
            }
        }
        Console.WriteLine(distinctModulo.Count);
    }
}
