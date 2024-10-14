using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strRooms = Console.ReadLine();
        string strTeams = Console.ReadLine();
        int numRooms = Int32.Parse(strRooms);
        int numTeams = Int32.Parse(strTeams);
        string strRoom = "";
        while(numRooms > 0)
        {
            int peopleInRoom = numTeams / numRooms;
            for(int i = 0; i < peopleInRoom; i++)
            {
                strRoom += "*";
            }
            Console.WriteLine(strRoom);
            strRoom = string.Empty;
            numTeams -= peopleInRoom;
            numRooms -= 1;
        }
    }
}
