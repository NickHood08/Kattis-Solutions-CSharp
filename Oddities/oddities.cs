using System;

public class Program
{
    public static void Main(string[] args)
    {
        string numTestCases = Console.ReadLine();
        int testCasesAmt = Int32.Parse(numTestCases);
        for(int i = 0; i < testCasesAmt; i++)
        {
            string testCase = Console.ReadLine();
            int testCaseNum = Int32.Parse(testCase);
            if(testCaseNum % 2 == 0)
            {
                Console.WriteLine(testCaseNum + " is even");
            }
            else
            {
                Console.WriteLine(testCaseNum + " is odd");
            }
        }
    }
}
