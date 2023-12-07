using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.SevenHomeWork.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SevenHomeWork
{
    class RecursionHomeWork : BaseWork
    {
        public RecursionHomeWork()
        {
            Title = "домашняя работа по рекурсии";
            Lessons.Add(new RangeNumbers());
            Lessons.Add(new Akkerman());
            Lessons.Add(new OutputFromTheEnd());
        }
    }
}
