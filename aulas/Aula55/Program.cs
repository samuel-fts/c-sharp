using System;
using System.Collections.Generic;

namespace Principal
{
    class Aula55
    {
        static void Main()
        {
            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            veiculos.Add(10, "moto");
            veiculos.Add(20, "navio");

            veiculos.Clear();//limpa o dicionario


            Console.WriteLine("Tamanho do dictionary: {0}", veiculos.Count);//mostra a qunatidade de items dentro do dicionario
            int chave = 22;
            if (veiculos.ContainsKey(chave))
            {
                Console.WriteLine("esta na colecao");
            }

            veiculos[10] = "carro";


        }
    }
}