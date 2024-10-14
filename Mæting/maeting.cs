using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string listLengths = Console.ReadLine();
        string strList1 = Console.ReadLine();
        string strList2 = Console.ReadLine();
        string students = "";
        List<int> list1 = new List<int>(Array.ConvertAll(strList1.Split(" "), int.Parse));
        List<int> list2 = new List<int>(Array.ConvertAll(strList2.Split(" "), int.Parse));
        foreach(int num in list1)
        {
            if(list2.Contains(num))
            {
                students += num + " ";
            }
        }
        Console.WriteLine(students.Trim());
    }
}
