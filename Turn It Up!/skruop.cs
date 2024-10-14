using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int volume = 7;
        for(int i = 0; i < num; i++)
        {
            string request = Console.ReadLine();
            if(request == "Skru op!")
            {
                if(volume < 10)
                {
                    volume += 1;
                }
            }
            else
            {
                if(volume > 0)
                {
                    volume -= 1;
                }
            }
        }
        Console.WriteLine(volume);
    }
}
