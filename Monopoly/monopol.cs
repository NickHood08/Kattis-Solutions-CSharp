using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] probs = [1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1];
        int numHotels = Int32.Parse(Console.ReadLine());
        string strHotelLocations = Console.ReadLine();
        int[] hotelLocations = Array.ConvertAll(strHotelLocations.Split(" "), int.Parse);
        double chance = 0.0;
        for(int i = 0; i < hotelLocations.Length; i++)
        {
            int num = hotelLocations[i];
            chance += (double) probs[num - 2];
        }
        Console.WriteLine(chance / 36);
    }
}
