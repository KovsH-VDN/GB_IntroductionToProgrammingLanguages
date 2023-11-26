using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.SecondClassWork.Lessons
{
    class OutputOfTheSecondDigitOfTheNumber : ILesson
    {
        public string Title => "Возведение второй цифры числа в степень третьей цифры";

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
            
            int third = number % 10; // получаем третью цифру числа
            int second = number / 10 % 10; // получаем вторую цифру число
            double degree = Math.Pow(second, third); // возводим second в степень third
            Console.WriteLine(degree); // выводим результат на экран
        }
    }
}
