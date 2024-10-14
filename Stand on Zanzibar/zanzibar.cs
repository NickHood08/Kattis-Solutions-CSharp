using System;

public class Program
{
    public static void Main(string[] args)
    {
        string numCases = Console.ReadLine();
        int numTestCases = Int32.Parse(numCases);
        int lowerBound = 0;
        for(int i = 0; i < numTestCases; i++)
        {
            string caseInfo = Console.ReadLine();
            int[] caseInfoArray = Array.ConvertAll(caseInfo.Split(" "), int.Parse);
            for(int j = 0; j < caseInfoArray.Length - 2; j++)
            {
                if(caseInfoArray[j] * 2 < caseInfoArray[j+1])
                {
                    lowerBound += caseInfoArray[j+1] - (caseInfoArray[j] * 2);
                }
            }
            Console.WriteLine(lowerBound);
            lowerBound = 0;
        }
    }
}
