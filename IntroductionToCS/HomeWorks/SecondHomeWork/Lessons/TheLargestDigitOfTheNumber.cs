using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SecondHomeWork.Lessons
{
    class TheLargestDigitOfTheNumber : ILesson
    {
        public bool CanRun => true;

        public string Title => "Наибольшая цифра числа";

        public void Run()
        {
            int min = 10;
            int max = 99;

            Console.WriteLine("Введите число:");
            string userData = Console.ReadLine();

            if(!int.TryParse(userData, out int number))
            {
                Console.WriteLine("Не удалось получить число.");
                return;
            }

            if(number < min || number > max)
            {
                Console.WriteLine($"Число {number} не находится в диапазоне [{min}, {max}]");
                return;
            }

            int maxDigit = -1;

            Console.Write($"В чисале {number} ");
            while(number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if(maxDigit < digit)
                    maxDigit = digit;
            }

            Console.WriteLine($"максимальныя цифра - {maxDigit}");
        }
    }
}
