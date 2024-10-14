using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int row = Int32.Parse(info.Split(" ")[0]);
        int col = Int32.Parse(info.Split(" ")[1]);
        string mineLocation = string.Empty;
        string rowInfo = string.Empty;
        for(int i = 0; i < row; i++)
        {
            rowInfo = Console.ReadLine();
            for(int j = 0; j < col; j++)
            {
                if(rowInfo[j].ToString() == "*")
                {
                    mineLocation += (i + 1) + "," + (j + 1) + " ";
                }
            }
        }
        string[] mineLocArray = mineLocation.Split(" ");
        Console.WriteLine(mineLocArray.Length - 1);
        for(int i = 0; i < mineLocArray.Length - 1; i++)
        {
            string mineRow = mineLocArray[i].Split(",")[0];
            string mineCol = mineLocArray[i].Split(",")[1];
            Console.WriteLine(mineRow + " " + mineCol);
        }
    }
}
