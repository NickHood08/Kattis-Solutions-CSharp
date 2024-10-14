using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int teamAScore = 0;
        int teamBScore = 0;
        for(int i = 0; i < input.Length - 1; i+=2)
        {
            if(input[i] == 'A')
            {
                teamAScore += Int32.Parse(input[i + 1].ToString());
            }
            else
            {
                teamBScore += Int32.Parse(input[i + 1].ToString());
            }
        }
        if(teamAScore > teamBScore)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine("B");
        }
    }
}
