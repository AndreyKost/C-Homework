using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms3
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> list = new List<string>();
            Console.Write("Enter your sentence. No punctuation.   : ");
            string sent = (Console.ReadLine());
            string[] words = sent.Split();
            for (int i = 0; i < words.Length; i++)
            {
                list.Add(words[i]);
            }
            // Sorts words
            var sort =
                from word in list
                let lowerWord = word.ToLower()
                orderby lowerWord
                select lowerWord;
            foreach (string c in sort)
            {
                Console.WriteLine(c);
            }
        }
    }
}
        
        
       
 

