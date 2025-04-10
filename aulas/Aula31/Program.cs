using System;
using System.Globalization;
namespace Pricipal
{
    class Aula31
    {
        static void Main()
        {
            var pt = new CultureInfo("pt-BR");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", pt));
        }
    }
}