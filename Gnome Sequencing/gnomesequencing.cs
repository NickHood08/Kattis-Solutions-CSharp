using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumGroups = Console.ReadLine();
        string strGnomes = string.Empty;
        
        int numGroups = int.Parse(strNumGroups);
        int[] gnomes = new int[3];
        
        Console.WriteLine("Gnomes:");
        
        for(int i = 0; i < numGroups; i++)
        {
            strGnomes = Console.ReadLine();
            gnomes = Array.ConvertAll(strGnomes.Split(" "), int.Parse);
            
            if(gnomes[0] > gnomes[1] && gnomes[1] > gnomes[2])
            {
                Console.WriteLine("Ordered");
            }
            else if(gnomes[0] < gnomes[1] && gnomes[1] < gnomes[2])
            {
                Console.WriteLine("Ordered");
            }
            else
            {
                Console.WriteLine("Unordered");
            }
        }
    }
}
