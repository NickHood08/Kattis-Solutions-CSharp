using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNums = Console.ReadLine();
        int left = Int32.Parse(strNums.Split(" ")[0]);
        int right = Int32.Parse(strNums.Split(" ")[1]);
        
        if(left == right && left != 0 && right != 0)
        {
            Console.WriteLine("Even " + (left + right));
        }
        else if(left > right || right > left)
        {
            Console.WriteLine("Odd " + (Math.Max(right, left) * 2));
        }
        else if(left == 0 && right == 0)
        {
            Console.WriteLine("Not a moose");
        }
    }
}
