using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_Task1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "bella", "label", "roller" };
            HashSet<char> commonChars = new HashSet<char>(strings[0]);

            foreach (string str in strings.Skip(1))
            {
                HashSet<char> chars = new HashSet<char>(str);
                commonChars.IntersectWith(chars);
            }
            Console.WriteLine(string.Join("", commonChars));
            Console.ReadLine();
        }
    }
}