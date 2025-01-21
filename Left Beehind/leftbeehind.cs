using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = string.Empty;
        int sweet = 0;
        int sour = 0;
        int total = 0;
        
        input = Console.ReadLine();
        
        while(input != "0 0")
        {
            sweet = Int32.Parse(input.Split(" ")[0]);
            sour = Int32.Parse(input.Split(" ")[1]);
            total = sweet + sour;
            
            if(total == 13)
            {
                Console.WriteLine("Never speak again.");
            }
            else if(sweet > sour)
            {
                Console.WriteLine("To the convention.");
            }
            else if(sour > sweet)
            {
                Console.WriteLine("Left beehind.");
            }
            else if(sweet == sour)
            {
                Console.WriteLine("Undecided.");
            }
            
            input = Console.ReadLine();
        }
    }
}
