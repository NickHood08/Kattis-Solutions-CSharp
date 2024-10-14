using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string deck = Console.ReadLine();
        int[] cards = { 0, 0, 0, 0 }; //P,K,H,T
        List<string> AllCards = new List<string>();
        bool twoSameCards = false;

        while (deck != "")
        {
            string card = deck.Substring(0, 3);
            AllCards.Add(card);
            string restOfDeck = deck.Substring(3);
            deck = restOfDeck;
        }

        for(int i = 0; i < AllCards.Count; i++)
        {
            for (int j = i + 1; j < AllCards.Count; j++)
            {
                if (AllCards[i] == AllCards[j])
                {
                    twoSameCards = true;
                }
            }
            string suit = AllCards[i].Substring(0, 1);
            if (suit == "P")
            {
                cards[0] += 1;
            }
            else if (suit == "K")
            {
                cards[1] += 1;
            }
            else if (suit == "H")
            {
                cards[2] += 1;
            }
            else
            {
                cards[3] += 1;
            }
        }

        if(twoSameCards)
        {
            Console.WriteLine("GRESKA");
        }
        else
        {
            Console.WriteLine((13 - cards[0]) + " " + (13 - cards[1]) + " " + (13 - cards[2]) + " " + (13 - cards[3]));
        }
    }
}
