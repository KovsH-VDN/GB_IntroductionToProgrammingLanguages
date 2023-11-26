using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCS.Common
{
    public abstract class BaseWork : IWork
    {
        private const string QuitCommand = "quit";
        public bool IsWorking { get; protected set; }
        public string Title { get; protected set; }
        public List<ILesson> Lessons { get; }

        protected BaseWork()
        {
            IsWorking = true;
            Lessons = new List<ILesson>();
        }

        public void ShowLessons()
        {
            Console.WriteLine($"{Title}");
            Console.WriteLine("Доступные уроки:");

            int lessonCount = 1;
            foreach(var lesson in Lessons)
            {
                Console.ForegroundColor = lesson.CanRun ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine($"{lessonCount++}: {lesson.Title}{(!lesson.CanRun ? " (не реализованно)" : "")}");
            }

            Console.ResetColor();

            int selectedIndex;
            do
            {
                Console.Write($"Введите номер урока для демострации, или введите {QuitCommand} для выхода: ");
                var data = Console.ReadLine();
                if(data.ToLower() == QuitCommand)
                {
                    IsWorking = false;
                    return;
                }

                if(!int.TryParse(data, out selectedIndex) || selectedIndex < 1 || selectedIndex > Lessons.Count)
                {
                    Console.WriteLine("Вы ввели неверный номер");
                    selectedIndex = -1;
                }
                else if(!Lessons[selectedIndex - 1].CanRun)
                {
                    Console.WriteLine("Вы выбрали не реализованный урок");
                    selectedIndex = -1;
                }
            } while(selectedIndex == -1);

            var currentLesson = Lessons[selectedIndex - 1];
            Console.Clear();
            Console.WriteLine($"Вы выбрали урок - {currentLesson.Title}");
            currentLesson.Run();
        }
    }
}
