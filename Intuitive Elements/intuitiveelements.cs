using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        string element = string.Empty;
        string abbrev = string.Empty;
        bool flag = true;
        
        for(int i = 0; i < num; i++)
        {
            element = Console.ReadLine();
            abbrev = Console.ReadLine();
            
            for(int j = 0; j < abbrev.Length; j++)
            {
                if(!element.Contains(abbrev[j]))
                {
                    flag = false;
                    break;
                }
            }
            
            if(flag)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
                flag = true;
            }
        }
    }
}
