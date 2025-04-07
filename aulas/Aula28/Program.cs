using System;

namespace Principal
{
    class Aula28
    {
        static void Main()
        {
            var id = Guid.NewGuid();

            id.ToString();

            id = new Guid("186237d5-a1aa-4cbb-8ed6-9eff7324308e");
            Console.WriteLine(id);


        }
    }
}