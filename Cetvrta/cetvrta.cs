using System;

public class Program
{
    public static void Main(string[] args)
    {
        string coords1 = Console.ReadLine();
        string coords2 = Console.ReadLine();
        string coords3 = Console.ReadLine();
        int x1 = Int32.Parse(coords1.Split(" ")[0]);
        int y1 = Int32.Parse(coords1.Split(" ")[1]);
        int x2 = Int32.Parse(coords2.Split(" ")[0]);
        int y2 = Int32.Parse(coords2.Split(" ")[1]);
        int x3 = Int32.Parse(coords3.Split(" ")[0]);
        int y3 = Int32.Parse(coords3.Split(" ")[1]);
        int x4 = 0;
        int y4 = 0;
        if(x1 == x2){ x4 = x3; }
        else if(x2 == x3) { x4 = x1; }
        else if(x1 == x3) { x4 = x2; }
        else { x4 = x1; }
        if(y1 == y2) { y4 = y3; }
        else if(y2 == y3) { y4 = y1; }
        else if(y1 == y3) { y4 = y2; }
        else { y4 = y1; }
        Console.WriteLine(x4 + " " + y4);
    }
}
