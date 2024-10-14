using System;

public class Program
{
    public static void Main(string[] args)
    {
        double numCells = Double.Parse(Console.ReadLine());
        double numLanes = Double.Parse(Console.ReadLine());
        
        double numNoCars = 0;
        
        for(int i = 0; i < numLanes; i++)
        {
            string laneInfo = Console.ReadLine();
            for(int j = 0; j < laneInfo.Length; j++)
            {
                if(laneInfo[j] == '.')
                {
                    numNoCars++;
                }
            }
        }
        Console.WriteLine(numNoCars / (numCells*numLanes));
    }
}
