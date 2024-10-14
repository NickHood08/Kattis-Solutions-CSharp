using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int rows = Int32.Parse(info.Split(" ")[0]);
        int cols = Int32.Parse(info.Split(" ")[1]);
        int numPairs = Int32.Parse(info.Split(" ")[2]);
        string[,] mineField = new string[rows,cols];
        for(int i = 0; i < numPairs; i++)
        {
            string mineInfo = Console.ReadLine();
            int mineRow = Int32.Parse(mineInfo.Split(" ")[0]) - 1;
            int mineCol = Int32.Parse(mineInfo.Split(" ")[1]) - 1;
            mineField[mineRow ,mineCol] = "*";
        }
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(mineField[i,j] != "*")
                {
                    mineField[i,j] = ".";
                }
                Console.Write(mineField[i,j]);
            }
            Console.WriteLine();
        }
        
        
    }
}
