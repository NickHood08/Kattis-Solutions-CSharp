using System;

public class Program
{
    public static int sumPositiveInts(int num)
    {
        int sum = 0;
        for(int i = 1; i <= num; i++)
        {
            sum += i;
        }
        return sum;
    }
    
    public static int sumFirstOddInts(int num)
    {
        int sum = 0;
        int tracker = 0;
        int number = 1;
        while(tracker != num)
        {
            if(number % 2 != 0)
            {
                sum += number;
                tracker += 1;
            }
            number += 1;
        }
        return sum;
    }
    
    public static int sumFirstEvenInts(int num)
    {
        int sum = 0;
        int tracker = 0;
        int number = 1;
        while(tracker != num)
        {
            if(number % 2 == 0)
            {
                sum += number;
                tracker += 1;
            }
            number += 1;
        }
        return sum;
    }
    
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int numCases = Int32.Parse(strNum);
        for(int i = 0; i < numCases; i++)
        {
            string info = Console.ReadLine();
            int[] infoArray = Array.ConvertAll(info.Split(" "), int.Parse);
            Console.WriteLine(infoArray[0] + " " + sumPositiveInts(infoArray[1]) + " " + sumFirstOddInts(infoArray[1]) + " " + sumFirstEvenInts(infoArray[1]));
        }
    }
}
