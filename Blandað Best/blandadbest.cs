using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numOfMeat = Int32.Parse(Console.ReadLine());
        switch(numOfMeat)
        {
            case 1:
                Console.WriteLine(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("blandad best");
                break;
        }
    }
}
