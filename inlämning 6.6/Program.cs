using System;

class Program
{
    static void Main(string[] args)
    {
        SkrivUtVartannatOrd("Detta är ett exempel. Texten ändras när den skrivs ut.");
    }

    static void SkrivUtVartannatOrd(string input)
    {
        string[] ord = input.Split(' ');

        for (int i = 0; i < ord.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(ord[i].ToLower() + " ");
            }
          
            else
            {
                Console.Write(ord[i].ToUpper() + " ");
            }
        }

        Console.WriteLine(); 
    }
}
