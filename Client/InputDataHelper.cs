using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Client
{
    public class InputDataHelper
    {
        public string SetASign()
        {
            bool goodRequest = false;
            var action = string.Empty;
            while (!goodRequest)
            {
                Console.WriteLine("Выберите действие, которое хотите совершить с числами '+' '-' '/' '*'");
                var signAnswer = Console.ReadLine();

                switch (signAnswer)
                {
                    case "+":
                        action = "Addition";
                        goodRequest = true;
                        break;
                    case "-":
                        action = "Subtraction";
                        goodRequest = true;
                        break;
                    case "*":
                        action = "Multiplication";
                        goodRequest = true;
                        break;
                    case "/":
                        action = "Division";
                        goodRequest = true;
                        break;

                    default:
                        Console.WriteLine("Ничего не понял");
                        break;
                }
            }
            return action;
        }

        public string SetANumbers()
        {
            Console.WriteLine("Введите числа через пробел");
            var str = Console.ReadLine();
            var strNumb = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var numbers = new List<double>();
            double number;

            for (int i = 0; i < strNumb.Length; i++)
            {
                while (!double.TryParse(strNumb[i], out number))
                {
                    Console.WriteLine($"{strNumb[i]} - не валидное значение, введите другое");
                    strNumb[i] = Console.ReadLine();
                }
                numbers.Add(number);
            }
            var combinedString = string.Join(" ", numbers);

            return combinedString;

        }
    }
}
