using System;

namespace Principal
{
    class Aula25
    {
        static void Main()
        {
            string nomeCompleto = ConcactNome("samuel", "bruna");
            Console.WriteLine(nomeCompleto);
        }

        static string ConcactNome(string nome, string sobrenome)
        {
            return nome + sobrenome;
        }
    }
}