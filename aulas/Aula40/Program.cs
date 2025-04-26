using System;

namespace Pricipal
{
    class Aula40
    {
        static void Main()
        {
            int v1 = Convert.ToInt32(Console.ReadLine());
            int v2 = Convert.ToInt32(Console.ReadLine());

            int res = Cfb(v1, v2);
            Console.WriteLine(res);
            int num = 10;
            Dobrar(ref num);// assim esta passando a referencia do ponteiro, munmdando direto dentro da alocacao e nao atribuindo a outra o resultado dado no novo metodo
        }


        static int Cfb(int n1, int n2)
        {

            int res = n1 + n2;
            Console.WriteLine("Cfb cursos");
            return res;
        }
        static void Dobrar(ref int valor)
        {
            valor *= 2;

        }
    }
}