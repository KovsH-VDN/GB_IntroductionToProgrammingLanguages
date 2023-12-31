﻿
using IntroductionToCS.ClassWorks.FourthClassWork;
using IntroductionToCS.ClassWorks.Introduction;
using IntroductionToCS.ClassWorks.SecondClassWork;
using IntroductionToCS.ClassWorks.SevenClassWork;
using IntroductionToCS.ClassWorks.ThirdClassWork;
using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.FifthHomeWork;
using IntroductionToCS.HomeWorks.FourthHomeWork;
using IntroductionToCS.HomeWorks.SecondHomeWork;
using IntroductionToCS.HomeWorks.SevenHomeWork;
using IntroductionToCS.HomeWorks.ThirdHomeWork;
using System;
using System.Linq;

namespace IntroductionToCS
{
    class Program
    {
        static void Main(string[] args) => new Program().Start();

        private void Start()
        {
            IWork work = new RecursionHomeWork();
            while(work.IsWorking)
            {
                work.ShowLessons();

                if(!work.IsWorking)
                    return;

                Console.WriteLine("Нажмите любую клавишу для очистки консоли и продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
