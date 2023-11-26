using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.Introduction
{
    public class FromMinusNToN : ILesson
    {
        public string Title => "От минуса до плюcа";
        public bool CanRun => true;

        public void Run()
        {
            Console.WriteLine("Введите число");
            int customNumber = int.Parse(Console.ReadLine());

            int minusNumber = Math.Abs(customNumber) * -1;

            var numbers = Enumerable.Range(0, customNumber * 2 + 1).Select(n => minusNumber++).ToList();

            numbers.ForEach(n => Console.Write($"{n}; "));
            Console.WriteLine();
        }
    }
}
