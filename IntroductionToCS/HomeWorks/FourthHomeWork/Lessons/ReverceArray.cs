using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FourthHomeWork.Lessons
{
    class ReverceArray : ILesson
    {
        public bool CanRun => true;

        public string Title => "Инвертирование массива";

        public void Run()
        {
            int arraySize = 10;
            int[] numbers = ArrayHelper.CreateIntArrayInRange(arraySize, 0, 10);

            Console.WriteLine(string.Join("; ", numbers));

            Console.WriteLine(string.Join("; ", numbers.Reverse().ToArray()));

        }
    }
}
