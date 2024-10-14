using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int eyeDesigns = Int32.Parse(info.Split(" ")[0]);
        int noseDesigns = Int32.Parse(info.Split(" ")[1]);
        int mouthDesigns = Int32.Parse(info.Split(" ")[2]);
        Console.WriteLine(eyeDesigns * noseDesigns * mouthDesigns);
    }
}
