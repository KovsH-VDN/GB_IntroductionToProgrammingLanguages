using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FifthHomeWork.Lessons
{
    class Register : ILesson
    {
        public bool CanRun => true;

        public string Title => "Регистр";

        public void Run()
        {
            string str = "dhGF haADtIdAsGDY ASdhhsdgaGDAy";
            Console.WriteLine(str);
            Console.WriteLine(str.ToLower());
        }
    }
}
