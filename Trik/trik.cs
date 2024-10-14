using System;

public class Program
{
    public static void Main(string[] args)
    {
        string moves = Console.ReadLine();
        int ballPos = 1;
        for(int i = 0; i < moves.Length; i++)
        {
            switch(moves[i])
            {
                case 'A':
                    if(ballPos == 1)
                    {
                        ballPos = 2;
                    }
                    else if(ballPos == 2)
                    {
                        ballPos = 1;
                    }
                    break;
                case 'B':
                    if(ballPos == 2)
                    {
                        ballPos = 3;
                    }
                    else if(ballPos == 3)
                    {
                        ballPos = 2;
                    }
                    break;
                case 'C':
                    if(ballPos == 3)
                    {
                        ballPos = 1;
                    }
                    else if(ballPos == 1)
                    {
                        ballPos = 3;
                    }
                    break;
            }
        }
        Console.WriteLine(ballPos);
    }
}
