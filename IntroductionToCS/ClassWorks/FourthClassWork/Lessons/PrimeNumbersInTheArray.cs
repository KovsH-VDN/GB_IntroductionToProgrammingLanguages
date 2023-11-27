using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.FourthClassWork.Lessons
{
    class PrimeNumbersInTheArray : ILesson
    {
        public bool CanRun => true;

        public string Title => "Простые числа в массиве";

        public void Run()
        {
            int arraySize = 10;

            int[] arrayOfnumbers = ArrayHelper.CreateIntArrayInRange(arraySize, 1, 100);

            Console.Write("В массиве [");

            int countNumberFromRange = 0;
            for(int i = 0; i < arraySize; ++i)
            {
                if(i > 0)
                    Console.Write($", ");

                int currentNumber = arrayOfnumbers[i];
                if(IsPrime(currentNumber))
                {
                    ++countNumberFromRange;
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write($"{currentNumber}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine($"] {countNumberFromRange} простых чисел");

        }
        /// <summary>
        /// Определяет. является ли указанное число простым
        /// </summary>
        /// <param name="number">Число. которое необходимо проверить на простоту</param>
        /// <returns>true если число простое, иначе false</returns>
        private bool IsPrime(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
