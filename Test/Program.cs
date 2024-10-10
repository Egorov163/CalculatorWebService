using System.Collections.Generic;
using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strNumbers = "1000 100 50 100 200 400";
            var numbers = Parser(strNumbers);
            var sub = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                sub = sub - numbers[i];
            }
            
            Console.WriteLine(sub);
        }




        public static List<int> Parser(string str)
        {
            var strNumb = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var num = new List<int>();

            for (int i = 0; i < strNumb.Length; i++)
            {
                num.Add(int.Parse(strNumb[i]));
            }
            return num;
        }
    }
}
