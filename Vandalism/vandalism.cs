using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name = "UAPC";
        string input = Console.ReadLine();
        
        for(int i = 0; i < input.Length; i++)
        {
            name = name.Replace(input[i].ToString(), string.Empty);
        }
        
        Console.WriteLine(name);
    }
}
