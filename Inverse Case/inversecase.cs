using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string inverse = string.Empty;
        
        for(int i = 0; i < input.Length; i++)
        {
            if(char.IsLetter(input[i]))
            {
                if(char.IsUpper(input[i]))
                {
                    inverse += input[i].ToString().ToLower();
                }
                else
                {
                    inverse += input[i].ToString().ToUpper();
                }
            }
            else
            {
                inverse += input[i];
            }
        }
        
        Console.WriteLine(inverse);
    }
}
