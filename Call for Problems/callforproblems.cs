using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int numProblems = Int32.Parse(strNum);
        int total = 0;
        for(int i = 0; i < numProblems; i++)
        {
            string strRating = Console.ReadLine();
            int rating = Int32.Parse(strRating);
            if(rating % 2 != 0)
            {
                total++;
            }
        }
        Console.WriteLine(total);
    }
}
