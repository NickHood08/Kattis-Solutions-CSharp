using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumProblems = Console.ReadLine();
        string strNumTeams = Console.ReadLine();
        string allProblems = Console.ReadLine();
        
        int numProblems = Int32.Parse(strNumProblems);
        int numTeams = Int32.Parse(strNumTeams);
        int maxPointProblem = 0;
        
        string[] problems = allProblems.Split(" ");
        int[] scores = new int[numProblems];
        
        for(int i = 0; i < scores.Length; i++)
        {
            scores[i] = 0;
        }
        
        for(int i = 0; i < numTeams; i++)
        {
            string points = Console.ReadLine();
            int[] arrPoints = Array.ConvertAll(points.Split(" "), int.Parse);
            
            for(int j = 0; j < scores.Length; j++)
            {
                scores[j] += arrPoints[j];
            }
        }
        
        int temp = -1;
        for(int i = 0; i < scores.Length; i++)
        {
            if(scores[i] > temp)
            {
                temp = scores[i];
                maxPointProblem = i;
            }
        }
        
        Console.WriteLine(problems[maxPointProblem]);
    }
}
