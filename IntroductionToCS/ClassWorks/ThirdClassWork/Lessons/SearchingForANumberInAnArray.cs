using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.ThirdClassWork.Lessons
{
    internal class SearchingForANumberInAnArray : ILesson
    {
        public bool CanRun => true;

        public string Title => "Поиск числа в массиве";

        public void Run()
        {
            Console.WriteLine("Введите размер массима числе: ");
            string data = Console.ReadLine();

            if(!int.TryParse(data, out int size))
            {
                Console.WriteLine("не удалось получить размер");
            }

            int[] numbers = new int[size];
            var random = new Random(1);
            for(int i = 0; i < size; ++i)
            {
                numbers[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Введите число:");
            data = Console.ReadLine();

            if(!int.TryParse(data, out int number))
            {
                Console.WriteLine("не удалось получить число");
            }
            Console.Write($"[ ");
            for(int i = 0; i < size; ++i)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.Write($"]; ");
            Console.Write($"{number} => ");

            for(int i = 0; i < size; ++i)
            {
                if(numbers[i] == number)
                {
                    Console.WriteLine($"Да");
                    return;
                }
            }

            Console.WriteLine($"Нет");
        }
        public void AlternateImplementation()
        {
            Console.WriteLine("Введите размер массима числе: ");
            string data = Console.ReadLine();

            if(!int.TryParse(data, out int size))
            {
                Console.WriteLine("не удалось получить размер");
                return;
            }

            var random = new Random(1);
            int[] numbers = Enumerable.Range(0, size).Select(n => random.Next(-10, 11)).ToArray();

            Console.WriteLine("Введите число:");
            data = Console.ReadLine();

            if(!int.TryParse(data, out int number))
            {
                Console.WriteLine("не удалось получить число");
                return;
            }
            Console.Write($"[ ");
            Console.Write(string.Join(" ", numbers));
            Console.Write($"]; ");
            Console.Write($"{number} => ");

            if(numbers.Any(n => n == number))
                Console.WriteLine($"Да");

            Console.WriteLine($"Нет");
        }
    }
}
