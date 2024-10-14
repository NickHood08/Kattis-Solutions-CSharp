using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strDays = Console.ReadLine();
        int numDays = Int32.Parse(strDays);
        string input = Console.ReadLine();
        int dayToLaunch = 0;
        int[] junk = Array.ConvertAll(input.Split(" "), int.Parse);
        for(int i = 1; i < numDays; i++)
        {
            if(junk[i] < junk[dayToLaunch])
            {
                dayToLaunch = i;
            }
        }
        Console.WriteLine(dayToLaunch);
    }
}
