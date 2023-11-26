using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.Introduction
{
    class CheckingTheSquare : ILesson
    {
        public string Title => "Проверка квадрата числа";

        public bool CanRun => true;

        public void Run()
        {
            Console.Write("Введите квадрат любого числа: ");
            int sqr = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Квадрат = {sqr}, число = {number} =>");

            if(number * number == sqr)
                Console.WriteLine($" Да");
            else
                Console.WriteLine($" Нет");
        }
    }
}
