using System;

public class Program
{
    public static void Main(string[] args)
    {
        string code = Console.ReadLine();
        int tracker = 1;
        int days = 0;
        for(int i = 0; i < code.Length; i++)
        {
            //2nd letter of Per sequence (tracking e's)
            if(tracker % 2 == 0)
            {
                //code here
                if(code[i].ToString() != "E")
                {
                    days += 1;
                }
                tracker += 1;
            }
            //2nd letter of Per sequence (trackeing r's)
            else if(tracker % 3 == 0)
            {
                //code here
                if(code[i].ToString() != "R")
                {
                    days += 1;
                }
                tracker = 1;
            }
            //1st letter of Per sequence (tracking p's)
            else
            {
                if(code[i].ToString() != "P")
                {
                    days += 1;
                }
                tracker += 1;
            }
        }
        Console.WriteLine(days);
    }
}
