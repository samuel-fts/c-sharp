using System;

namespace Aula02 //organiza em pastas os programas 
{
    class Program //tudo e feito em classes e dentro de classes
    {
        static void Main(string[] args)//metodo principal, onde void diz que nao espera retornar nada, main diz que e a funcao principal
        {//string e args, sao argumentos de entradas, que ao digitar no console sera posto dentro de arg
            Console.WriteLine("Hello World");//metodo write line quebra a linha
            if(args.GetLength(0)>0){//se o tamanho da variavel na posicao 0 de args for maior que 0, ou seja, se a posicao noa for vazia, entao executa o codigo passado
                Console.WriteLine(args.GetValue(0));
            }
                   
        }
    }
}
