using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        
        int[] ingredients = {45, 30, 10, 1};
        
        for(int i = 0; i < 4; i++)
        {
            switch(i)
            {
                case 0:
                    Console.WriteLine((ingredients[i] * num) + " ml gin");
                    break;
                case 1:
                    Console.WriteLine((ingredients[i] * num) + " ml fresh lemon juice");
                    break;
                case 2:
                    Console.WriteLine((ingredients[i] * num) + " ml simple syrup");
                    break;
                case 3:
                    if((ingredients[i] * num) > 1)
                    {
                        Console.WriteLine((ingredients[i] * num) + " slices of lemon");
                    }
                    else
                    {
                        Console.WriteLine((ingredients[i] * num) + " slice of lemon");
                    }
                    break;
            }
        }
    }
}
