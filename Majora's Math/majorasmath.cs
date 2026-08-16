using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string strInfo = Console.ReadLine();
        string strArrowsDamage = Console.ReadLine();
        string arrowType = string.Empty;
        
        int[] info = Array.ConvertAll(strInfo.Split(" "), int.Parse); //[0] Health, [1] num arrows landed
        int[] arrowsDamage = Array.ConvertAll(strArrowsDamage.Split(" "), int.Parse); //[0] standard, [1] fire, [2] ice, [3] light
        
        Dictionary<string, int> arrowInfo = new Dictionary<string, int>(); //key:value , arrowType:damage
        
        arrowInfo.Add("standard", arrowsDamage[0]);
        arrowInfo.Add("fire", arrowsDamage[1]);
        arrowInfo.Add("ice", arrowsDamage[2]);
        arrowInfo.Add("light", arrowsDamage[3]);
        
        for(int i = 0; i < info[1]; i++)
        {
            arrowType = Console.ReadLine();
            info[0] -= arrowInfo[arrowType];
        }
        
        if(info[0] <= 0)
        {
            Console.WriteLine("dead");
        }
        else
        {
            Console.WriteLine(info[0]);
        }
    }
}
