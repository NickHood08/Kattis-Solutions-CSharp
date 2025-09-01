using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumPeople = Console.ReadLine();
        string strRecommendedDist = Console.ReadLine();
        
        int numPeople = int.Parse(strNumPeople);
        int recommendedDist = int.Parse(strRecommendedDist);
        int maxDist = (numPeople - 1) * recommendedDist;
        
        Console.WriteLine(maxDist);
    }
}
