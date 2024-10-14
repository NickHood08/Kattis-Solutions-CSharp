using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        bool twoSame = false;
        for(int i = 0; i < input.Length; i++)
        {
            for(int j = i + 1; j < input.Length; j++)
            {
                if(input[i] == input[j])
                {
                    twoSame = true;
                    break;
                }
            }
        }
        if(twoSame)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}
