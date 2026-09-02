using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumDays = Console.ReadLine();
        string strNumDaysWait = Console.ReadLine();
        string strInput = string.Empty;
        
        int numDays = int.Parse(strNumDays);
        int numDaysWait = int.Parse(strNumDaysWait);
        int input = 0;
        int jennysChoicePayout = 0;
        int bestProfit = 0;
        int tempProfit = 0;
        int sellDay = 0;
        
        int[] priceOfDay = new int[numDays];
        
        for(int i = 0; i < numDays; i++)
        {
            strInput = Console.ReadLine();
            input = int.Parse(strInput);
            priceOfDay[i] = input;
        }
        
        jennysChoicePayout = priceOfDay[numDaysWait] - priceOfDay[0];
        bestProfit = jennysChoicePayout;
        
        for(int i = 0; i < priceOfDay.Length; i++)
        {
            sellDay = i + numDaysWait;
            
            if(sellDay < priceOfDay.Length)
            {
                tempProfit = priceOfDay[sellDay] - priceOfDay[i];
                if(tempProfit > bestProfit)
                {
                    bestProfit = tempProfit;
                }
            }
            else
            {
                break;
            }
        }
        
        Console.WriteLine(bestProfit);
    }
}
