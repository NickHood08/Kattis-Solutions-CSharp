using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        double numBats = Double.Parse(info);
        string allBats = Console.ReadLine();
        int[] allBatsArray = Array.ConvertAll(allBats.Split(" "), int.Parse);
        double totalRuns = 0.0;
        for(int i = 0; i < allBatsArray.Length; i++)
        {
            if(allBatsArray[i] == -1)
            {
                numBats -= 1;
            }
            else if(allBatsArray[i] > 0)
            {
                totalRuns += allBatsArray[i];
            }
        }
        Console.WriteLine((double) totalRuns / numBats);
    }
}
