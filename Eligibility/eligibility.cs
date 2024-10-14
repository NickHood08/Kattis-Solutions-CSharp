using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        for(int i = 0; i < num; i++)
        {
            string info = Console.ReadLine();
            string[] studentInfo = info.Split(" ");
            if(Int32.Parse(studentInfo[1].Substring(0, 4)) >= 2010 || Int32.Parse(studentInfo[2].Substring(0, 4)) >= 1991)
            {
                Console.WriteLine(studentInfo[0] + " eligible");
            }
            else if(Int32.Parse(studentInfo[3]) >= 41)
            {
                Console.WriteLine(studentInfo[0] + " ineligible");
            }
            else
            {
                Console.WriteLine(studentInfo[0] + " coach petitions");
            }
        }
    }
}
