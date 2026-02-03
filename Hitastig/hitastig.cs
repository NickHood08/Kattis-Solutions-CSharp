using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int numDays = Int32.Parse(strNum);
        string temps = Console.ReadLine();
        long[] tempsArray = Array.ConvertAll(temps.Split(" "), long.Parse);
        long min = tempsArray.Min();
        long max = tempsArray.Max();
        
        Console.WriteLine(max + " " + min);
    }
}
