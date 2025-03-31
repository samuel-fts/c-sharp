using System;

namespace Principal{
    class Aula16{
        static void Main(){
            inicio://label. um ponto de referencia para o goto

            Console.Clear();

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
            Console.WriteLine("Gostaria de fazer outro calculo?[s/n]");
            escolha = char.Parse(Console.ReadLine());

            if(escolha == 's' || escolha == 'S'){
                goto inicio;//ele desvia e manda a continuacao do codigo para o label descrito 
            }else{
                Console.Clear();
                Console.WriteLine("fim do programa");
            }

        }
    }
}
