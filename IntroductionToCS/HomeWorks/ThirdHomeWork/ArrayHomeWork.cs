using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.ThirdHomeWork.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.ThirdHomeWork
{
    class ArrayHomeWork : BaseWork
    {
        public ArrayHomeWork()
        {
            Title = "Домашняя работа по лекции 3 \"Массивы\"";
            Lessons.Add(new NumbersInTheRange());
            Lessons.Add(new EvenNumbers());
            Lessons.Add(new TheDifferenceBetweenTheMaxAndMinNumbers());
            Lessons.Add(new ArrayOfDigitsFromTheNumber());
        }
    }
}
