using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        string input = Console.ReadLine();
        
        int num = int.Parse(strNum);
        int[] chocoPieces = Array.ConvertAll(input.Split(" "), int.Parse);
        int minNumBoxes = 0;
        
        for(int i = 0; i < chocoPieces.Length - 1; i++)
        {
            if(chocoPieces[i + 1] > chocoPieces[i])
            {
                minNumBoxes++;
            }
        }
        
        Console.WriteLine(minNumBoxes);
    }
}
