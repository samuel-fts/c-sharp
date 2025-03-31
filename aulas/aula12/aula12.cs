using System;

namespace Principal{
    class Aula12{
        static void Main(){
            int num = 1;

            num = int.Parse(Console.ReadLine());// um cast de conversao para a escrita numeral se tranformar em um int, entao usase Parse e nao (int)

            if(num == 1){
                Console.WriteLine("existe num");
            }
        }
    }
}