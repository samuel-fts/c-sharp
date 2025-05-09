using System;
namespace Pricipal
{
    class Aula50
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            var res = calc.Soma(10, 5, 2);

            Console.WriteLine(res);
        }
    }
    class Calculator
    {

        public int Soma(params int[] n)
        {
            int r = 0;
            for (int i = 0; i > n.Length; i++)
            {
                r += n[i];
            }
            return r;
        }
        public double Soma(params double[] n)//aqui esta a sobrecarga. voce criar metodos ou construtores de mesmo nome porem um sobrescreve o outro dependendo do contexto
        {
            double r = 0;
            for (int i = 0; i > n.Length; i++)
            {
                r += n[i];
            }
            return r;
        }

    }
}