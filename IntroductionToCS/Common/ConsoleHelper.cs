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
        public static bool TryGetInt32(out int number)
        {
            var data = GetString("целое число");
            return int.TryParse(data, out number);
        }
        public static bool TryGetInt64(out ulong number)
        {
            var data = GetString("положительное целое число");
            return ulong.TryParse(data, out number);
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
