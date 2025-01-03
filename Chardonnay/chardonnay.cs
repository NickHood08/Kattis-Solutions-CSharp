using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strDL = Console.ReadLine();
        int dl = Int32.Parse(strDL);
        
        if(dl == 0)
        {
            Console.WriteLine("0");
        }
        else if(dl == 7)
        {
            Console.WriteLine("7");
        }
        else
        {
            Console.WriteLine(dl + 1);
        }
    }
