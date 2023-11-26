using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.SecondHomeWork.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.SecondHomeWork
{
    public class SimpleAlgorithms : BaseWork
    {
        public SimpleAlgorithms()
        {
            Title = "Домашняя работа по лекции 2 \"Простые Алгоритмы\"";
            Lessons.Add(new MultiplicityOfTheNumber());
            Lessons.Add(new CoordinateQuarter());
            Lessons.Add(new TheLargestDigitOfTheNumber());
            Lessons.Add(new DigitsNumbers());
        }
    }
}
