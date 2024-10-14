using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int numE = 0;
        string response = "h";
        for(int i = 0; i < input.Length; i++)
        {
            if(input[i].ToString() == "e")
            {
                numE += 1;
            }
        }
        for(int i = 0; i < numE * 2; i++)
        {
            response += "e";
        }
        response += "y";
        Console.WriteLine(response);
    }
}
