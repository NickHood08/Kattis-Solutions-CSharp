using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strVolume = string.Empty;
        string strHeight = string.Empty;
        
        int volume = 0;
        int height = 0;
        int E = 0;
        
        for(int i = 0; i < 3; i++)
        {
            strVolume = Console.ReadLine();
            strHeight = Console.ReadLine();
            
            volume = int.Parse(strVolume);
            height = int.Parse(strHeight);
            
            E = volume * height * 10;
            
            Console.WriteLine(E);
        }
    }
}
