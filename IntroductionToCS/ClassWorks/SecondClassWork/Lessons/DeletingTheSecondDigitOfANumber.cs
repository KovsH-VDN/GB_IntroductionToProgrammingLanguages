using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.SecondClassWork.Lessons
{
    public class DeletingTheSecondDigitOfANumber : ILesson
    {
        public string Title => "Удаление второй цифры числа";

        public bool CanRun => true;

        public void Run()
        {
            Console.Write("Введите трехзначное число: "); // предлагаем пользователю ввести число
            string data = Console.ReadLine(); // получаем данные от пользователя

            if(!int.TryParse(data, out int number) || number < 100 || number >= 1000)
            {
                // если не получилось привести введенное значение к целочисленному типу, или оно не 3х значное, выводим сообщение
                Console.WriteLine("Вы ввели некорректное число...");
                return; // выходим из метода
            }

            int lastDigit = number % 10; // получаем последнюю цифру числа
            int firstDigit = number / 100; // получаем первую цифру число
            int resultNumber = firstDigit * 10 + lastDigit; // сдвигаем первую цифру в лево на разряд с помощью умножения на 10 и прибавляем последнюю цифру
            Console.WriteLine(resultNumber); // выводим результат на экран
        }
    }
}
