using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strQueueLengths = Console.ReadLine();
        string strLeftTimes = Console.ReadLine();
        string strRightTimes = Console.ReadLine();
        
        int[] queueLengths = Array.ConvertAll(strQueueLengths.Split(" "), int.Parse);
        int[] leftTimes = Array.ConvertAll(strLeftTimes.Split(" "), int.Parse);
        int[] rightTimes = Array.ConvertAll(strRightTimes.Split(" "), int.Parse);
        
        int totalLeftTime = 0;
        int totalRightTime = 0;
        
        for(int i = 0; i < leftTimes.Length; i++)
        {
            totalLeftTime += leftTimes[i];
        }
        
        for(int i = 0; i < rightTimes.Length; i++)
        {
            totalRightTime += rightTimes[i];
        }
        
        if(totalLeftTime > totalRightTime)
        {
            Console.WriteLine("right");
        }
        else if(totalLeftTime < totalRightTime)
        {
            Console.WriteLine("left");
        }
        else
        {
            Console.WriteLine("either");
        }
    }
}
