using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNums = Console.ReadLine();
        int numNames = Int32.Parse(strNums.Split(" ")[0]);
        int numInitials = Int32.Parse(strNums.Split(" ")[1]);
        string[] allNames = new string[numNames];
        string[] namesInitials = new string[numNames];
        int counter = 0;
        int pos = 0;
        
        for(int i = 0; i < numNames; i++)
        {
            string name = Console.ReadLine();
            allNames[i] = name;
            string nameInitital = name.Split(" ")[0].Substring(0,1) + name.Split(" ")[1].Substring(0,1);
            namesInitials[i] = nameInitital;
        }
        
        for(int i = 0; i < numInitials; i++)
        {
            string initial = Console.ReadLine();
            for(int j = 0; j < numNames; j++)
            {
                if(initial == namesInitials[j])
                {
                    counter += 1;
                    pos = j;
                }
            }
            if(counter == 0)
            {
                Console.WriteLine("nobody");
            }
            else if(counter == 1)
            {
                Console.WriteLine(allNames[pos]);
            }
            else
            {
                Console.WriteLine("ambiguous");
            }
            counter = 0;
            pos = 0;
        }
    }
}
