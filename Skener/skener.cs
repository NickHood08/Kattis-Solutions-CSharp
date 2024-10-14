using System;

public class Program
{
    public static void Main(string[] args)
    {
        string nums = Console.ReadLine();
        int rows = Int32.Parse(nums.Split(" ")[0]);
        int chars = Int32.Parse(nums.Split(" ")[1]);
        int repeatRows = Int32.Parse(nums.Split(" ")[2]);
        int repeatChars = Int32.Parse(nums.Split(" ")[3]);
        string[,] inputMatrix = new string[rows,chars];
        
        for(int i = 0; i < rows; i++)
        {
            string rowInfo = Console.ReadLine();
            for(int j = 0; j < chars; j++)
            {
                inputMatrix[i,j] = rowInfo[j].ToString();
            }
        }
        
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < repeatRows; j++)
            {
                for(int k = 0; k < chars; k++)
                {
                    for(int l = 0; l < repeatChars; l++)
                    {
                        Console.Write(inputMatrix[i,k]);
                    }
                }
                Console.Write("\r\n");
            }
        }
    }
}
