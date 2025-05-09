using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string seq1 = Console.ReadLine();
        string seq2 = Console.ReadLine();
        int[] numsSeq1 = Array.ConvertAll(seq1.Split(" "), int.Parse);
        int[] numsSeq2 = Array.ConvertAll(seq2.Split(" "), int.Parse);
        int totalSeq1 = 0;
        int totalSeq2 = 0;
        
        for(int i = 0; i < numsSeq1.Length; i++)
        {
            totalSeq1 += numsSeq1[i];
        }
        
        for(int i = 0; i < numsSeq2.Length; i++)
        {
            totalSeq2 += numsSeq2[i];
        }
        
        if(totalSeq1 > totalSeq2)
        {
            Console.WriteLine("Button 1");
        }
        else if(totalSeq1 < totalSeq2)
        {
            Console.WriteLine("Button 2");
        }
        else
        {
            Console.WriteLine("Oh no");
        }
        
    }
}
