using Balta.ContentContext.Enums;

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
        public int DurationInMinute { get; set; }

        public EContentLevel Level { get; set; }
    }
}