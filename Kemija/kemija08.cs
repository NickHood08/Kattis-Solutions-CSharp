using System;

public class Program
{
    public static void Main(string[] args)
    {
        string vowels = "aeiou";
        string input = Console.ReadLine();
        string codedMessage = string.Empty;
        string letter = string.Empty;
        
        int index = 0;
        
        while(index <= input.Length - 1)
        {
            letter = input[index] + "";
            codedMessage += input[index];
            if(vowels.Contains(letter))
            {
                index += 3;
            }
            else
            {
                index++;
            }
        }
        
        Console.WriteLine(codedMessage);
    }
}
