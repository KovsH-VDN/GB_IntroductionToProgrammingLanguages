using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.Common
{
    public static class ConsoleHelper
    {
        public static string GetString(string title)
        {
            Console.WriteLine($"Введите {title}");
            return Console.ReadLine();
        }
        public static int GetInt32()
        {
            var data = GetString("целое число");
            if(!int.TryParse(data, out int number))
                return number;

            return -1;
        }
        public static long GetInt64()
        {
            var data = GetString("целое число");
            if(!long.TryParse(data, out long number))
                return number;

            return -1;
        }
        public static double GetDouble()
        {
            var data = GetString("натуральное число");
            if(!double.TryParse(data, out double number))
                return number;

            return double.NaN;
        }
    }
}
