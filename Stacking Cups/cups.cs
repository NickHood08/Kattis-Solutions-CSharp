using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        string[] colors = new string[num];
        int[] radius = new int[num];
        string[] sortedColors = new string[num];
        int[] sortedRadius = new int[num];
        
        for(int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            int n = 0;
            string input1 = input.Split(" ")[0];
            string input2 = input.Split(" ")[1];
            bool res = int.TryParse(input1, out n);
            if(res)
            {
                radius[i] = n / 2;
                colors[i] = input2;
            }
            else
            {
                radius[i] = Int32.Parse(input2);
                colors[i] = input1;
            }
        }
        
        for (int i = 0; i < num; i++)
        {
            sortedRadius[i] = radius[i];
        }
        
        Array.Sort(sortedRadius);
        
        for(int i = 0; i < sortedRadius.Length; i++)
        {
            for(int j = 0; j < radius.Length; j++)
            {
                if(sortedRadius[i] == radius[j])
                {
                    sortedColors[i] = colors[j];
                }
            }
        }
        
        for(int i = 0; i < sortedColors.Length; i++)
        {
            Console.WriteLine(sortedColors[i]);
        }
    }
}
