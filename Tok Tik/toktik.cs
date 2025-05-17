using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        
        Dictionary<string, int> viewTracker = new Dictionary<string, int>(num);
        string highestName = string.Empty;
        int highestViews = 0;
        
        for (int i = 0; i < num; i++)
        {
            string[] inputParts = Console.ReadLine().Split(' ', 2);
            string tokName = inputParts[0];
            int tokViews = int.Parse(inputParts[1]);
            
            if (viewTracker.TryGetValue(tokName, out int currentViews))
            {
                int newTotal = currentViews + tokViews;
                viewTracker[tokName] = newTotal;
                
                if (newTotal > highestViews)
                {
                    highestViews = newTotal;
                    highestName = tokName;
                }
            }
            else
            {
                viewTracker.Add(tokName, tokViews);
                
                if (tokViews > highestViews)
                {
                    highestViews = tokViews;
                    highestName = tokName;
                }
            }
        }
        
        Console.WriteLine(highestName);
    }
}
