using System;

public class Program
{
    public static void Main(string[] args)
    {
        string n = Console.ReadLine();
        int numDays = Int32.Parse(n);
        string input = Console.ReadLine();
        int[] arr1 = Array.ConvertAll(input.Split(" "), int.Parse);
        input = Console.ReadLine();
        int[] arr2 = Array.ConvertAll(input.Split(" "), int.Parse);
        input = Console.ReadLine();
        int[] arr3 = Array.ConvertAll(input.Split(" "), int.Parse);
        int[] temp = new int[3];
        string result = string.Empty;
        
        for(int i = 0; i < numDays; i++)
        {
            temp[0] = arr1[i];
            temp[1] = arr2[i];
            temp[2] = arr3[i];
            Array.Sort(temp);
            result += temp[1] + " ";
        }
        
        result.Trim();
        Console.WriteLine(result);
    }
}
