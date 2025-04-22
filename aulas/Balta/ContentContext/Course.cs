using System.Collections.Generic;
namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Module = new List<Module>();
        }
        public string Tag { get; set; }

        public IList<Module> Module { get; set; }
    }
    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }

    public class Lecture
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
    }

}