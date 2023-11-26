using IntroductionToCS.ClassWorks.ThirdClassWork.Lessons;
using IntroductionToCS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.ClassWorks.ThirdClassWork
{
    internal class ArraysClassWork : BaseWork, IWork
    {
        public ArraysClassWork()
        {
            Title = "Массивы";

            Lessons.Add(new SearchingForANumberInAnArray());
            Lessons.Add(new ReplacingArrayElements());
            Lessons.Add(new TheProductOfPairsOfNumbers());
            Lessons.Add(new ArrayOfDigitsOfANumber());
        }
    }
}
