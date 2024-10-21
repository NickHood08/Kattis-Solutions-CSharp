using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        string inputs = Console.ReadLine();
        int sum = 0;
        if(num != 0)
        {
            int[] allNums = Array.ConvertAll(inputs.Split(), int.Parse);
            for(int i = 0; i < allNums.Length; i++)
            {
                if(allNums[i] < 0)
                {
                    sum += (-1 * allNums[i]);
                }
            }
        }
        Console.WriteLine(sum);
    }
}
