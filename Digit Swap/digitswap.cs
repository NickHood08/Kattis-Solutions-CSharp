using System;

public class Program
{
    public static void Main(string[] args)
    {
        string num = Console.ReadLine();
        char[] charArray = num.ToCharArray();
        Array.Reverse(charArray);
        string reversedNum = new string(charArray);
        Console.WriteLine(reversedNum);
    }
}
