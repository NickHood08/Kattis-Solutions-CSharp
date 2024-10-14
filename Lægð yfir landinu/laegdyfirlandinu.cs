using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int rows = Int32.Parse(info.Split(" ")[0]);
        int cols = Int32.Parse(info.Split(" ")[1]);
        int[,] airPressures = new int[rows,cols];
        bool lowPressureSystem = false;
        for(int i = 0; i < rows; i++)
        {
            string rowInfo = Console.ReadLine();
            int[] rowArray = Array.ConvertAll(rowInfo.Split(" "), int.Parse);
            for(int j = 0; j < cols; j++)
            {
                airPressures[i,j] = rowArray[j];
            }
        }
        
        
        if(rows <= 2 || cols <= 2)
        {
            Console.WriteLine("Neibb");
        }
        else
        {
            //only does rows that have 1 num above and one below
            for(int i = 1; i < (rows - 1); i++)
            {
                //only does cols that have 1 num left and right
                for(int j = 1; j < (cols - 1); j++)
                {
                    //check if all pressures (above, below, left and right) are lower 
                    if(airPressures[i-1,j] > airPressures[i,j] && 
                    airPressures[i+1,j] > airPressures[i,j] &&
                    airPressures[i,j-1] > airPressures[i,j] &&
                    airPressures[i,j+1] > airPressures[i,j])
                    {
                        lowPressureSystem = true;
                        break;
                    }
                }
            }
            
            if(lowPressureSystem)
            {
                Console.WriteLine("Jebb");
            }
            else
            {
                Console.WriteLine("Neibb");
            }
        }
        
    }
}
