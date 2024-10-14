using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNums = Console.ReadLine();
        int[] nums = Array.ConvertAll(strNums.Split(" "), int.Parse);
        string[,] names = new string[nums[1],nums[2]];
        string[] namesOrder = new string[nums[0]];
        
        for(int i = 0; i < nums[1]; i++)
        {
            string strNames = Console.ReadLine();
            string[] namesArray = strNames.Split(" ");
            for(int j = 0; j < namesArray.Length; j++)
            {
                names[i,j] = namesArray[j];
            }
        }
        
        for(int i = 0; i < nums[0]; i++)
        {
            string n = Console.ReadLine();
            namesOrder[i] = n;
        }
        
        for(int i = 0; i < nums[1]; i++)
        {
            if(namesOrder[i * nums[2]] == names[i,0])
            {
                Console.WriteLine("left");
            }
            else
            {
                Console.WriteLine("right");
            }
        }
    }
}
