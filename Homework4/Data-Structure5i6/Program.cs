using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure5i6
{
    class Program
    {
        private static readonly string TEXT =
           "C# is a type-safe, object-oriented language that is simple yet powerful, " +
           "allowing programmers to build a breadth of applications.   " +
           "Combined with the .NET Framework, Visual C# enables the creation of Windows applications, " +
           "Web services, database tools, components, controls, and more. ";

        static void Main()
        {
            IDictionary<String, int> wordOccurrenceMap =
                  GetWordOccurrenceMap(TEXT);
            PrintWordOccurrenceCount(wordOccurrenceMap);
        }

        private static IDictionary<string, int> GetWordOccurrenceMap(
              string text)
        {

            string[] tokens =
                  text.Split(' ', '.', ',', '-', '?', '!');

            IDictionary<string, int> words =
                  new SortedDictionary<string, int>();

            foreach (string word in tokens)
            {
                if (string.IsNullOrEmpty(word.Trim()))
                {
                    continue;
                }

                int count;
                if (!words.TryGetValue(word, out count))
                {
                    count = 0;
                }
                words[word] = count + 1;
            }
            return words;
        }

        private static void PrintWordOccurrenceCount(
              IDictionary<string, int> wordOccuranceMap)
        {
            foreach (KeyValuePair<string, int> wordEntry
                  in wordOccuranceMap)
            {
                Console.WriteLine(
                      "Word '{0}' occurs {1} time(s) in the text",
                      wordEntry.Key, wordEntry.Value);
            }

            Console.ReadKey();
        }
    }
}

