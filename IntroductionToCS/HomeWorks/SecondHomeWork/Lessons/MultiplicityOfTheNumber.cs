using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SecondHomeWork.Lessons
{
    class MultiplicityOfTheNumber : ILesson
    {
        public bool CanRun => true;

        public string Title => "Кратность числа на 7 и 23";

        public void Run()
        {
            Console.WriteLine("Введите число:");
            string userData = Console.ReadLine();

            if(!int.TryParse(userData, out int number))
            {
                Console.WriteLine("Не удалось получить число.");
                return;
            }

            Console.Write($"Число {number} => ");
            if(number % 7 == 0 && number % 23 == 0)
                Console.WriteLine("да.");
            else
                Console.WriteLine("нет.");
        }
    }
}
