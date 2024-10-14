using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int numCases = Int32.Parse(strNum);
        int total = 0;
        for(int i = 0; i < numCases; i++)
        {
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(" "), int.Parse);
            for(int j = 1; j < arr.Length; j++)
            {
                total += arr[j] - 1;
            }
            Console.WriteLine(total + 1);
            total = 0;
        }
    }
}
