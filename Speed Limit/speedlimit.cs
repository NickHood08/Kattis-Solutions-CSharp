using System;

public class Program
{
    public static void Main(string[] args)
    {
        while(0 != 1)
        {
            string strNum = Console.ReadLine();
            int num = Int32.Parse(strNum);
            
            if(num == -1)
            {
                break;
            }
            else
            {
                int totalMiles = 0;
                int[] miles = new int[num];
                int[] hrs = new int[num];
                
                for(int i = 0; i < num; i++)
                {
                    string strNums = Console.ReadLine();
                    miles[i] = Int32.Parse(strNums.Split(" ")[0]);
                    hrs[i] = Int32.Parse(strNums.Split(" ")[1]);
                }
                
                for(int i = 0; i < num; i++)
                {
                    if(i == 0)
                    {
                        totalMiles += miles[i] * hrs[i];
                    }
                    else
                    {
                        totalMiles += miles[i] * (hrs[i] - hrs[i - 1]);
                    }
                }
                Console.WriteLine(totalMiles + " miles");
            }
        }
    }
}
