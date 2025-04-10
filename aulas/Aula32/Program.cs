using System;
using System.Globalization;

namespace Principal
{
    class Aula32
    {
        static void Main()
        {
            Console.Clear();
            decimal valor = 10.25m;
            valor = Math.Round(valor);//arredonda de forma automatica, dependendo do  valor depois da virgula
            valor = Math.Ceiling(valor);//arredonda pra cima
            valor = Math.Floor(valor);//arredonda pra baixo
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));//pega de dentro da culture info o metodo de criar a formatacao do valor dado no parametro
        }
    }
}