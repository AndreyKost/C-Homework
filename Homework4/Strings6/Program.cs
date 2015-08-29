using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings6
{
    class Program
    {
        const string INPUT_FILE = "masa.txt";
        const string OUTPUT_FILE = "text.txt";
        
 
        static void Main(string[] args)
        {
            try
            {
                StreamReader streamReader =
                        new StreamReader(INPUT_FILE);
                StreamWriter streamWriter =
                            new StreamWriter(OUTPUT_FILE);
                using (streamReader)
                {
                    using (streamWriter)
                    {
                        string line;
                        int lineCounter = 1;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (lineCounter % 2 != 0)
                            {
                                streamWriter.WriteLine(line); 
                            }
                            lineCounter++;
                            
                            
                        }
                    }
                }
            }
            catch (IOException exc)
            {

                Console.WriteLine("Error: {0}.", exc.Message);
            }

            using (StreamReader reader = new StreamReader("masa.txt"))
            {
                using (StreamWriter writer = new StreamWriter("text1.txt"))
                {
                    string line;
                    int lineCounter = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineCounter % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        lineCounter++;

                        
                    }
                }
            }
        }
    }
}
