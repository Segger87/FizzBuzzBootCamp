using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to increment up to: ");
            int count = int.Parse(Console.ReadLine());

            List<string> ls = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                bool isNumber = true;

                ls = MultipleOf3(i, ls, isNumber);
                ls = MultipleOf5(i, ls, isNumber);
                ls = MultipleOf7(i, ls, isNumber);
                ls = MultipleOf11(i, ls, isNumber);
                ls = MultipleOf13(i, ls, isNumber);
                ls = MultipleOf17(i, ls, isNumber);
                Console.WriteLine(String.Join(",", ls));
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static List<string> MultipleOf3(int i, List<string>ls, bool isNumber)
        {
            if (i % 3 == 0)
            {
                isNumber = false;
                ls.Add("Fizz");
            }
            return ls;
        }

        public static List<string> MultipleOf7(int i, List<string>ls, bool isNumber)
        {
            if (i % 7 == 0)
            {
                isNumber = false;
                ls.Add("Bang");
            }
            isNumber = false;
            return ls;
        }

        public static List<string> MultipleOf13(int i, List<string>ls, bool isNumber)
        {
            if (i % 13 == 0)
            {
                isNumber = false;
                ls.Add("Fezz");
            }
            return ls;
        }

        public static List<string> MultipleOf5(int i, List<string>ls, bool isNumber)
        {
            if (i % 5 == 0)
            {
                isNumber = false;
                ls.Add("Buzz");
            }
            return ls;
        }

        public static List<string> MultipleOf11(int i, List<string> ls, bool isNumber)
        {
            if (i % 11 == 0)
            {
                isNumber = false;
                ls.Add("Bong");
            }
            return ls;
        }

        public static List<string> MultipleOf17(int i, List<string>ls, bool isNumber)
        {
            if (i % 17 == 0)
            {
                isNumber = false;
                ls.Reverse();
            }
            return ls;
        }
    }
}
