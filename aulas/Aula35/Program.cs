using System;

namespace Pricipal
{
    class Aula35
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine("pagando");
        }
        static void Main()
        {
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(34);
        }
    }
    public class Pagamento
    {
        public delegate void Pagar(double valor);
    }
}