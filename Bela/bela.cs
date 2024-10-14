using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int numHands = Int32.Parse(info.Split(" ")[0]);
        string suit = info.Split(" ")[1];
        int total = 0;
        
        for(int i = 0; i < numHands * 4; i++)
        {
            string card = Console.ReadLine();
            switch(card[0].ToString())
            {
                case "A":
                    total += 11;
                    break;
                case "K":
                    total += 4;
                    break;
                case "Q":
                    total += 3;
                    break;
                case "J":
                    if(card[1].ToString() == suit)
                    {
                        total += 20;
                    }
                    else
                    {
                        total += 2;
                    }
                    break;
                case "T":
                    total += 10;
                    break;
                case "9":
                    if(card[1].ToString() == suit)
                    {
                        total += 14;
                    }
                    break;
            }
        }
        Console.WriteLine(total);
    }
}
