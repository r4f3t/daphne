using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ShoppingList
{
    class Program
    {

        static void procFile(string fileName)
        {
            string[] lines = File.ReadAllLines(@""+fileName+"", Encoding.UTF8);
            List<VEGROMANINT> _list = new List<VEGROMANINT>();
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);

            }
        }
        private static Dictionary<char, int> RomanIntMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

       class VEGROMANINT
        {
            public string NAME { get; set; }
            public string ROMAN { get; set; }
            public int VALUE { get; set; }
        }

        public static int ConvertToInt(string roman)
        {
            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanIntMap[roman[i]] < RomanIntMap[roman[i + 1]])
                {
                    number -= RomanIntMap[roman[i]];
                }
                else
                {
                    number += RomanIntMap[roman[i]];
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
           
            string fileName = Console.ReadLine();
            procFile(fileName);
            string roman = Console.ReadLine();
            int sayi = ConvertToInt(roman);

            Console.WriteLine(sayi.ToString());
            Console.ReadKey();
        }
    }
}
