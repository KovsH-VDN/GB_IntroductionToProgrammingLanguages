using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.FourthHomeWork.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FourthHomeWork
{
    class FunctionsHomeWork : BaseWork
    {
        public FunctionsHomeWork()
        {
            Title = "Домашняя работа по теме \"Функции\"";
            Lessons.Add(new InfiniteNumbers());
            Lessons.Add(new ThreeDigitNumbers());
            Lessons.Add(new ReverceArray());
        }
    }
}
