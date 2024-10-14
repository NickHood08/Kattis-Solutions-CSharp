using System;

public class Program
{
    public static void Main(string[] args)
    {
        int NoCIA = 0;
        string ciaBlimps = "";
        for(int i = 0; i < 5; i++)
        {
            string blimp = Console.ReadLine();
            if(blimp.Contains("FBI") && i !=4)
            {
                ciaBlimps += i + 1 + " ";
            }
            else if(blimp.Contains("FBI") && i == 4)
            {
                ciaBlimps += i + 1;
            }
        }
        if(ciaBlimps == string.Empty)
        {
            Console.WriteLine("HE GOT AWAY!");
        }
        else
        {
            Console.WriteLine(ciaBlimps);
        }
    }
}
