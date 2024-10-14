using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string line1 = string.Empty;
        string line2 = string.Empty;
        line1 += input1.Split("|")[0] + input2.Split("|")[0];
        line2 += input1.Split("|")[1] + input2.Split("|")[1];
        Console.WriteLine(line1 + " " + line2);
    }
}
