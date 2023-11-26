using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.Common
{
    public interface IWork
    {
        bool IsWorking { get; }
        List<ILesson> Lessons { get; }
        void ShowLessons();
    }
}
