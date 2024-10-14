using System;

public class CurtainCounter
{
    public static void Main(string[] args)
    {
        int totalCurtains = Int32.Parse(Console.ReadLine());
        int openedCurtains = Int32.Parse(Console.ReadLine());
        Console.WriteLine(Math.Abs(totalCurtains - openedCurtains));
    }
}
