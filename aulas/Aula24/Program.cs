using System;

namespace Principal
{
    class Aula24
    {
        static void Main()
        {
            int inteiro = 100;
            float real = 25.5f;

            // real = inteiro;
            // inteiro = (int)real;
            //parse so aceita texto, entao tem que colocar dentro de parenteses
            inteiro = int.Parse(real.ToString());//inteiro vai receber o parse do alia int para real que e um floar para string

            inteiro = Convert.ToInt32(real);// inteiro recebe o uso da class convert dentro do metodo ToInt32 passando o parametro real para ser convertido e arredondado

            switch (inteiro)
            {
                case 100: Console.WriteLine("100"); break;
                default: Console.WriteLine("errado"); break;
            }

        }
    }
}