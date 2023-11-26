using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.ThirdClassWork.Lessons
{
    internal class TheProductOfPairsOfNumbers : ILesson
    {
        public bool CanRun => true;

        public string Title => "Произведение пар чисел";

        public void Run()
        {
            int min = -10;
            int max = 11;

            Random random = new Random(1);
            int size = random.Next(5, 11);

            int[] numbers = Enumerable.Range(0, size) // заказываем числа количеством size (0 1 2 3 4 5 ...)
                .Select(n => random.Next(min, max)) // заменяем каждое число на случайное
                .ToArray(); // строим массив

            Console.WriteLine(string.Join(" ", numbers)); // выводи массив на экран

            int middle = size / 2; // находим середину массива

            int[] firstNumbers = numbers // берем наш массив чисел
                .Take(middle) // и берем из него число до середины массива
                .ToArray(); // как результат строим новый массив

            int[] lastNumbers = numbers // берем снова наш массив
                .Skip(middle + (size % 2)) // пропускаем до середины + остаток от деления размера массива на 2
                .Reverse() // инвертируем результат (например последние элементы 7, 5, 9) эта оперция вернет 9, 5, 7
                .ToArray(); // как результат строим новый массив

            // skip: если размер массива == 6, остаток от деления будет 0, а значит мы пропускае 3 элемента. и забираем остальные 3
            // если размер == 7, middle = 3, а остаток от деления будет равен 1, значит средний элемент массива будет под индексом 4 (в примере это 7), а значит она нам не нужна
            // то есть, мы пропускаем 3 + 1, и забираем 3 последних элемента

            int[] productNumbers = firstNumbers // берем первый массив чисел
                .Zip(lastNumbers, // как колонку добавляем массив последних элементов
                     (f, l) => f * l) // и как результат возвращаем перемноженные числа
                .ToArray(); // как результат строим новый массив

            // Zip: 
            //      f   l   result
            //      4   9   4 * 9
            //      0   5   0 * 5
            //      -1  7   -1 * 7

            Console.WriteLine(string.Join(" ", productNumbers)); // выводи массив на экран

        }
    }
}
