using System;

public class Program
{
    public static void Main(string[] args)
    {
        string annList = Console.ReadLine();
        string benList = Console.ReadLine();
        string combinedList = annList + benList;
        string[] arr = new string[combinedList.Length];
        for(int i = 0; i < combinedList.Length; i ++)
        {
            arr[i] = combinedList[i].ToString();
        }
        Array.Sort(arr);
        for(int i = 0; i < arr.Length; i ++)
        {
            Console.Write(arr[i]);
        }
    }
}
