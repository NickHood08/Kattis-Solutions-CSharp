using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string strN = Console.ReadLine();
        int n = Int32.Parse(strN);
        List<string> cpu = new List<string>();
        List<string> memory = new List<string>();
        List<string> hardDrive = new List<string>();
        
        for(int i = 0; i < n; i++)
        {
            string serverInfo = Console.ReadLine();
            string[] letters = serverInfo.Split(" ");
            for(int j = 0; j < letters.Length; j++)
            {
                if(letters[j] == "J" && j == 0)
                {
                    cpu.Add(letters[j]);
                }
                else if(letters[j] == "J" && j == 1)
                {
                    memory.Add(letters[j]);
                }
                else if(letters[j] == "J" && j == 2)
                {
                    hardDrive.Add(letters[j]);
                }
            }
        }
        
        int numServers = Math.Min(cpu.Count, Math.Min(memory.Count, hardDrive.Count));
        Console.WriteLine(numServers);
    }
}
