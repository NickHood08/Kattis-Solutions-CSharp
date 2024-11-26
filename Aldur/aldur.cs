using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumFriends = Console.ReadLine();
        int numFriends = Int32.Parse(strNumFriends);
        int youngestFriend = 100001;
        string strFriendAge = string.Empty;
        int friendAge = 0;
        
        for(int i = 0; i < numFriends; i++)
        {
            strFriendAge = Console.ReadLine();
            friendAge = Int32.Parse(strFriendAge);
            
            if(friendAge < youngestFriend)
            {
                youngestFriend = friendAge;
            }
        }
        
        Console.WriteLine(youngestFriend);
    }
}
