using System;

namespace Principal
{
    class Aula30
    {
        static void Main()
        {
            Console.Clear();
            var data = new DateTime(2000, 12, 12, 14, 43, 12);
            // var data = DateTime.Now;

            var formatado = String.Format("{0:yyyy}", data);//para formatacao deve ser colocado dentro de chaves junto ao 0
            Console.WriteLine(formatado);
        }
    }
}