using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.FifthHomeWork.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FifthHomeWork
{
    class HomeWork : BaseWork
    {
        public HomeWork()
        {
            Lessons.Add(new IndexesinArray());
            Lessons.Add(new Swap());
        }
    }
}
