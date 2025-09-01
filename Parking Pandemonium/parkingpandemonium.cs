using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strTime = Console.ReadLine(); //time it takes to circle parking lot
        string strTemp = Console.ReadLine(); //temp of parking lot
        string strTimesCircled = Console.ReadLine(); //number of times circled parking lot
        int time = int.Parse(strTime); //convert time string into integer
        int timesCircled = int.Parse(strTimesCircled); //convert number of times circeled string into integer
        int minutesLooking = time * timesCircled; //total time looking for a parking spot
        Console.WriteLine(minutesLooking);
    }
}
