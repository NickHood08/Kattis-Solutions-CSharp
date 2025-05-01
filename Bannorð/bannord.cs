using System;

public class Program
{
    public static void Main(string[] args)
    {
        string forbidden = Console.ReadLine();
        string original = Console.ReadLine();
        string memoWord = string.Empty;
        string hiddenWord = string.Empty;
        string[] splitMemo = original.Split(" ");
        int length = splitMemo.Length;
        string[] newMemo = new string[length];
        string strNewMemo = string.Empty;
        bool hide = false;
        
        for(int i = 0; i < splitMemo.Length; i++)
        {
            memoWord = splitMemo[i];
            for(int j = 0; j < memoWord.Length; j++)
            {
                if(!hide)
                {
                    if(forbidden.Contains(memoWord[j]))
                    {
                        hide = true;
                    }
                }
            }
            
            if(hide)
            {
                for(int j = 0; j < memoWord.Length; j++)
                {
                    hiddenWord += "*";
                }
                
                newMemo[i] = hiddenWord;
                hiddenWord = string.Empty;
                hide = false;
            }
            else
            {
                newMemo[i] = splitMemo[i];
            }
        }
        
        for(int i = 0; i < newMemo.Length; i++)
        {
            strNewMemo += newMemo[i] + " ";
        }
        
        strNewMemo.Trim();
        Console.WriteLine(strNewMemo);
    }
}
