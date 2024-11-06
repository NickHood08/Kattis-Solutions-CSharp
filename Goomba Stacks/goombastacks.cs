using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strRooms = Console.ReadLine();
        int rooms = Int32.Parse(strRooms);
        int numGoombas = 0;
        bool escape = true;
        
        for(int i = 0; i < rooms; i++)
        {
            string info = Console.ReadLine();
            int roomGoombas = Int32.Parse(info.Split(" ")[0]);
            int goombasNeeded = Int32.Parse(info.Split(" ")[1]);
            
            numGoombas += roomGoombas;
            
            if(numGoombas < goombasNeeded)
            {
                escape = false;
            }
        }
        
        if(escape)
        {
            Console.WriteLine("possible");
        }
        else
        {
            Console.WriteLine("impossible");
        }
    }
}
