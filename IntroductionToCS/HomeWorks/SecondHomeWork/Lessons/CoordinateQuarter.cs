using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SecondHomeWork.Lessons
{
    class CoordinateQuarter : ILesson
    {
        public bool CanRun => true;

        public string Title => "Координатная четверть";

        public void Run()
        {
            Console.WriteLine("Введите координату X:");
            string userData = Console.ReadLine();

            if(!int.TryParse(userData, out int xCoordinate))
            {
                Console.WriteLine("Не удалось получить координату X.");
                return;
            }
            Console.WriteLine("Введите координату Y:");
            userData = Console.ReadLine();

            if(!int.TryParse(userData, out int yCoordinate))
            {
                Console.WriteLine("Не удалось получить координату Y.");
                return;
            }

            if(xCoordinate == 0 || yCoordinate == 0)
            {
                Console.WriteLine("Одна из координа равно 0");
                return;
            }

            Console.Write($"{xCoordinate}, {yCoordinate} => ");
            if(xCoordinate > 0 && yCoordinate > 0)
                Console.WriteLine("1");
            else if(xCoordinate < 0 && yCoordinate < 0)
                Console.WriteLine("3");
            else if(xCoordinate > 0 && yCoordinate < 0)
                Console.WriteLine("4");
            else
                Console.WriteLine("2");
        }
    }
}
