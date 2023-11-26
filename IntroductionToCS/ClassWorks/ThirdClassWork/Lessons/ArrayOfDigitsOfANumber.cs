using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IntroductionToCS.ClassWorks.ThirdClassWork.Lessons
{
    internal class ArrayOfDigitsOfANumber : ILesson
    {
        public bool CanRun => true;
        public string Title => "Массив из цифр числа";
        public void Run()
        {
            Console.WriteLine("Введите число:");
            var data = Console.ReadLine();

            if(!int.TryParse(data, out _))
            {
                Console.WriteLine("Не удалось получить число.");
                return;
            }

            int[] numbers = data.Select(c => int.Parse(c.ToString())).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
