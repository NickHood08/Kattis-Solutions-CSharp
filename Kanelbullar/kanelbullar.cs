using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string input = string.Empty;
        
        int num = 0;
        int totalCinnamonBuns = 0;
        
        int[] ingredientsNeeded = new int[5]; //[0] flour, [1] yeast, [2] butter, [3] milk, [4] sugar
        int[] ingredientsHave = new int[5]; //[0] flour, [1] yeast, [2] butter, [3] milk, [4] sugar
        int[] cinnamonBunsCanMake = new int[5];
        
        bool canMakeCinnamonBuns = true;
        
        for(int i = 0; i < 5; i++)
        {
            input = Console.ReadLine();
            num = int.Parse(input);
            ingredientsNeeded[i] = num;
        }
        
        for(int i = 0; i < 5; i++)
        {
            input = Console.ReadLine();
            num = int.Parse(input);
            ingredientsHave[i] = num;
        }
        
        for(int i = 0; i < 5; i++)
        {
            if(ingredientsHave[i] > ingredientsNeeded[i])
            {
                cinnamonBunsCanMake[i] = ingredientsHave[i] / ingredientsNeeded[i];
            }
            else
            {
                canMakeCinnamonBuns = false;
                break;
            }
        }
        
        if(canMakeCinnamonBuns)
        {
            totalCinnamonBuns = cinnamonBunsCanMake.Min();
            Console.WriteLine(totalCinnamonBuns);
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
