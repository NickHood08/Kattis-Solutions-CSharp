using System;

public class Program
{
    public static void Main(string[] args)
    {
        string encodeString = Console.ReadLine();
        string strIDNums = Console.ReadLine();
        string id = string.Empty;
        string result = string.Empty;
        int tracker = 0;
        
        for(int i = 0; i <= strIDNums.Length; i++)
        {
            if(tracker == 3 && i != strIDNums.Length)
            {
                int temp = Int32.Parse(id);
                result += encodeString[temp - 1].ToString();
                id = string.Empty;
                id += strIDNums[i];
                tracker = 1;
            }
            else if(i == strIDNums.Length)
            {
                int temp = Int32.Parse(id);
                result += encodeString[temp - 1].ToString();
            }
            else
            {
                id += strIDNums[i];
                tracker++; 
            }
        }
        Console.WriteLine(result);
    }
}
