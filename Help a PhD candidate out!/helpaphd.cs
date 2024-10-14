using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumCases = Console.ReadLine();
        int numTestCases = Int32.Parse(strNumCases);
        for(int i = 0; i < numTestCases; i++)
        {
            string input = Console.ReadLine();
            if(input == "P=NP")
            {
                Console.WriteLine("skipped");
            }
            else
            {
                string[] nums = input.Split("+");
                int total = Int32.Parse(nums[0]) + Int32.Parse(nums[1]);
                Console.WriteLine(total);
            }
        }
    }
}
