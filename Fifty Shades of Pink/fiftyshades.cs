using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int sessionsAttend = 0;
        for(int i = 0; i < num; i++)
        {
            string session = Console.ReadLine();
            if(session.ToLower().Contains("pink") || session.ToLower().Contains("rose"))
            {
                sessionsAttend += 1;
            }
        }
        if(sessionsAttend > 0)
        {
            Console.WriteLine(sessionsAttend);
        }
        else
        {
            Console.WriteLine("I must watch Star Wars with my daughter");
        }
    }
}
