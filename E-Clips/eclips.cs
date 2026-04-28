using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string output = string.Empty;
        string word = string.Empty;
        string[] arr = input.Split(" ");
        
        for(int i = 0; i < arr.Length; i++)
        {
            word = arr[i];
            if(word.Contains("e"))
            {
                output += word + " ";
            }
        }
        
        output.Trim();
        
        if(output.Length > 0)
        {
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("oh noes");   
        }
    }
}
