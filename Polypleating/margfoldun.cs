using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strFoldLongSide = Console.ReadLine();
        string strFoldShortSide = Console.ReadLine();
        
        int foldLongSide = int.Parse(strFoldLongSide);
        int foldShortSide = int.Parse(strFoldShortSide);
        int thickness = foldLongSide * foldShortSide;
        
        Console.WriteLine(thickness);
    }
}
