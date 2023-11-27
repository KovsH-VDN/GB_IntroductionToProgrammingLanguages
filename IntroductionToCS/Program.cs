using IntroductionToCS.ClassWorks.FourthClassWork;
using IntroductionToCS.ClassWorks.Introduction;
using IntroductionToCS.ClassWorks.SecondClassWork;
using IntroductionToCS.ClassWorks.ThirdClassWork;
using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.SecondHomeWork;
using IntroductionToCS.HomeWorks.ThirdHomeWork;
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
            // третье дз - ArrayHomeWork
            // четвертый семинар - Functions

            IWork work = new Functions();
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
