using System;
using Balta.ContentContext;

namespace Program
{
    class Program
    {
        static void Main()
        {

            var course = new Course();
            course.Level = Balta.ContentContext.Enums.EContentLevel.Iniciante;

            foreach (var item in course.Module)
            {

            }
            var career = new Career();
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);
        }
    }
}