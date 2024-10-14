using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        string[] names = info.Split("-");
        for(int i = 0; i < names.Length; i++)
        {
            Console.Write(names[i].Substring(0,1));
        }
    }
}
