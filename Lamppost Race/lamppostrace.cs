using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        string input = Console.ReadLine();
        
        int[] distance = Array.ConvertAll(input.Split(" "), int.Parse);
        int distanceBetween = 0;
        int totalDistance = distance[0];
        
        for(int i = 1; i < distance.Length; i++)
        {
            totalDistance += Math.Abs(distance[i] - distance[i-1]);
        }
        
        Console.WriteLine(totalDistance);
    }
}
