using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int numPresses = Int32.Parse(strNum);
        if(numPresses % 2 == 0)
        {
            int totalSeconds = 0;
            while(numPresses > 0)
            {
                string strStart = Console.ReadLine();
                string strStop = Console.ReadLine();
                int start = Int32.Parse(strStart);
                int stop = Int32.Parse(strStop);
                totalSeconds += stop - start;
                numPresses -= 2;
            }
            Console.WriteLine(totalSeconds);
        }
        else
        {
            Console.WriteLine("still running");
        }
    }
}
