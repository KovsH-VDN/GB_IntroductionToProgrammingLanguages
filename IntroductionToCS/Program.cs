using IntroductionToCS.ClassWorks.Introduction;
using IntroductionToCS.ClassWorks.ThirdClassWork;
using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.SecondHomeWork;
using System;
using System.Linq;

namespace IntroductionToCS
{
    class Program
    {
        static void Main(string[] args) => new Program().Start();

        private void Start()
        {
            // первый семинар - StartClassWork
            // второй семинар - SimpleAlgorithmsClassWork
            // третий семинар - ArraysClassWork
            // вторая дз - SimpleAlgorithmsHomeWork

            IWork work = new SimpleAlgorithmsHomeWork();
            while(work.IsWorking)
            {
                work.ShowLessons();

                if(!work.IsWorking)
                    return;

                Console.WriteLine("Нажмите любую клавишу для очистки консоли и продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
