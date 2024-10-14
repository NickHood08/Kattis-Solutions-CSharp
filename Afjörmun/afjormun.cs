using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumSentences = Console.ReadLine();
        int numSentences = Int32.Parse(strNumSentences);
        string newSentence = "";
        for(int i = 0; i < numSentences; i++)
        {
            string sentence = Console.ReadLine();
            for(int j = 0; j < sentence.Length; j++)
            {
                if(j == 0)
                {
                    if(Char.IsUpper(sentence[j]))
                    {
                        newSentence += sentence[j];
                    }
                    else
                    {
                        newSentence += Char.ToUpper(sentence[j]);
                    }
                }
                else
                {
                    newSentence += Char.ToLower(sentence[j]);
                }
            }
            Console.WriteLine(newSentence);
            newSentence = string.Empty;
        }
    }
}
