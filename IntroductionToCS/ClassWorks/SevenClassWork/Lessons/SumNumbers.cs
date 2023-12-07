using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.SevenClassWork.Lessons
{
    class SumNumbers : ILesson
    {
        public bool CanRun => true;

        public string Title => "Сумма чисел";

        public void Run()
        {
            if(!ConsoleHelper.TryGetInt32(out int number))
                return;

            Console.WriteLine(GetSum(number));
        }
        public int GetSum(int number)
        {
            if(number == 0)
                return 0;

            return number % 10 + GetSum(number / 10);
        }
    }
}
