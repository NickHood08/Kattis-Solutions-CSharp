using System;

public class Program
{
    public static void Main(string[] args)
    {
        string nums = Console.ReadLine();
        int rows = Int32.Parse(nums.Split(" ")[0]);
        int rowLength = Int32.Parse(nums.Split(" ")[1]);
        int yarnNeeded = 0;
        string rowInfo = string.Empty;
        for(int i = 0; i < rows; i++)
        {
            rowInfo = Console.ReadLine();
            for(int j = 0; j < rowLength; j++)
            {
                switch(rowInfo[j].ToString())
                {
                    case ".":
                        yarnNeeded += 20;
                        break;
                    case "O":
                        yarnNeeded += 10;
                        break;
                    case "/":
                        yarnNeeded += 25;
                        break;
                    case "A":
                        yarnNeeded += 35;
                        break;
                    case "^":
                        yarnNeeded += 5;
                        break;
                    case "v":
                        yarnNeeded += 22;
                        break;
                    default:
                        yarnNeeded += 25;
                        break;
                }
            }
            rowInfo = string.Empty;
        }
        Console.WriteLine(yarnNeeded);
    }
}
