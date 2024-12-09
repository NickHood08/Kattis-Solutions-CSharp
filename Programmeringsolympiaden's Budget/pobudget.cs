using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        int revenue = 0;
        int expense = 0;
        
        for(int i = 0; i < num; i++)
        {
            string description = Console.ReadLine();
            string strRevOrExp = Console.ReadLine();
            int revOrExp = Int32.Parse(strRevOrExp);
            
            if(revOrExp > 0)
            {
                revenue += revOrExp;
            }
            else
            {
                expense += revOrExp * -1;
            }
        }
        
        if(revenue > expense)
        {
            Console.WriteLine("Usch, vinst");
        }
        else if(expense > revenue)
        {
            Console.WriteLine("Nekad");
        }
        else
        {
            Console.WriteLine("Lagom");
        }
    }
}
