using System;

public class Program
{
    public static void Main(string[] args)
    {
        string cardsPlayed = Console.ReadLine();
        int[] cardsType = {0,0,0}; //T,C,G
        for(int i = 0; i < cardsPlayed.Length; i++)
        {
            if(cardsPlayed[i] == 'T')
            {
                cardsType[0] += 1;
            }
            else if(cardsPlayed[i] == 'C')
            {
                cardsType[1] += 1;
            }
            else if(cardsPlayed[i] == 'G')
            {
                cardsType[2] += 1;
            }
        }
        int minSets = Math.Min(cardsType[0], Math.Min(cardsType[1], cardsType[2]));
        Console.WriteLine((cardsType[0] * cardsType[0]) + (cardsType[1] * cardsType[1]) + (cardsType[2] * cardsType[2]) +(7 * minSets));
    }
}
