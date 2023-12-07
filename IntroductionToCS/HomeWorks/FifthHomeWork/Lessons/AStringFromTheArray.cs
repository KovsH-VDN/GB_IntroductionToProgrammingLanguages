using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FifthHomeWork.Lessons
{
    class AStringFromTheArray : ILesson
    {
        public bool CanRun => true;

        public string Title => "Строка из массива";

        public void Run()
        {
            char[,] symbols = new char[,]
            {
                {'a', 'b', 'c' },
                {'d', 'i' ,'f' },
            };

            string arrayToString = new string(symbols.Cast<char>().ToArray());

            Console.WriteLine(arrayToString);
        }

    }
}
