using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete broi stoinosti za array");
          int n= int.Parse(Console.ReadLine());
          int[] array=new int[n];
          
          int index;
          Console.WriteLine("vuvedete stoinostite na masiva");
          for(int i=0;i<n;i++)
          {
             array[i]=int.Parse(Console.ReadLine());
          }
          Console.WriteLine("Vuvedete tursenoto chislo");
          int x=int.Parse(Console.ReadLine());
          //Проверка за срещане на елемент х
          for(int j=0;j<n;j++)
          if(array[j]==x)
          {
            index=j;
            Console.WriteLine("indexa e "+j);
            break;
          }

        }
    }
}
