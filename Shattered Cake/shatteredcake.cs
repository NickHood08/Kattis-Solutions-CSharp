using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strWidth = Console.ReadLine();
        string n = Console.ReadLine();
        int cakeWidth = Int32.Parse(strWidth);
        int numPieces = Int32.Parse(n);
        int totalCake = 0;
        for(int i = 0; i < numPieces; i++)
        {
            string pieceInfo = Console.ReadLine();
            int pieceL = Int32.Parse(pieceInfo.Split(" ")[0]);
            int pieceW = Int32.Parse(pieceInfo.Split(" ")[1]);
            totalCake += pieceL * pieceW;
        }
        int cakeLength = totalCake / cakeWidth;
        Console.WriteLine(cakeLength);
    }
}
