using System;
namespace Principal
{
    class Aula40
    {
        static void Main()
        {
            Soma(2, 4, 2, 4);
        }
        static void Soma(params int[] n)//o params da a possibilidade de indicar mais de um parametro dentro da funcao 
        {
            int res = 0;
            if (n.Length < 1)
            {
                Console.WriteLine("nao exitem parametros a serem somados");
            }
            else if (n.Length == 1)
            {
                Console.WriteLine("adicione mais 1 numero a ser somado");
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    res += n[i];

                }
                Console.WriteLine($"A soma dos valores deu {res}");
            }
        }
    }
}