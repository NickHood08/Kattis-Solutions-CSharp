using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        string answer = string.Empty;
        string prevAnswer = string.Empty;
        int numCorrect = 0;
        
        for(int i = 0; i < num; i++)
        {
            answer = Console.ReadLine();
            if(answer == prevAnswer)
            {
                numCorrect++;
            }
            prevAnswer = answer;
        }
        
        Console.WriteLine(numCorrect);
    }
}
