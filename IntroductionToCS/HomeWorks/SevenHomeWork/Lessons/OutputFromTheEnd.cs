using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SevenHomeWork.Lessons
{
    class OutputFromTheEnd : ILesson
    {
        public bool CanRun => true;

        public string Title => "Вывод массива с конца";

        public void Run()
        {
            int[] numbers = ArrayHelper.CreateIntArrayInRange(10, 1, 10);

            Console.WriteLine(string.Join("; ", numbers));

            PrintLastItem(numbers);
        }
        public void PrintLastItem(int[] numbers)
        {
            if(numbers.Length == 0)
                return;

            Console.Write($"{numbers.Last()} ");
            PrintLastItem(numbers.Take(numbers.Length - 1).ToArray());
        }
    }
}
