using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure8
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            int n = int.Parse(inputLine);

            HashSet<int> set1 = FillSet1(n);
            HashSet<int> set2 = FillSet2(n);
            HashSet<int> set3 = FillSet3(n);

            HashSet<int> intersection12 = IntersectSets(set1, set2);
            PrintSet(intersection12);

            HashSet<int> intersection13 = IntersectSets(set1, set3);
            PrintSet(intersection13);

            HashSet<int> intersection23 = IntersectSets(set2, set3);
            PrintSet(intersection23);

            HashSet<int> intersection123 = IntersectSets(set1, intersection23);
            PrintSet(intersection123);

            HashSet<int> union12 = UnionSets(set1, set2);
            PrintSet(union12);

            HashSet<int> union13 = UnionSets(set1, set3);
            PrintSet(union13);

            HashSet<int> union23 = UnionSets(set2, set3);
            PrintSet(union23);

            HashSet<int> union123 = UnionSets(set1, union23);
            PrintSet(union123);
        }

        private static HashSet<int> UnionSets(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> union = new HashSet<int>();
            foreach (int element in set1)
            {
                union.Add(element);
            }
            union.UnionWith(set2);
            return union;
        }

        private static HashSet<int> IntersectSets(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> intersection = new HashSet<int>();
            foreach (int element in set1)
            {
                intersection.Add(element);
            }
            intersection.IntersectWith(set2);
            return intersection;
        }

        private static void PrintSet(HashSet<int> set)
        {
            StringBuilder buffer = new StringBuilder();
            foreach (int element in set)
            {
                buffer.AppendFormat("{0} ", element);
            }
            if (buffer.Length != 0)
            {
                Console.WriteLine(buffer.ToString());
            }
        }

        private static HashSet<int> FillSet1(int n)
        {
            HashSet<int> set = new HashSet<int>();

            int currentElement = 1;
            while (currentElement <= n)
            {
                set.Add(currentElement);
                currentElement = 2 * currentElement + 3;
            }
            return set;
        }

        private static HashSet<int> FillSet2(int n)
        {
            HashSet<int> set = new HashSet<int>();

            int currentElement = 2;
            while (currentElement <= n)
            {
                set.Add(currentElement);
                currentElement = 3 * currentElement + 1;
            }

            return set;
        }

        private static HashSet<int> FillSet3(int n)
        {
            HashSet<int> set = new HashSet<int>();

            int currentElement = 2;
            while (currentElement <= n)
            {
                set.Add(currentElement);
                currentElement = 2 * currentElement - 1;
            }

            return set;

        }
    }
}
