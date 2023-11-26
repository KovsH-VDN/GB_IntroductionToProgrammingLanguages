using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SecondHomeWork.Lessons
{
    class DigitsNumbers : ILesson
    {
        public bool CanRun => true;

        public string Title => "Цифры числа";

        public void Run()
        {
            Console.WriteLine("Введите число:");
            var data = Console.ReadLine();

            if(!int.TryParse(data, out int number))
            {
                Console.WriteLine("Не удалось получить число.");
                return;
            }

            Console.Write($"{number} => ");

            if(number < 10)
            {
                Console.WriteLine($"{number}");
                return;
            }

            int invertedNumber = 0;

            while(number > 0)
            {
                int digit = number % 10;
                number /= 10;
                invertedNumber = invertedNumber * 10 + digit;
            }

            bool isFirstDigit = true;

            while(invertedNumber > 0)
            {
                if(!isFirstDigit)
                    Console.Write($", ");

                int digit = invertedNumber % 10;
                invertedNumber /= 10;

                Console.Write($"{digit}");
                isFirstDigit = false;
            }

            Console.WriteLine();
        }
    }
}
