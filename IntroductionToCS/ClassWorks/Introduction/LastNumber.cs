using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.Introduction
{
    public class LastNumber : ILesson
    {
        public string Title => "Последня цифра трехзначного числа";
        public bool CanRun => true;

        public void Run()
        {
            Console.Write("Введите трехначное число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number % 10);
        }
    }
}
