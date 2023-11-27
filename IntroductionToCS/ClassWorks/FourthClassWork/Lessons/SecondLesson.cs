using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.FourthClassWork.Lessons
{
    class SecondLesson : ILesson
    {
        public bool CanRun => false;

        public string Title => "2";

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
