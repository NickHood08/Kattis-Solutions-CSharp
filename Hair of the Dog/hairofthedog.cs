using System;

public class Program
{
    public static bool isHungover(string prevDay, string day)
    {
        if(day == "drunk" && prevDay != "drunk")
        {
            return true;
        }
        
        return false;
    }
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int numDayHungover = 0;
        string prevDay = string.Empty;
        string day = string.Empty;
        
        for(int i = 0; i < num; i++)
        {
            day = Console.ReadLine();
            
            if(isHungover(prevDay, day))
            {
                numDayHungover++;
            }
            
            prevDay = day;
            day = string.Empty;
        }
        
        Console.WriteLine(numDayHungover);
    }
}
