using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FirstHomeWork
{
    public class Answer3
    {
        static void CheckIfEven(int number)
        {
            // Введите свое решение ниже

            Console.WriteLine($"Число `{number}` {(number % 2 == 0 ? "чётное" : "нечётное")}");
        }


        // Не удаляйте и не меняйте метод Main! 
        static public void Main1(string[] args)
        {
            int number;

            if(args.Length >= 1)
            {
                number = int.Parse(args[0]);
            }
            else
            {
                // Здесь вы можете поменять значения для отправки кода на Выполнение
                number = 6;
            }

            // Не удаляйте строки ниже
            CheckIfEven(number);
        }
    }
}
