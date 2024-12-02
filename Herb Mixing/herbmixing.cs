using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strInput = Console.ReadLine();
        int green = Int32.Parse(strInput.Split(" ")[0]);
        int red = Int32.Parse(strInput.Split(" ")[1]);
        int health = 0;
        
        if(green == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            while(green >= 1)
            {
                if(green >= 1 && red >= 1)
                {
                    health += 10;
                    green--;
                    red--;
                }
                else if(green >= 3)
                {
                    health += 10;
                    green -= 3;
                }
                else if(green >= 2)
                {
                    health += 3;
                    green -= 2;
                }
                else if(green >= 1)
                {
                    health += 1;
                    green--;
                }
            }
            Console.WriteLine(health);
        }
    }
}
