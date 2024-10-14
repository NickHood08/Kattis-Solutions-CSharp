using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numOfSlices = Int32.Parse(Console.ReadLine());
        int numOfPeople = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine(numOfSlices % numOfPeople);
    }
}
