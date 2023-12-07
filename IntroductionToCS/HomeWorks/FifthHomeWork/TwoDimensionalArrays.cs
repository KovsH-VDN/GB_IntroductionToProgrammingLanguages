﻿using IntroductionToCS.Common;
using IntroductionToCS.HomeWorks.FifthHomeWork.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.HomeWorks.FifthHomeWork
{
    class TwoDimensionalArrays : BaseWork
    {
        public TwoDimensionalArrays()
        {
            Title = "Домашняя работа №5: \"Массивы и строки\"";
            Lessons.Add(new AStringFromTheArray());
            Lessons.Add(new Register());
            Lessons.Add(new Palindrome());
        }
    }
}
