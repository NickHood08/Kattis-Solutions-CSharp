using System;

public class Program
{
    public static void Main(string[] args)
    {
        int windSpeed = Int32.Parse(Console.ReadLine());
        int numRoads = Int32.Parse(Console.ReadLine());
        
        for(int i = 0; i < numRoads; i++)
        {
            string roadInfo = Console.ReadLine();
            string roadName = roadInfo.Split(" ")[0];
            int roadWindSpeed = Int32.Parse(roadInfo.Split(" ")[1]);
            if(roadWindSpeed < windSpeed)
            {
                Console.WriteLine(roadName + " lokud");
            }
            else
            {
                Console.WriteLine(roadName + " opin");
            }
        }
    }
}
