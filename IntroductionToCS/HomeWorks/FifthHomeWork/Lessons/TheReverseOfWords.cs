using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FifthHomeWork.Lessons
{
    class TheReverseOfWords : ILesson
    {
        public bool CanRun => true;

        public string Title => "Инверсия слов";

        public void Run()
        {
            string str = Console.ReadLine();

            var strArray = str.Split(' ');
            var newStr = string.Join(" ", strArray.Reverse());
            Console.WriteLine(newStr);
        }
    }
}
