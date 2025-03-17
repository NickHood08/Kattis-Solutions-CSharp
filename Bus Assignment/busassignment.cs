using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int numStops = Int32.Parse(strNum);
        string input = string.Empty;
        string strGetOff = string.Empty;
        string strGetOn = string.Empty;
        int getOff = 0;
        int getOn = 0;
        int maxNum = 0;
        int numOnBus = 0;
        
        for(int i = 0; i < numStops; i++)
        {
            input = Console.ReadLine();
            strGetOff = input.Split(" ")[0];
            strGetOn = input.Split(" ")[1];
            getOff = Int32.Parse(strGetOff);
            getOn = Int32.Parse(strGetOn);
            
            numOnBus -= getOff;
            numOnBus += getOn;
            
            if(numOnBus > maxNum)
            {
                maxNum = numOnBus;
            }
        }
        
        Console.WriteLine(maxNum);
    }
}
