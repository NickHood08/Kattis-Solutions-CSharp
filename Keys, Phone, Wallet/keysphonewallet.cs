using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numStuff = Int32.Parse(Console.ReadLine());
        bool phone = false;
        bool keys = false;
        bool wallet = false;
        
        for(int i = 0; i < numStuff; i++)
        {
            string item = Console.ReadLine();
            if(item == "phone")
            {
                phone = true;
            }
            else if(item == "wallet")
            {
                wallet = true;
            }
            else if(item == "keys")
            {
                keys = true;
            }
        }
        if(keys == false)
        {
            Console.WriteLine("keys");
        }
        if (phone == false)
        {
            Console.WriteLine("phone");
        }
        if(wallet == false)
        {
            Console.WriteLine("wallet");
        }
        if(keys == true && phone == true && wallet == true)
        {
            Console.WriteLine("ready");
        }
    }
}
