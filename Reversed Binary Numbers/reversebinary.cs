using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num = Int32.Parse(Console.ReadLine());
        string numBinary = Convert.ToString(num, 2);
        char[] charArray = numBinary.ToCharArray();
        Array.Reverse(charArray);
        string reversedBinary = new string(charArray);
        int newNum = Convert.ToInt32(reversedBinary, 2);
        Console.WriteLine(newNum);
    }
}
