using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.ThirdClassWork.Lessons
{
    internal class ReplacingArrayElements : ILesson
    {
        public bool CanRun => true;

        public string Title => "Замена элементов массива";

        public void Run()
        {
            int size = 10;
            int min = -10;
            int max = 11;

            var random = new Random(1);
            int[] numbers = new int[size];

            for(int i = 0; i < size; ++i)
            {
                numbers[i] = random.Next(min, max);
            }
            
            for(int i = 0; i < size; ++i)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < size; ++i)
            {
                numbers[i] *= -1;
            }

            for(int i = 0; i < size; ++i)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        public void AlternateImplementation()
        {
            int size = 10;
            int min = -10;
            int max = 10;

            var random = new Random(1); // 1 в конструкторе указана для того, чтоб при каждом запуске класс генерировал один набор
            int[] numbers = Enumerable.Range(0, size).Select(n => random.Next(min, max)).ToArray();

            Console.WriteLine(string.Join(" ", numbers));

            Console.WriteLine(string.Join(" ", numbers.Select(n => n * -1)));
        }
    }
}
