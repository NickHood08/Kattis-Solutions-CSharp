using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strRowsCols = Console.ReadLine();
        int[] arrRowsCols = Array.ConvertAll(strRowsCols.Split(" "), int.Parse);
        string[,] grid = new string[arrRowsCols[0], arrRowsCols[1]];
        string[] arrOriginalString = new string[arrRowsCols[1]];
        string strRow = string.Empty;
        string letter = string.Empty;
        string originalString = string.Empty;
        
        for(int i = 0; i < arrRowsCols[0]; i++)
        {
            strRow = Console.ReadLine();
            for(int j = 0; j < arrRowsCols[1]; j++)
            {
                letter = strRow[j].ToString();
                if(letter != ".")
                {
                    arrOriginalString[j] = letter;
                }
            }
        }
        
        for(int i = 0; i < arrOriginalString.Length; i++)
        {
            originalString += arrOriginalString[i];
        }
        
        Console.WriteLine(originalString);
    }
}
