using System;

public class Program
{
    public static void Main(string[] args)
    {
        string line = Console.ReadLine();
        for(int i = 0; i < line.Length - 1; i++)
        {
            if(line[i] == ':' || line[i] == ';')
            {
                if(line[i + 1] == ')')
                {
                    Console.WriteLine(i);
                }
                else if(line[i + 1] == '-' && line[i + 2] == ')')
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
