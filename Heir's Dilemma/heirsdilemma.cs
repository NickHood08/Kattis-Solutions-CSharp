using System;

public class Program
{
    public static bool isCombination(int num)
    {
        int digit = 0;
        int tempNum = num;
        string strNum = string.Empty;
        bool isCombo = true;
        while(tempNum > 0)
        {
            digit = tempNum % 10;
            tempNum /= 10;
            strNum = tempNum.ToString();
            if(digit == 0 || num % digit != 0 || strNum.Contains(digit.ToString()))
            {
                isCombo = false;
                break;
            }
        }
        return isCombo;
    }
    
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int num1 = Int32.Parse(input.Split(" ")[0]);
        int num2 = Int32.Parse(input.Split(" ")[1]);
        int numsInbetween = num2 - num1;
        int numCombinations = 0;
        while(num1 <= num2)
        {
            if(isCombination(num1))
            {
                numCombinations += 1;
            }
            num1 += 1;
        }
        Console.WriteLine(numCombinations);
    }
}
