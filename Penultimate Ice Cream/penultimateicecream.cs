using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        string strPrices = Console.ReadLine();
      
        int[] arrPrices = Array.ConvertAll(strPrices.Split(" "), int.Parse);
        Array.Sort(arrPrices);
      
        int arrLength = arrPrices.Length;
        int penultimatePrice = arrPrices[arrLength - 2];
      
        Console.WriteLine(penultimatePrice);
    }   
}
