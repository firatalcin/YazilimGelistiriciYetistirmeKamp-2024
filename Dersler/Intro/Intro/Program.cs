using Intro.Business;
using Intro.Entities;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Krediler";
            int term = 12;
            double amount = 100000.5;

            //variables -> camelCase
            bool IsAuthenticated = true;

            Console.WriteLine(message);

            //Condition
            if (IsAuthenticated)
            {
                Console.WriteLine("Hoşgeldin Fırat");
            }

            string[] loans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4", "kredi 5" };

            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i]);
            }

            CourseManager courseManager = new CourseManager();
            Course[] courses = courseManager.GetAll();

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i].Name + " - " + courses[i].Price);
            }



            
        }
    }
}
