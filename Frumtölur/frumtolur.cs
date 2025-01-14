using System;

public class Program
{
    public static bool isPrime(int num)
    {
        bool prime = true;
        for(int i = 2; i < num; i++)
        {
            if(num % i == 0)
            {
                prime = false;
                break;
            }
        }
        return prime;
    }
    
    public static void Main(string[] args)
    {
        int num = 2;
        int count = 0;
        
        while(count < 100)
        {
            if(isPrime(num))
            {
                Console.WriteLine(num);
                count++;
            }
            num++;
        }
    }
}
