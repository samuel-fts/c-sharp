namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career()
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }

        public int TotalCourses => Items.Count;

        //expression body, usado quando se tem somente o get e uma linha de codigo para o return
    }

}