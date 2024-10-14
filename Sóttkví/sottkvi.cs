using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int numFriends = Int32.Parse(info.Split(" ")[0]);
        int daysUntilBDay = Int32.Parse(info.Split(" ")[1]);
        int day = Int32.Parse(info.Split(" ")[2]);
        int numPeopleComing = 0;
        for(int i = 0; i < numFriends; i++)
        {
            string input = Console.ReadLine();
            int daysInQ = Int32.Parse(input);
            if(daysInQ + 14 <= daysUntilBDay + day)
            {
                numPeopleComing += 1;
            }
        }
        Console.WriteLine(numPeopleComing);
    }
}
