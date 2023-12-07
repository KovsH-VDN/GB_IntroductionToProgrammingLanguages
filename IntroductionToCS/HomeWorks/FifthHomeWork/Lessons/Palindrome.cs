using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FifthHomeWork.Lessons
{
    class Palindrome : ILesson
    {
        public bool CanRun => true;

        public string Title => "Палиндром";

        public void Run()
        {
            var str = Console.ReadLine();

            int take = str.Length / 2;
            int skip = take + (str.Length % 2 == 0 ? 0 : 1);

            var leftStr = new string(str.Take(take).ToArray());
            var rightStr = new string(str.Skip(skip).Take(take).Reverse().ToArray());

            Console.WriteLine($"Слово \"{str}\" {(leftStr == rightStr ? "" : "не ")}является палиндромом");

        }
    }
}
