using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numOfGuests = Int32.Parse(Console.ReadLine());
        int numOfFun = 0;
        string mostFunPerson = "";
        for(int i = 0; i < numOfGuests; i++)
        {
            string info = Console.ReadLine();
            string tempName = info.Split(" ")[0];
            int funLevel = Int32.Parse(info.Split(" ")[1]);
            
            if(funLevel > numOfFun)
            {
                mostFunPerson = tempName;
                numOfFun = funLevel;
            }
        }
        Console.WriteLine(mostFunPerson);
    }
}
