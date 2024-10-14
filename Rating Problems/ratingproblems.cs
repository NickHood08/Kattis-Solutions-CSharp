using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        float numJudges = Int32.Parse(info.Split(" ")[0]);
        float numJudgesVoted = Int32.Parse(info.Split(" ")[1]);
        float minRating = 0.0F;
        float maxRating = 0.0F;
        
        for(int i = 0; i < numJudgesVoted; i++)
        {
            string strRating = Console.ReadLine();
            minRating += float.Parse(strRating) / numJudges;
            maxRating += float.Parse(strRating) / numJudges;
        }
        
        for(int i = 0; i < (numJudges - numJudgesVoted); i++)
        {
            minRating += -3 / numJudges;
            maxRating += 3 / numJudges;
        }
        
        Console.WriteLine(minRating + " " + maxRating);
    }
}
