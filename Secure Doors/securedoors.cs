using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] arga)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        List<string> inBuilding = new List<string>();
        string input = string.Empty;
        string command = string.Empty;
        string name = string.Empty;
        
        for(int i = 0; i < num; i++)
        {
            input = Console.ReadLine();
            command = input.Split(" ")[0];
            name = input.Split(" ")[1];
            
            if(command == "entry" && !inBuilding.Contains(name))
            {
                Console.WriteLine(name + " entered");
                inBuilding.Add(name);
            }
            else if(command == "entry" && inBuilding.Contains(name))
            {
                Console.WriteLine(name + " entered (ANOMALY)");
            }
            else if(command == "exit" && inBuilding.Contains(name))
            {
                Console.WriteLine(name + " exited");
                inBuilding.Remove(name);
            }
            else if(command == "exit" && !inBuilding.Contains(name))
            {
                Console.WriteLine(name + " exited (ANOMALY)");
            }
        }
    }
}
