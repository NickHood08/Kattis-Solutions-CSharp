using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        string strCountInput = Console.ReadLine();
        string strBabysCount = string.Empty;
        string[] strCountArray = strCountInput.Split(" ");
        
        int num = int.Parse(strNum);
        int count = 1;
        int babysCount = 0;
        
        bool flag = true;
        
        for(int i = 0; i < num; i++)
        {
            
            if(strCountArray[i] != "mumble")
            {
                strBabysCount = strCountArray[i];
                babysCount = int.Parse(strBabysCount);
                if(babysCount != count)
                {
                    flag = false;
                    break;
                }
            }
            
            count++;
        }
        
        if(flag)
        {
            Console.WriteLine("makes sense");
        }
        else
        {
            Console.WriteLine("something is fishy");
        }
    }
}
