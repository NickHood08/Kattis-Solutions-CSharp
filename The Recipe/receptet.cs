using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumIngredients = Console.ReadLine();
        string strIngredientInfo = string.Empty;
        
        int numIngredients = int.Parse(strNumIngredients);
        //[0] amount you have, [1] amount you need, [2] cost
        int[] ingredientInfo = new int[3];
        int diff = 0;
        int totalCost = 0;
        
        for(int i = 0; i < numIngredients; i++)
        {
            strIngredientInfo = Console.ReadLine();
            ingredientInfo = Array.ConvertAll(strIngredientInfo.Split(" "), int.Parse);
            if(ingredientInfo[0] < ingredientInfo[1])
            {
                diff = ingredientInfo[1] - ingredientInfo[0];
                totalCost += diff * ingredientInfo[2];
            }
            diff = 0;
        }
        
        Console.WriteLine(totalCost);
    }
}
