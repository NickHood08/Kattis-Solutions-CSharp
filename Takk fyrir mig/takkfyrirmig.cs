using System;

public class ThankYou
{
    public static void Main(string[] args)
    {
        int numOfGuests = Int32.Parse(Console.ReadLine());
        
        for(int i = 0; i < numOfGuests; i++)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Takk " + name);
        }
    }
}
