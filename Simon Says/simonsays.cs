using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        for(int i = 0; i < num; i++)
        {
            string command = Console.ReadLine();
            if(command.Contains("Simon says"))
            {
                string simonCommand = command.Substring(11);
                Console.WriteLine(simonCommand);
            }
        }
    }
}
