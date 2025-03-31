using System;

namespace Principal{
    class Aula15{
        static void Main(){
            char escolha;
            int tempo=0;

            Console.WriteLine("escolha entre esse a, b , c");
            escolha = char.Parse(Console.ReadLine());


            switch(escolha){
                case 'A':
                case 'a':
                    tempo= 2;
                    break;
                case 'B':
                case 'b':
                    tempo= 3;
                    break;
                case 'C':
                case 'c':   
                    tempo = 4;
                    break;
                default:
                    Console.WriteLine("escravo um comando valido");
                    break;
            }
            
            Console.WriteLine("seu tempo sera de {0}", tempo);
            

        }
    }
}