using System;

namespace Principal
{
    class Aula29
    {
        static void Main()
        {
            var texto = "Este texto e um teste";

            Console.WriteLine(texto.CompareTo("Teste"));//retorna um valor inteiro
            Console.WriteLine(texto.Contains("teste"));//retorna um bool
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));//retorna um bool ignorando qualquer sensitive case

            Console.WriteLine(texto.StartsWith("Este"));//retorna um bool para a comparacoa no start do texto
            Console.WriteLine(texto.EndsWith("teste"));//retorna um bool para a comparacao no end do texto

            Console.WriteLine(texto.Equals("Este texto e um teste"));// retorna um bool caso seja completamente igual
            Console.WriteLine(texto.Equals("este texto e um teste", StringComparison.OrdinalIgnoreCase));//retorna um bool caso seja completamente igual ignorando o sensitive case

            Console.WriteLine(texto.IndexOf("u"));//retorna a posicao do primeiro caracter escrito no parametro
            Console.WriteLine(texto.LastIndexOf("e"));//retorna a posicao do ultimo caracter escrito no parametro

            Console.WriteLine(texto.ToUpper());//um metodo que identa o texto para todas as letras ficarem maiusculas
            Console.WriteLine(texto.ToLower());//um metodo onde identa o texto para ficar todas minusculas

            Console.WriteLine(texto.Insert(5, "Aqui "));//insere esperando como parametro a posicao de inicio a ser inserida e o que sera inserido
            Console.WriteLine(texto.Remove(5, 5));// remove esperando dentro do primeiro parametro o indice do inicio de onde sera remvido e espera no segundp parametro ate quantos caractere dpoiis do primeiro serao retirados
            Console.WriteLine(texto.Length);//retorna o tamanho de caracteres dentro desse array ou string


        }
    }
}