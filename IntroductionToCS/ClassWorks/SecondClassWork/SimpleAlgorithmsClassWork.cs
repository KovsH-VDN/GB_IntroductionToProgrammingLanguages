using IntroductionToCS.ClassWorks.SecondClassWork.Lessons;
using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.SecondClassWork
{
    public class SimpleAlgorithmsClassWork : BaseWork, IWork
    {
        public SimpleAlgorithmsClassWork()
        {
            Title = "Второй семинар: Простые алгоритмы.";
            Lessons.Add(new DeletingTheSecondDigitOfANumber());
            Lessons.Add(new OutputOfTheSecondDigitOfTheNumber());
            Lessons.Add(new MultiplicityOfNumbers());
            Lessons.Add(new OutputOfTheThirdDigit());
        }
    }
}
