using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.Introduction
{
    public class HellowWorld : ILesson
    {
        public string Title => "Первый урок - HelloWorld";
        public bool CanRun => false;

        public void Run()
        {
            Console.WriteLine("HelloWorld");
        }
    }
}
