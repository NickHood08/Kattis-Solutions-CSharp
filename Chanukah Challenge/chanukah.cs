using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numDataSets = Int32.Parse(Console.ReadLine());
        int totalCandles = 0;
        for(int i = 0; i < numDataSets; i++)
        {
            string info = Console.ReadLine();
            int dataSetNum = Int32.Parse(info.Split(" ")[0]);
            int numDays = Int32.Parse(info.Split(" ")[1]);
            totalCandles += numDays;
            for(int j = 1; j <= numDays; j++)
            {
                totalCandles += j;
            }
            Console.WriteLine(dataSetNum + " " + totalCandles);
            totalCandles = 0;
        }
    }
}
