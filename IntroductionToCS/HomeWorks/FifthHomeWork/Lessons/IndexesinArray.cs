using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FifthHomeWork.Lessons
{
    class IndexesinArray : ILesson
    {
        public bool CanRun => true;

        public string Title => "Элемент массива";

        public void Run()
        {
            string parseErrorMessage = "Не удалось получить индекс";
            int[,] numbers = new[,]
            {
                {1, 2, 3, 4, 5, 6 },
                {9, 8, 7, 6, 5, 5 },
                {1, 9, 2, 8, 3, 7 }
            };
            Console.WriteLine("Введите первый индекс массива:");
            var customData = Console.ReadLine();
            if(!int.TryParse(customData, out int firstIndex))
            {
                Console.WriteLine(parseErrorMessage);
            }

            Console.WriteLine("Введите второй индекс массива:");
            customData = Console.ReadLine();
            if(!int.TryParse(customData, out int secondIndex))
            {
                Console.WriteLine(parseErrorMessage);
            }

            if(firstIndex < 0 || firstIndex > numbers.GetLength(0) || secondIndex < 0 || secondIndex > numbers.GetLength(1))
            {
                Console.WriteLine("Элемента не существует");
                return;
            }

            Console.WriteLine(numbers[firstIndex, secondIndex]);
        }
    }
}
