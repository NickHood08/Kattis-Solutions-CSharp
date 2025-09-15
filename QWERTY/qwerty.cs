using System;

public class Program
{
    public static void Main(string[] args)
    {
        string abcdefKeyboard = "abcdefghijklmnopqrstuvwxyz";
        string qwertyKeyboard = "qwertyuiopasdfghjklzxcvbnm";
        string message = string.Empty;
        string strLen = Console.ReadLine();
        string input = Console.ReadLine();
        
        char character = '*';
        
        int len = int.Parse(strLen);
        int index = 0;
        
        for(int i = 0; i < len; i++)
        {
            character = input[i];
            
            if(qwertyKeyboard.Contains(character))
            {
                index = abcdefKeyboard.IndexOf(character);
                character = qwertyKeyboard[index];
            }
            
            message += character;
        }
        
        Console.WriteLine(message); 
    }
}
