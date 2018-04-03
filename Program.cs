using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static bool isNumber;
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to increment up to: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Please type which rules you wish to enter");
            string rulesToBeApplied = Console.ReadLine();
        
                for (int i = 1; i <= count; i++)
                {
                    List<string> ls = new List<string>();
                    isNumber = true;

                if (rulesToBeApplied.Contains("3"))
                {
                    ls = MultipleOf3(i, ls);
                }
                if (rulesToBeApplied.Contains("5"))
                {
                    ls = MultipleOf5(i, ls);
                }
                if (rulesToBeApplied.Contains("7"))
                {
                    ls = MultipleOf7(i, ls);
                }
                if (rulesToBeApplied.Contains("11"))
                {
                    ls = MultipleOf11(i, ls);
                }
                if (rulesToBeApplied.Contains("13"))
                {
                    ls = MultipleOf13(i, ls);
                }
                if (rulesToBeApplied.Contains("17"))
                {
                    ls = MultipleOf17(i, ls);
                }
           
                if (isNumber)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine(String.Join("", ls));
                    }
                }
            Console.ReadLine();
        }

        public static List<string> MultipleOf3(int i, List<string>ls)
        {
            if (i % 3 == 0)
            {
                isNumber = false;
                ls.Add("Fizz");
            }
            return ls;
        }

        public static List<string> MultipleOf7(int i, List<string>ls)
        {
            if (i % 7 == 0)
            {
                isNumber = false;
                ls.Add("Bang");
            }
            return ls;
        }

        public static List<string> MultipleOf13(int i, List<string>ls)
        {
            if (i % 13 == 0)
            {
                isNumber = false;
                ls.Add("Fezz");
            }
            return ls;
        }

        public static List<string> MultipleOf5(int i, List<string>ls)
        {
            if (i % 5 == 0)
            {
                isNumber = false;
                ls.Add("Buzz");
            }
            return ls;
        }

        public static List<string> MultipleOf11(int i, List<string> ls)
        {
            if (i % 11 == 0)
            {
                isNumber = false;
                ls.Add("Bong");
            }
            return ls;
        }

        public static List<string> MultipleOf17(int i, List<string>ls)
        {
            if (i % 17 == 0)
            {
                ls.Reverse();
            }
            return ls;
        }
    }
}
