using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int numCases = Int32.Parse(Console.ReadLine());
        for(int i = 0; i < numCases; i++)
        {
            int numTrips = Int32.Parse(Console.ReadLine());
            List<string> places = new List<string>();
            for(int j = 0; j < numTrips; j++)
            {
                string place = Console.ReadLine();
                if(!places.Contains(place))
                {
                    places.Add(place);
                }
            }
            Console.WriteLine(places.Count);
            places.Clear();
        }
        
    }
}
