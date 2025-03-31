using System;

namespace Principal{
    class Aula22{
        static void Main(){
            int[] num = new int[5]{11,22,33,44,55};
            foreach(int n in num){//"n" nao e o index, ele recebe o valor de cada interacao. igual um map
                Console.WriteLine("array na posicao{0}, recebe {0}",n);
            }
        }
    }
}