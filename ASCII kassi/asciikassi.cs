using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        string[,] square = new string[num + 2,num + 2];
        for(int i = 0; i < square.GetLength(0); i++)
        {
            for(int j = 0; j < square.GetLength(1); j++)
            {
                if(i == 0 && j == 0)
                {
                    square[i,j] = "+";
                }
                else if(i == (square.GetLength(0) - 1) && j == 0)
                {
                    square[i,j] = "+";
                }
                else if(i == 0 && j == (square.GetLength(1) - 1))
                {
                    square[i,j] = "+";
                }
                else if(i == (square.GetLength(0) - 1) && j == (square.GetLength(1) - 1))
                {
                    square[i,j] = "+";
                }
                else if(i != 0 && i != (square.GetLength(0) - 1) && j != 0 && j != (square.GetLength(1) - 1))
                {
                    square[i,j] = " ";
                }
                else if(j != 0 && j != (square.GetLength(1) - 1) && i == 0 || i == (square.GetLength(0) - 1))
                {
                    square[i,j] = "-";
                }
                else
                {
                    square[i,j] = "|";
                }
            }
        }
        string line = "";
        for(int i = 0; i < square.GetLength(0); i++)
        {
            for(int j = 0; j < square.GetLength(1); j++)
            {
                line += square[i,j];
            }
            Console.WriteLine(line);
            line = string.Empty;
        }
    }
}
