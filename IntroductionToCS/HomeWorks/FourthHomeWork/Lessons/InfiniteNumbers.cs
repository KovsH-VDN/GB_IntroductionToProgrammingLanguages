using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FourthHomeWork.Lessons
{
    class InfiniteNumbers : ILesson
    {
        public bool CanRun => true;

        public string Title => "Бесконечные числа";

        public void Run()
        {
            string quitCommand = "q";
            while(true)
            {
                var customData = Console.ReadLine();
                if(customData == quitCommand)
                    break;

                if(!int.TryParse(customData, out int number))
                {
                    Console.WriteLine("Вы ввели не число");
                    continue;
                }

                int summ = customData.Select(c => int.Parse(c.ToString())).Sum();
                Console.WriteLine($"Сумма цифер числа {customData} = {summ}");
                if(summ % 2 == 0)
                    break;
            }
        }
    }
}
