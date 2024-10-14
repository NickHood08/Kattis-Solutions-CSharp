using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNums = Console.ReadLine();
        int n = Int32.Parse(strNums.Split(" ")[0]);
        int q = Int32.Parse(strNums.Split(" ")[1]);
        string strLocations = Console.ReadLine();
        int[] locations = Array.ConvertAll(strLocations.Split(" "), int.Parse);
        for(int i = 0; i < q; i++)
        {
            string input = Console.ReadLine();
            int queryNum = Int32.Parse(input.Split(" ")[0]);
            if(queryNum == 1)
            {
                int companyNum = Int32.Parse(input.Split(" ")[1]);
                int newLocation = Int32.Parse(input.Split(" ")[2]);
                locations[companyNum - 1] = newLocation;
            }
            else
            {
                int company1 = Int32.Parse(input.Split(" ")[1]);
                int company2 = Int32.Parse(input.Split(" ")[2]);
                if(locations[company1 - 1] - locations[company2 - 1] < 0)
                {
                    Console.WriteLine((locations[company1 - 1] - locations[company2 - 1]) * -1);
                }
                else
                {
                    Console.WriteLine(locations[company1 - 1] - locations[company2 - 1]);
                }
            }
        }
    }
}
