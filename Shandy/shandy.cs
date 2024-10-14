using System;

public class Program
{
    public static void Main(string[] args)
    {
        int beer = Int32.Parse(Console.ReadLine());
        int lemonLime = Int32.Parse(Console.ReadLine());
        if(beer < lemonLime)
        {
            Console.WriteLine(beer * 2);
        }
        else
        {
            Console.WriteLine(lemonLime * 2);
        }
    }
}
