using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] points = new int[5];
        int totalPoints = 0;
        int maxPointsPos = 0;
        int maxPoints = 0;
        for(int i = 0; i < 5; i++)
        {
            string allPoints = Console.ReadLine();
            int[] allPointsArray = Array.ConvertAll(allPoints.Split(" "), int.Parse);
            for(int j = 0; j < allPointsArray.Length; j++)
            {
                totalPoints += allPointsArray[j];
            }
            points[i] = totalPoints;
            totalPoints = 0;
        }
        
        for(int i = 0; i < points.Length; i++)
        {
            if(points[i] > maxPoints)
            {
                maxPointsPos = i + 1;
                maxPoints = points[i];
            }
        }
        Console.WriteLine(maxPointsPos + " " + maxPoints);
    }
}
