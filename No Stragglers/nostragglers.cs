using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumEvents = Console.ReadLine();
        string strEvent = string.Empty;
        string[] eventInfo = new string[3];
        string eventPerson = string.Empty;
        string eventAction = string.Empty;
        
        
        int numEvents = int.Parse(strNumEvents);
        int eventPeople = 0;
        int students = 0;
        int visitors = 0;
        int totalPeople = 0;
        
        for(int i = 0; i < numEvents; i++)
        {
            strEvent = Console.ReadLine();
            eventInfo = strEvent.Split(" ");
            eventPerson = eventInfo[0];
            eventAction = eventInfo[1];
            eventPeople = int.Parse(eventInfo[2]);
            
            if(eventPerson == "STU")
            {
                if(eventAction == "IN")
                {
                    students += eventPeople;
                }
                else
                {
                    students -= eventPeople;
                }
            }
            else
            {
                if(eventAction == "IN")
                {
                    visitors += eventPeople;
                }
                else
                {
                    visitors -= eventPeople;
                }
            }
        }
        
        totalPeople = students + visitors;
        
        if(totalPeople > 0)
        {
            Console.WriteLine(totalPeople);
        }
        else
        {
            Console.WriteLine("NO STRAGGLERS");
        }
    }
}
