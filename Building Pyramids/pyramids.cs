using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int numBlocks = Int32.Parse(strNum);
        int height = 0;
        int length = 1;
        int width = 1;
        
        while(numBlocks >= (width * length))
        {
            numBlocks -= (width * length);
            height += 1;
            width += 2;
            length += 2;
        };
        
        Console.WriteLine(height);
    }
}
