using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SevenHomeWork.Lessons
{
    class Akkerman : ILesson
    {
        public bool CanRun => true;

        public string Title => "Вычисления функции Аккермана";

        public void Run()
        {
            if(!ConsoleHelper.TryGetInt64(out ulong firstNumber))
            {
                Console.WriteLine("Не удалось получить число");
                return;
            }
            if(!ConsoleHelper.TryGetInt64(out ulong secondNumber))
            {
                Console.WriteLine("Не удалось получить число");
                return;
            }

            Console.WriteLine(Calculate(firstNumber, secondNumber));
        }
        public ulong Calculate(ulong firstNumber, ulong secondNumber)
        {
            if(firstNumber == 0)
                return secondNumber + 1;
            else if(firstNumber != 0 && secondNumber == 0)
                return Calculate(firstNumber - 1, 1);
            else
                return Calculate(firstNumber - 1, Calculate(firstNumber, secondNumber - 1));
        }
    }
}
