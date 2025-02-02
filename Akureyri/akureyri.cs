using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int index = 0;
        string name = string.Empty;
        string place = string.Empty;
        int placeCount = 0;
        List<string> places = new List<string>();
        List<string> sortedPlaces = new List<string>();
        List<int> placesCount = new List<int>();
        
        for(int i = 0; i < num; i++)
        {
            name = Console.ReadLine();
            place = Console.ReadLine();
            
            if(!places.Contains(place))
            {
                places.Add(place);
                placesCount.Add(1);
            }
            else
            {
                index = places.IndexOf(place);
                placesCount[index] += 1;
            }
        }
        
        sortedPlaces.AddRange(places);
        sortedPlaces.Sort();
        
        for(int i = 0; i < sortedPlaces.Count; i++)
        {
            place = sortedPlaces[i];
            index = places.IndexOf(place);
            placeCount = placesCount[index];
            Console.WriteLine(place + " " + placeCount);
        }
    }
}
