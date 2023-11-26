using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.Introduction
{
    public class TheSquareOfTheNumber : ILesson
    {
        public string Title => "Возведение числа в квадрат";
        public bool CanRun => true;

        public void Run()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number} * {number} = {number * number}");
        }
    }
}
