using System;

public class Program
{
    public static int sumDigits(int num)
    {
        int sum = 0;
        
        while(num != 0)
        {
            sum += (num % 10);
            num /= 10;
        }
        
        return sum;
    }
    
    public static void Main(string[] args)
    {
        int L = Int32.Parse(Console.ReadLine());
        int D = Int32.Parse(Console.ReadLine());
        int X = Int32.Parse(Console.ReadLine());
        
        int min = 0;
        int max = 0;
        
        for(int i = L; i <= D; i++)
        {
            if(sumDigits(i) == X)
            {
                min = i;
                break;
            }
        }
        
        for(int i = D; i >= L; i--)
        {
            if(sumDigits(i) == X)
            {
                max = i;
                break;
            }
        }
        
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}
