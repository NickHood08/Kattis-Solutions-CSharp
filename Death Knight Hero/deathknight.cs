using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int numWins = 0;
        for(int i = 0; i < num; i++)
        {
            string abilities = Console.ReadLine();
            if(!abilities.Contains("CD"))
            {
                numWins += 1;
            }
        }
        Console.WriteLine(numWins);
    }
}
