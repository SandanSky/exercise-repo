using System;

namespace exWordInPlural
{
    class exWordInPlural
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word = word + "ies";
            }
            else if (word.EndsWith("ch") || word.EndsWith("sh") || word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z"))
                {
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }
            Console.WriteLine(word);
        }
    }
}
