using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int[] allPieces = Array.ConvertAll(info.Split(" "), int.Parse);
        int[] setPieces = {1, 1, 2, 2, 2, 8};
        int[] finalPieces = new int[6];
        for(int i = 0; i < 6; i++)
        {
            if(allPieces[i] > setPieces[i] || allPieces[i] < setPieces[i])
            {
                finalPieces[i] = setPieces[i] - allPieces[i];
            }
            else
            {
                finalPieces[i] = 0;
            }
        }
        
        for(int i = 0; i < finalPieces.Length; i++)
        {
            if(i == (finalPieces.Length - 1))
            {
                Console.Write(finalPieces[i]);
            }
            else
            {
                Console.Write(finalPieces[i] + " ");
            }
        }
    }
}
