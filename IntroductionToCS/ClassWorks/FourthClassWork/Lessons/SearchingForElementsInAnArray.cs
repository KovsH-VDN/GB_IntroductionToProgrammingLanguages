using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.FourthClassWork.Lessons
{
    class SearchingForElementsInAnArray : ILesson
    {
        public bool CanRun => true;

        public string Title => "Поиск элементов в массиве";

        public void Run()
        {
            int lastDigit = 1;

            int arraySize = ReadArraySize();
            int[] numbers = CreateNumberArray(arraySize);
            PrintArray(numbers, ", ");
            Console.WriteLine(int.Parse(string.Join("", numbers)));
            return;

            PrintArray(numbers, ", ");

            int count = 0;
            for(int i= 0; i < arraySize; ++i)
            {
                int currentNumber = numbers[i];
                if(CheckLastDigit(currentNumber, lastDigit) && DivideByDigit(currentNumber, 7))
                    ++count; // префиксный инкремент
                    //count++; // постфиксный инкремент
            }
            Console.WriteLine($" => {count}");

            int.Parse(string.Join("", numbers)); // при условии что array.Length < 10
            Convert.ToInt32(string.Join("", numbers));
        }
        public int ReadArraySize()
        {
            Console.WriteLine("Введите размер массива:");
            string data = Console.ReadLine();
            return Convert.ToInt32(data);
        }
        public int[] CreateNumberArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for(int i = 0; i < size; ++i)
            {
                array[i] = random.Next(0, 10);
            }

            return array;
        }
        public bool CheckLastDigit(int number, int digit)
        {
            return number % 10 == digit;
        }
        public bool DivideByDigit(int number, int digit)
        {
            return number % digit == 0;
        }
        public void PrintArray(int[] array, string separator)
        {
            Console.WriteLine(string.Join(separator, array));
        }
    }
}
