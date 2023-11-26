using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.SecondClassWork.Lessons
{
    class OutputOfTheThirdDigit : ILesson
    {
        public string Title => "Вывод третьей цифры";

        public bool CanRun => true;

        public void Run()
        {
            Console.Write("Введите число: "); // предлагаем пользователю ввести число
            string data = Console.ReadLine(); // получаем данные от пользователя

            int number = Convert.ToInt32(data); // конвертируем в целое число

            Console.Write(number); // выводим введенное число

            if(number < 100) // проверяем что число имеет более 2х знаков
            {
                Console.WriteLine($" => Третьей цифры нет");
                return;
            }
            while(number >= 1000) // проверяем что число имеет менее 4х знаков
            {
                number = number / 10;// (1234 / 10 = 123) дробная часть отбрасывается
            }
            Console.WriteLine($" => {number % 10}"); // выводим результат
        }
    }
}
