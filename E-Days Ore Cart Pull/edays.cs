using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strMiles = Console.ReadLine();
        string strNumStudents = Console.ReadLine();
        string strTemp = Console.ReadLine();
        int miles = int.Parse(strMiles);
        int totalMiles = miles * 2;
        Console.WriteLine(totalMiles);
    }
}
