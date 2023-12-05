using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FourthHomeWork.Lessons
{
    class ThreeDigitNumbers : ILesson
    {
        public bool CanRun => true;

        public string Title => "Массив трехзначных чисел";

        public void Run()
        {
            int arraySize = 10;
            int[] numbers = ArrayHelper.CreateIntArrayInRange(arraySize, 100, 1000);

            Console.WriteLine(string.Join("; ", numbers));
            Console.WriteLine($"Количество четных чисел в массиве: {numbers.Count(n => n % 2 == 0)}");
        }
    }
}
