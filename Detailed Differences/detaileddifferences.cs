using System;

public class Program
{
    public static void Main(string[] srgd)
    {
        int numTestCases = Int32.Parse(Console.ReadLine());
        string[] allCases = new string[(numTestCases * 2)];
        string input1 = "";
        string input2 = "";
        string similarities = "";
        for(int i = 0; i < numTestCases; i++)
        {
            input1 = Console.ReadLine();
            Console.WriteLine(input1);
            input2 = Console.ReadLine();
            Console.WriteLine(input2);
            for(int j = 0; j < input1.Length; j++)
            {
                if(input1[j] == input2[j])
                {
                    similarities += ".";
                }
                else
                {
                    similarities += "*";
                }
            }
            Console.WriteLine(similarities);
            Console.WriteLine();
            input1 = "";
            input2 = "";
            similarities = "";
        }
    }
}
