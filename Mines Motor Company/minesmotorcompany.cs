using System;

public class Program
{
    public static void Main(string[] args)
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string strNum = Console.ReadLine();
        string currentWorkStation = Console.ReadLine();
        string newWorkStation = string.Empty;
        string currentRowLetter = string.Empty;
        string currentColLetter = string.Empty;
        string newRowLetter = string.Empty;
        string newColLetter = string.Empty;
        
        int num = int.Parse(strNum);
        int currentRowPos = 0;
        int currentColPos = 0;
        int newRowPos = 0;
        int newColPos = 0;
        int total = 0;
        
        for(int i = 1; i < num; i++)
        {
            newWorkStation = Console.ReadLine();
            currentRowLetter = currentWorkStation[0].ToString();
            currentColLetter = currentWorkStation[1].ToString();
            newRowLetter = newWorkStation[0].ToString();
            newColLetter = newWorkStation[1].ToString();
            currentRowPos = alphabet.IndexOf(currentRowLetter);
            currentColPos = alphabet.IndexOf(currentColLetter);
            newRowPos = alphabet.IndexOf(newRowLetter);
            newColPos = alphabet.IndexOf(newColLetter);
            
            total += Math.Abs(currentRowPos - newRowPos) + Math.Abs(currentColPos - newColPos);
            
            currentWorkStation = newWorkStation;
            newWorkStation = string.Empty;
        }
        
        Console.WriteLine(total);
    }
}
