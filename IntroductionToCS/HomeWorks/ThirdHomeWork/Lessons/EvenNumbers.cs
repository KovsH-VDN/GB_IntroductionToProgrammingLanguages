using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.ThirdHomeWork.Lessons
{
    class EvenNumbers : ILesson
    {
        public bool CanRun => true;

        public string Title => "Четные числа";

        public void Run()
        {
            int minNumber = 1;
            int maxNumber = 100;

            int arraySize = 10;

            int[] arrayOfnumbers = new int[arraySize];
            Random random = new Random();

            for(int i = 0; i < arraySize; ++i)
            {
                arrayOfnumbers[i] = random.Next(minNumber, maxNumber);
            }

            Console.Write("В массиве [");

            int countNumberFromRange = 0;
            for(int i = 0; i < arraySize; ++i)
            {
                if(i > 0)
                    Console.Write($", ");

                int currentNumber = arrayOfnumbers[i];
                if(currentNumber % 2 == 0)
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

            Console.WriteLine($"] {countNumberFromRange} четных чисел");
        }
    }
}
