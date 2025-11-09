using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumLines = Console.ReadLine();
        string input = string.Empty;
        string yesNo = string.Empty;
        string[] inputs = new string[2];
        
        int numLines = int.Parse(strNumLines);
        int mBp = 0;
        int maxNej = 0;
        
        for(int i = 0; i < numLines; i++)
        {
            input = Console.ReadLine();
            inputs = input.Split(" ");
            mBp = int.Parse(inputs[0]);
            
            if(inputs[1] == "nej" && mBp > maxNej)
            {
                maxNej = mBp;
            }
        }
        
        Console.WriteLine(maxNej);
    }
}
