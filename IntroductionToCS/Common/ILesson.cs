using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.Common
{
    public interface ILesson
    {
        bool CanRun { get; }
        string Title { get; }
        void Run();
    }
}
