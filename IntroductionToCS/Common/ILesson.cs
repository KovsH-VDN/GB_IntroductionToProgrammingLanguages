using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.Common
{
    public interface ILesson
    {
        /// <summary>
        /// True если урок может быть запущен. иначе false
        /// </summary>
        bool CanRun { get; }
        /// <summary>
        /// Заголовок урока
        /// </summary>
        string Title { get; }
        /// <summary>
        /// Запускает урок
        /// </summary>
        void Run();
    }
}
