using System;

public class Program
{
    public static void Main(string[] args)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string strNum = Console.ReadLine();
        string input = string.Empty;
        string letter = string.Empty;
        string tempAlphabet = alphabet;
        
        int num = int.Parse(strNum);
        int index = 0;
        
        for(int i = 0; i < num; i++)
        {
            input = Console.ReadLine();
            
            for(int j = 0; j < input.Length; j++)
            {
                letter = input[j].ToString().ToLower();
                if(tempAlphabet.Contains(letter))
                {
                    index = tempAlphabet.IndexOf(letter);
                    tempAlphabet = tempAlphabet.Remove(index, 1);
                }
            }
            
            if(tempAlphabet.Length > 0)
            {
                Console.WriteLine("missing " + tempAlphabet);
            }
            else
            {
                Console.WriteLine("pangram");
            }
            
            tempAlphabet = alphabet;
        }
    }
}
