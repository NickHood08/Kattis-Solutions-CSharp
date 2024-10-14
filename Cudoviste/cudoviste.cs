using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int rows = Int32.Parse(info.Split(" ")[0]);
        int cols = Int32.Parse(info.Split(" ")[1]);
        int numX = 0;
        char[,] parkingSpace = new char[rows, cols];
        char[] spaceInfo = new char[4];
        int[] counter = {0,0,0,0,0};
        
        for(int i = 0; i < rows; i++)
        {
            string rowInfo = Console.ReadLine();
            for(int j = 0; j < cols; j++)
            {
                parkingSpace[i,j] = rowInfo[j];
            }
        }
        
        for(int i = 0; i < rows - 1; i++)
        {
            for(int j = 0; j < cols - 1; j++)
            {
                if(parkingSpace[i,j] != '#' && parkingSpace[i,j + 1] != '#' && parkingSpace[i + 1,j] != '#' && parkingSpace[i + 1,j + 1] != '#')
                {
                    spaceInfo[0] = parkingSpace[i,j];
                    spaceInfo[1] = parkingSpace[i,j + 1];
                    spaceInfo[2] = parkingSpace[i + 1,j];
                    spaceInfo[3] = parkingSpace[i + 1,j + 1];
                    foreach(char c in spaceInfo)
                    {
                        if(c == 'X')
                        {
                            numX += 1;
                        }
                    }
                    if(numX == 0)
                    {
                        counter[0] += 1;
                    }
                    else if(numX == 1)
                    {
                        counter[1] += 1;
                    }
                    else if(numX == 2)
                    {
                        counter[2] += 1;
                    }
                    else if(numX == 3)
                    {
                        counter[3] += 1;
                    }
                    else if(numX == 4)
                    {
                        counter[4] += 1;
                    }
                    numX = 0;
                }
            }
        }
        
        foreach(int n in counter)
        {
            Console.WriteLine(n);
        }
    }
}
