using System;

public class Program
{
    public static void Main(string[] args)
    {
        char[,] board = new char[3,3];
        
        for(int i = 0; i < 3; i++)
        {
            string rowInfo = Console.ReadLine();
            for(int j = 0; j < 3; j++)
            {
                board[i,j] = rowInfo[j];
            }
        }
        
        if(board[0,0] == 'O' && board[0,1] == 'O' && board[0,2] == 'O')
        {
            Console.WriteLine("Jebb");
        }
        else if(board[1,0] == 'O' && board[1,1] == 'O' && board[1,2] == 'O')
        {
            Console.WriteLine("Jebb");
        }
        else if(board[2,0] == 'O' && board[2,1] == 'O' && board[2,2] == 'O')
        {
            Console.WriteLine("Jebb");
        }
        else if(board[0,0] == 'O' && board[1,0] == 'O' && board[2,0] == 'O')
        {
            Console.WriteLine("Jebb");
        }
        else if(board[0,1] == 'O' && board[1,1] == 'O' && board[2,1] == 'O')
        {
            Console.WriteLine("Jebb");
        }
        else if(board[0,2] == 'O' && board[1,2] == 'O' && board[2,2] == 'O')
        {
            Console.WriteLine("Jebb");
        }
        else if(board[0,0] == 'O' && board[1,1] == 'O' && board[2,2] == 'O')
        {
            Console.WriteLine("Jebb");
        }
        else if(board[0,2] == 'O' && board[1,1] == 'O' && board[2,0] == 'O')
        {
            Console.WriteLine("Jebb");
        }
        else
        {
            Console.WriteLine("Neibb");
        }
    }
}
