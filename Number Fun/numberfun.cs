using System;

public class Program
{
    public static bool add(int num1, int num2, int num3)
    {
        return num1 + num2 == num3;
    }
    
    public static bool sub(int num1, int num2, int num3)
    {
        return Math.Abs(num1 - num2) == num3;
    }
    
    public static bool mult(int num1, int num2, int num3)
    {
        return num1 * num2 == num3;
    }
    
    public static bool div(int num1, int num2, int num3)
    {
        double dNum1 = num1;
        double dNum2 = num2;
        double dNum3 = num3;
        
        if(dNum1 > dNum2)
        {
            return dNum1 / dNum2 == dNum3;
        }
        else
        {
            return dNum2 / dNum1 == dNum3;
        }
    }
    
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n = int.Parse(input);
        int[] nums = new int[3];
        int a = 0;
        int b = 0;
        int c = 0;
        
        for(int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            nums = Array.ConvertAll(input.Split(" "), int.Parse);
            a = nums[0];
            b = nums[1];
            c = nums[2];

            if(add(a, b, c) || sub(a, b, c) || mult(a, b, c) || div(a, b, c))
            {
                Console.WriteLine("Possible");
            }
            else
            {
                Console.WriteLine("Impossible");
            }
        }
    }
}
