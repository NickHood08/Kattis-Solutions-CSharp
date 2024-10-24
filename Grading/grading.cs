using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strScores = Console.ReadLine();
        int a = Int32.Parse(strScores.Split(" ")[0]);
        int b = Int32.Parse(strScores.Split(" ")[1]);
        int c = Int32.Parse(strScores.Split(" ")[2]);
        int d = Int32.Parse(strScores.Split(" ")[3]);
        int e = Int32.Parse(strScores.Split(" ")[4]);
        string strScore = Console.ReadLine();
        int score = Int32.Parse(strScore);
        
        if(score >= a)
        {
            Console.WriteLine("A");
        }
        else if(score < a && score >= b)
        {
            Console.WriteLine("B");
        }
        else if(score < b && score >= c)
        {
            Console.WriteLine("C");
        }
        else if(score < c && score >= d)
        {
            Console.WriteLine("D");
        }
        else if(score < d && score >= e)
        {
            Console.WriteLine("E");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
