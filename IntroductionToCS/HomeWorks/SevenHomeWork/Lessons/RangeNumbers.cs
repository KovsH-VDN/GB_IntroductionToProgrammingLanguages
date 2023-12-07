using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SevenHomeWork.Lessons
{
    class RangeNumbers : ILesson
    {
        public bool CanRun => true;

        public string Title => "Числа от M до N";

        public void Run()
        {
            if(!ConsoleHelper.TryGetInt32(out int number))
                return;

            if(!ConsoleHelper.TryGetInt32(out int number2))
                return;

            PrintNumbers(number, number2);
        }

        private void PrintNumbers(int current, int last)
        {
            if(current > last)
                return;

            Console.WriteLine(current);
            PrintNumbers(++current, last);
        }
    }
}
