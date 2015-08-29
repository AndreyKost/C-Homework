using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi text");
            string text = Console.ReadLine();
            Console.WriteLine("vuvedi duma");
            string word = Console.ReadLine();

            string[] allSentances = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder output = new StringBuilder();

            foreach (string sentance in allSentances)
            {
                StringBuilder currnetWord = new StringBuilder();

                foreach (var ch in sentance + '.')
                {
                    if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                    {
                        currnetWord.Append(ch);
                    }
                    else
                    {
                        if (currnetWord.ToString().ToLower() == word.ToLower())
                        {
                            output.AppendLine(sentance.Trim() + '.');
                            break;
                        }
                        currnetWord.Clear();
                    }
                }
            }

            Console.WriteLine(output);

        }
    }
}
