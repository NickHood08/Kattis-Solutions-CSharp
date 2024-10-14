using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string strRows = Console.ReadLine();
        int rowsCols = Int32.Parse(strRows);
        List<string> directFlights = new List<string>();
        for(int i = 0; i < rowsCols; i++)
        {
            string rowInfo = Console.ReadLine();
            for(int j = 0; j < rowsCols; j++)
            {
                int flight =  Int32.Parse(rowInfo.Split(" ")[j]);
                if(flight > 0)
                {
                    directFlights.Add((i + 1) + " " + (j + 1) + " " + flight);
                }
            }
        }
        Console.WriteLine(directFlights.Count);
        foreach(string flight in directFlights)
        {
            Console.WriteLine(flight);
        }
    }
}
