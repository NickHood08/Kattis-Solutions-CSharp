using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int branch = Int32.Parse(strNum);
        int branchAliceWon = 0;
        
        if(branch % 2 == 0)
        {
            branchAliceWon = branch / 2;
            Console.WriteLine("Alice");
            Console.WriteLine(branchAliceWon);
        }
        else
        {
            Console.WriteLine("Bob");
        }
    }
}
