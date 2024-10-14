using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumKnotsToLearn = Console.ReadLine();
        int numKnotsToLearn = Int32.Parse(strNumKnotsToLearn);
        string strKnotsToLearn = Console.ReadLine();
        int[] knotsToLearn = Array.ConvertAll(strKnotsToLearn.Split(" "), int.Parse);
        string strKnotsLearned = Console.ReadLine();
        int[] knotsLearned = Array.ConvertAll(strKnotsLearned.Split(" "), int.Parse);
        List<int> knots = new List<int>();
        for(int i = 0; i < knotsToLearn.Length; i++)
        {
            knots.Add(knotsToLearn[i]);
        }
        for(int i = 0; i < knotsLearned.Length; i++)
        {
            if(knots.Contains(knotsLearned[i]))
            {
                knots.Remove(knotsLearned[i]);
            }
        }
        Console.WriteLine(knots[0]);
    }
}
