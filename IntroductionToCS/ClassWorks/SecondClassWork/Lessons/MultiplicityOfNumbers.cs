using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.SecondClassWork.Lessons
{
    public class MultiplicityOfNumbers : ILesson
    {
        public string Title => "Кратность чисел";

        public bool CanRun => true;

        public void Run()
        {
            Console.WriteLine("Введите первое число: ");
            var data1 = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            var data2 = Console.ReadLine();
            
            if(!int.TryParse(data1, out int number1))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            if(!int.TryParse(data2, out int number2))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            var multiplicity = number1 % number2;
            if(multiplicity == 0)
                Console.WriteLine("Да");
            else
                Console.WriteLine($"Нет, {multiplicity}");
        }
    }
}
