using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMessage = null;
            Console.WriteLine("Please Write name of text file ");
            string filePath = Console.ReadLine();
            try
            {
                Console.WriteLine(FileToString(filePath));
            }
            catch (ArgumentException ae)
            {
                errorMessage = ae.Message;
            }
            catch (PathTooLongException ptle)
            {
                errorMessage = ptle.Message;
            }
            catch (DirectoryNotFoundException dnfe)
            {
                errorMessage = dnfe.Message;
            }
            catch (FileNotFoundException fnfe)
            {
                errorMessage = fnfe.Message;
            }
            catch (IOException ioe)
            {
                errorMessage = ioe.Message;
            }
            catch (UnauthorizedAccessException uae)
            {
                errorMessage = uae.Message;
            } 
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
            finally
            {
                if (errorMessage != null)
                {
                    Console.WriteLine(errorMessage);
                }
            }
            Console.WriteLine(new string('-',50));
            
            Console.WriteLine("Please inser path for text file");
            string path = Console.ReadLine();
            Console.WriteLine("Please insert a sentence");
            string contents = Console.ReadLine();
            string error = null;
            try
            {
                Console.WriteLine(   StringToFile(path, contents));
            }

            catch (ArgumentNullException ane)
            {
                error= ane.Message;
            }
            catch (ArgumentException ae)
            {
                error = ae.Message;
            }
            catch (PathTooLongException ptle)
            {
                error = ptle.Message;
            }
            catch (DirectoryNotFoundException dnfe)
            {
                error = dnfe.Message;
            }
            catch (FileNotFoundException fnfe)
            {
                error = fnfe.Message;
            }
            catch (IOException ioe)
            {
                error = ioe.Message;
            }
            catch (UnauthorizedAccessException uae)
            {
                error = uae.Message;
            }
            catch (NotSupportedException nse)
            {
                error = nse.Message;
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            finally
            {
                if (error != null)
                {
                    Console.WriteLine(errorMessage);
                }
            }


        }

        private static string FileToString(string filePath)
        {
            string toString = File.ReadAllText(filePath, Encoding.UTF8);
            return toString;
            
        }
        private static string StringToFile(string path, string contents)
        {


           File.AppendAllText(path, contents);
           return File.ReadAllText(path, Encoding.UTF8);
            

        }
    }
}
