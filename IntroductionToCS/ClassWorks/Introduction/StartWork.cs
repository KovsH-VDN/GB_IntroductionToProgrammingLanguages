using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.Introduction
{
    public class StartWork : BaseWork, IWork
    {
        public StartWork() : base()
        {
            Title = "Вступительный семинар по знакосмтву с C#";
            Lessons.Add(new HellowWorld());
            Lessons.Add(new TheSquareOfTheNumber());
            Lessons.Add(new CheckingTheSquare());
            Lessons.Add(new DaysOfWeek());
            Lessons.Add(new FromMinusNToN());
            Lessons.Add(new LastNumber());
        }
    }
}
