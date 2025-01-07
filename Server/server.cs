using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int numTasks = Int32.Parse(input.Split(" ")[0]);
        int time = Int32.Parse(input.Split(" ")[1]);
        string allTasks = Console.ReadLine();
        int[] taskTimes = Array.ConvertAll(allTasks.Split(" "), int.Parse);
        int numTasksComplete = 0;
        
        for(int i = 0; i < numTasks; i++)
        {
            if(time >= taskTimes[i])
            {
                time -= taskTimes[i];
                numTasksComplete++;
            }
            else
            {
                break;
            }
        }
        
        Console.WriteLine(numTasksComplete);
    }
}
