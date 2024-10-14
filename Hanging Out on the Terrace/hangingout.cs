using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNums = Console.ReadLine();
        int peopleLimit = Int32.Parse(strNums.Split(" ")[0]);
        int x = Int32.Parse(strNums.Split(" ")[1]);
        int numPeopleOnTerrace = 0;
        int notAllowedPeople = 0;
        
        for(int i = 0; i < x; i++)
        {
            string info = Console.ReadLine();
            string eventCommand = info.Split(" ")[0];
            int eventPeople = Int32.Parse(info.Split(" ")[1]);
            if(eventCommand == "enter")
            {
                if(numPeopleOnTerrace + eventPeople <= peopleLimit)
                {
                    numPeopleOnTerrace += eventPeople;
                }
                else
                {
                    notAllowedPeople += 1;
                }
            }
            else
            {
                numPeopleOnTerrace -= eventPeople;
            }
        }
        Console.WriteLine(notAllowedPeople);
    }
}
