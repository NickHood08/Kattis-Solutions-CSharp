using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        string[] hand = info.Split(" ");
        int rank = 0;
        int tempRank = 0;
        for(int i = 0; i < hand.Length; i++)
        {
            string card = hand[i];
            for(int j = 0; j < hand.Length; j++)
            {
                string compareCard = hand[j];
                if(card[0].ToString() == compareCard[0].ToString())
                {
                    tempRank += 1;
                }
            }
            if(tempRank > rank)
            {
                rank = tempRank;
            }
            tempRank = 0;
        }
        Console.WriteLine(rank);
    }
}
