using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.Introduction
{
    public class DaysOfWeek : ILesson
    {
        public string Title => "Получения дня недели по его номеру";
        public bool CanRun => true;
        private string[] Days = new string[]
        {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"
        };


        public void Run()
        {
            Console.Write("Введите номер дня недели: ");
            int dayNumber = int.Parse(Console.ReadLine());

            if(dayNumber < 0 || dayNumber > Days.Length)
                Console.WriteLine("Введен не верный номер дня...");

            Console.WriteLine(Days[dayNumber - 1]);
        }
    }
}
