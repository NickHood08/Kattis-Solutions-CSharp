using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int numPeople = Int32.Parse(strNum);
        List<string> line = new List<string>();
        
        string person = string.Empty;
        for(int i = 0; i < numPeople; i++)
        {
            person = Console.ReadLine();
            line.Add(person);
        }
        
        string strNumCommands = Console.ReadLine();
        int numCommands = Int32.Parse(strNumCommands);
        string commandInfo = string.Empty;
        string command = string.Empty;
        string commandPerson = string.Empty;
        string commandPersonCut = string.Empty;
        for(int i = 0; i < numCommands; i++)
        {
            commandInfo = Console.ReadLine();
            command = commandInfo.Split(" ")[0];
            commandPerson = commandInfo.Split(" ")[1];
            if(command == "cut")
            {
                commandPersonCut = commandInfo.Split(" ")[2];
                line.Insert(line.IndexOf(commandPersonCut), commandPerson);
            }
            else
            {
                line.Remove(commandPerson);
            }
        }
        
        for(int i = 0; i < line.Count; i++)
        {
            Console.WriteLine(line[i]);
        }
    }
}
