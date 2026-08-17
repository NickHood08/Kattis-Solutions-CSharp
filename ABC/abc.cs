using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNums = Console.ReadLine();
        string order = Console.ReadLine();
        string orderedNums = string.Empty;
        
        int[] nums = Array.ConvertAll(strNums.Split(" "), int.Parse);
        
        Array.Sort(nums);
        
        for(int i = 0; i < order.Length; i++)
        {
            if(order[i] == 'A')
            {
                orderedNums += nums[0] + " ";
            }
            else if(order[i] == 'B')
            {
                 orderedNums += nums[1] + " ";
            }
            else
            {
                 orderedNums += nums[2] + " ";
            }
        }
        
        orderedNums.Trim();
        Console.WriteLine(orderedNums);
    }
}
