using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int numPeople = Int32.Parse(input.Split(" ")[0]);
        int numChicken = Int32.Parse(input.Split(" ")[1]);
        int difference = 0;
        
        if(numPeople > numChicken)
        {
            difference = numPeople - numChicken;
            if(difference != 1)
            {
                Console.WriteLine("Dr. Chaz needs " + difference + " more pieces of chicken!");
            }
            else
            {
                Console.WriteLine("Dr. Chaz needs " + difference + " more piece of chicken!");
            }
        }
        else
        {
            difference = numChicken - numPeople;
            if(difference != 1)
            {
                Console.WriteLine("Dr. Chaz will have " + difference + " pieces of chicken left over!");
            }
            else
            {
                Console.WriteLine("Dr. Chaz will have " + difference + " piece of chicken left over!");
            }
        }
    }
}
