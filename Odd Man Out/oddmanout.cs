using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string strCases = Console.ReadLine();
        int numCases = Int32.Parse(strCases);
        for(int i = 1; i <= numCases; i++)
        {
            string strNums = Console.ReadLine();
            int nums = Int32.Parse(strNums);
            string strAllNums = Console.ReadLine();
            int[] allNums = Array.ConvertAll(strAllNums.Split(" "), int.Parse);
            int oddMan = 0;
            bool oddManBool = true;
            List<int> notOddMan = new List<int>();
            for(int j = 0; j < allNums.Length; j++)
            {
                if(!notOddMan.Contains(allNums[j]))
                {
                    for(int k = j + 1; k < allNums.Length; k++)
                    {
                        if(allNums[j] == allNums[k])
                        {
                            oddManBool = false;
                        }
                    }
                    if(oddManBool)
                    {
                        oddMan = allNums[j];
                        break;
                    }
                    else
                    {
                        notOddMan.Add(allNums[j]);
                        oddManBool = true;
                    }   
                }
            }
            Console.WriteLine("Case #" + i + ": " + oddMan);
        }
    }
}
