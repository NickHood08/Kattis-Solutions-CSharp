using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        float b = 0.0000F;
        float p = 0.0000F;
        for(int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            b = float.Parse(input.Split(" ")[0]);
            p = float.Parse(input.Split(" ")[1]);
            float bpm = (60 * b) / p;
            float apbm = 60 / p;
            Console.WriteLine((bpm - apbm) + " " + (bpm) + " " + (bpm + apbm));
        }
    }
}
