using IntroductionToCS.ClassWorks.ThirdClassWork.Lessons;
using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.ThirdHomeWork.Lessons
{
    class ArrayOfDigitsFromTheNumber : ILesson
    {
        public bool CanRun => true;

        public string Title => "Массив цифр из числа";

        public void Run()
        {
            int min = 1;
            int max = 100_000;

            Console.WriteLine("Введите число:");
            var data = Console.ReadLine();

            if(!int.TryParse(data, out int number))
            {
                Console.WriteLine("Не удалось получить число.");
                return;
            }
            if(number < min || number > max)
            {
                Console.WriteLine($"Число {number} не находится в диапазоне [{min}, {max}]");
                return;
            }

            Console.Write($"{number} => [");

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
            Console.WriteLine($"]");
        }
    }
}
