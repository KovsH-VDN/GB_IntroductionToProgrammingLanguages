using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FifthHomeWork.Lessons
{
    class MinSum : ILesson
    {
        public bool CanRun => true;

        public string Title => "Строка и минимальной суммой";

        public void Run()
        {
            int[,] numbers = new int[,]
            {
                {1, 2, 3, 4, 5, 6 },
                {9, 8, 7, 6, 5, 5 },
                {1, 9, 2, 8, 3, 7 },
                {9, 1, 8, 2, 7, 3 }
            };
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);

            for(int i = 0; i < rows; ++i)
            {
                for(int j = 0; j < columns; ++j)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var array = numbers.Cast<int>().ToArray();
            var numbersArray = Enumerable.Range(0, rows).Select(n => array.Skip(n * columns).Take(columns).ToArray()).Select(a => a.Sum()).ToList();
            var min = numbersArray.Min();
            Console.WriteLine($"Индекс строки с минимальной суммой ({min}) - {numbersArray.IndexOf(min)}");
        }
    }
}
