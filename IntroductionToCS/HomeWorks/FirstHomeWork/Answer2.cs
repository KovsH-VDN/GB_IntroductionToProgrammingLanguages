using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FirstHomeWork
{
    public class Answer2
    {

        static int FindMax(int a, int b, int c)
        {
            // Введите свое решение ниже
            return new int[] { a, b, c }.Max();
        }

        // Не удаляйте и не меняйте метод Main! 
        static public void Main1(string[] args)
        {
            int a, b, c;

            if(args.Length >= 3)
            {
                a = int.Parse(args[0]);
                b = int.Parse(args[1]);
                c = int.Parse(args[2]);
            }
            else
            {
                // Здесь вы можете поменять значения для отправки кода на Выполнение
                a = 5;
                b = 6;
                c = 7;
            }

            // Не удаляйте строки ниже
            int result = FindMax(a, b, c);
            System.Console.WriteLine($"{result}");
        }
    }
}
