using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numTemps = Int32.Parse(Console.ReadLine());
        string allTemps = Console.ReadLine();
        int[] allTempsArray = Array.ConvertAll(allTemps.Split(" "), int.Parse);
        int tempsUnder0 = 0;
        for(int i = 0; i < allTempsArray.Length; i++)
        {
            if(allTempsArray[i] < 0)
            {
                tempsUnder0 += 1;
            }
        }
        Console.WriteLine(tempsUnder0);
    }
}
