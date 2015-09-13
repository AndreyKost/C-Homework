using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    class Program
    {
        private static Exception SentenceNotCompletedException;
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("Bot.txt"))
            {
               
                    string line = reader.ReadLine();
                    Proverka(line);
                        
            }
            
        }
        static void Proverka(string content)
        {
            try
            {
                if ((content.EndsWith(".") || content.EndsWith("!")) || content.EndsWith("?"))
                {
                    Console.WriteLine("True");
                }

            }
            catch (Exception)
            {

                Console.WriteLine(   SentenceNotCompletedException);
            }
        }
       
        
    }
}
