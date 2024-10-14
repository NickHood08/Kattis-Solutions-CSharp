using System;

public class Program
{
    public static void Main(string[] args)
    {
        string nums = Console.ReadLine();
        int rows = Int32.Parse(nums.Split(" ")[0]);
        int cols = Int32.Parse(nums.Split(" ")[1]);
        string secretMessage = "";
        for(int i = 0; i < rows; i++)
        {
            string code = Console.ReadLine();
            for(int j = 0; j < cols; j++)
            {
                if(code[j].ToString() != ".")
                {
                    secretMessage += code[j].ToString();
                }
            }
        }
        Console.WriteLine(secretMessage);
    }
}
