using System;

public class Program
{
    public static void Main(string[] args)
    {
        string output = string.Empty;
        string strInput = Console.ReadLine();
        string strMoneyRequest = Console.ReadLine();
        string[] arrInputs = strInput.Split(" ");
        
        int numPeople = int.Parse(arrInputs[0]);
        int totalMoney = int.Parse(arrInputs[1]);
        int[] arrMoneyRequest = Array.ConvertAll(strMoneyRequest.Split(" "), int.Parse);
        
        for(int i = 0; i < numPeople; i++)
        {
            if(totalMoney - arrMoneyRequest[i] >= 0)
            {
                output += "1";
                totalMoney -= arrMoneyRequest[i];
            }
            else
            {
                output += "0";
            }
        }
        
        Console.WriteLine(output);
    }
}
