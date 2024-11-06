using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int begin = Int32.Parse(input.Split('/')[0]);
        int middle = Int32.Parse(input.Split('/')[1]);
        
        if(begin > 12)
        {
            Console.WriteLine("EU");
        }
        else if(middle > 12)
        {
            Console.WriteLine("US");
        }
        else
        {
            Console.WriteLine("either");
        }
    }
}
