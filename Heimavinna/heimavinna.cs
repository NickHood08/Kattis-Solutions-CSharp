using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        if(info.Contains(";"))
        {
            int total = 0;
            string[] allProblems = info.Split(";");
            for(int i = 0; i < allProblems.Length; i++)
            {
                if(allProblems[i].Contains("-"))
                {
                    string[] nums = allProblems[i].Split("-");
                    int num1 = Int32.Parse(nums[1]);
                    int num2 = Int32.Parse(nums[0]);
                    total += (num1 - num2) + 1;
                }
                else
                {
                    total += 1;
                }
            }
            Console.WriteLine(total);
        }
        else if(info.Contains("-"))
        {
            string[] nums = info.Split("-");
            int num1 = Int32.Parse(nums[1]);
            int num2 = Int32.Parse(nums[0]);
            Console.WriteLine((num1 - num2) + 1);
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}
