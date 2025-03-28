using System;

namespace Principal{
    class Aula11{
        static void Main(){
            int n1 = 10;
            float n2 = n1;//isso e uma conversao implicita, entao rodara sem problemas dentro do codigo

            float n3 = 10.5f;
            int n4 = n3;// isso nao funcionara, pois e uma conversao nao implicita, vc precisara converter de forma manual

            n4 = (int)n3;//diz que n4 recebera n3 convertido para inteiro

        }
    }
}