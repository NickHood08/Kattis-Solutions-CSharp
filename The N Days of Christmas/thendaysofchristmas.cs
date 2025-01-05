using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int gifts = 0;
        int totalGifts = 0;
        
        for(int i = 1; i <= num; i++)
        {
            gifts += i;
          
            if(i == num)
            {
                totalGifts += i;
            }
            else if(i == 1)
            {
                totalGifts += (i * num);
            }
            else
            {
                totalGifts += (i * (num - (i - 1)));   
            }
        }
        
        Console.WriteLine(gifts);
        Console.WriteLine(totalGifts);
    }
}
