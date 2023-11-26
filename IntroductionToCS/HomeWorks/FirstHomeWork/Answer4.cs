using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FirstHomeWork
{
    public class Answer4
    {
        static void PrintEvenNumbers(int number)
        {
            // Введите свое решение ниже

            foreach(var evenNumber in Enumerable.Range(1, number).Where(n => n % 2 == 0))
                Console.Write($"{evenNumber}\t");

            //for(int i = 2; i <= number; i += 2)
            //    Console.Write($"{i}\t");
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
                number = 9;
            }

            // Не удаляйте строки ниже
            PrintEvenNumbers(number);
        }
    }
}
