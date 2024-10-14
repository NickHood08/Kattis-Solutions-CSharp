using System;

public class Program
{
    public static int monthIntoDays(int month)
    {
        switch(month)
        {
            case 1:
                return 0;
                break;
            case 2:
                return 31;
                break;
            case 3:
                return 59;
                break;
            case 4:
                return 90;
                break;
            case 5:
                return 120;
                break;
            case 6:
                return 151;
                break;
            case 7:
                return 181;
                break;
            case 8:
                return 212;
                break;
            case 9:
                return 243;
                break;
            case 10:
                return 273;
                break;
            case 11:
                return 304;
                break;
            case 12:
                return 334;
                break;
        }
        return 0;
    }
    
    public static void Main(string[] args)
    {
        int day = 4;
        string input = Console.ReadLine();
        int days = Int32.Parse(input.Split(" ")[0]);
        int month = Int32.Parse(input.Split(" ")[1]);
        day += (days - 1) + monthIntoDays(month);
        day %= 7;
        switch(day)
        {
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
        }
    }
}
