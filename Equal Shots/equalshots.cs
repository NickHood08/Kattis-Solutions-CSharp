using System;

public class Program
{
     public static void Main(string[] args)
     {
         string input = Console.ReadLine();
         int a = Int32.Parse(input.Split(" ")[0]);
         int b = Int32.Parse(input.Split(" ")[1]);
         int shot1 = 0;
         int shot2 = 0;
         
         for(int i = 0; i < a; i++)
         {
            string strIngredientInfo = Console.ReadLine();
            int amount = Int32.Parse(strIngredientInfo.Split(" ")[0]);
            int alc = Int32.Parse(strIngredientInfo.Split(" ")[1]);
            shot1 += amount * alc;
         }
         
         for(int i = 0; i < b; i++)
         {
            string strIngredientInfo = Console.ReadLine();
            int amount = Int32.Parse(strIngredientInfo.Split(" ")[0]);
            int alc = Int32.Parse(strIngredientInfo.Split(" ")[1]);
            shot2 += amount * alc;
         }
         
         if(shot1 == shot2)
         {
            Console.WriteLine("same");
         }
         else
         {
            Console.WriteLine("different");
         }
     }
}
