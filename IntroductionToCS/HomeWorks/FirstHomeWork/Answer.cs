using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FirstHomeWork
{
    public class Answer
    {
        static void CompareNumbers(int firstNumber, int secondNumber)
        {
            // Введите свое решение ниже
            if(firstNumber == secondNumber)
            {
                Console.WriteLine($"Введенные числа равны `{secondNumber}`");
                return;
            }

            Console.WriteLine($"Первое число `{firstNumber}` {(firstNumber > secondNumber ? "больше" : "меньше")} чем второе число `{secondNumber}`");
        }


        // Не удаляйте и не меняйте метод Main! 
        static public void Main1(string[] args)
        {
            int firstNumber, secondNumber;

            if(args.Length >= 2)
            {
                firstNumber = int.Parse(args[0]);
                secondNumber = int.Parse(args[1]);
            }
            else
            {
                // Здесь вы можете поменять значения для отправки кода на Выполнение
                firstNumber = 10;
                secondNumber = 5;
            }

            // Не удаляйте строки ниже
            CompareNumbers(firstNumber, secondNumber);
        }
    }
}
