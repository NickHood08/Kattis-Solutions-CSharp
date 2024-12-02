using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int[] nums = new int[num];
        
        for(int i = 0; i < num; i++)
        {
            string strInput = Console.ReadLine();
            int input = Int32.Parse(strInput);
            nums[i] = input;
        }
        
        for(int i = num - 1; i >= 0; i--)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
