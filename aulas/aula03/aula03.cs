using System;// uma librarie onde podemos usar diversas classes uteis no dia a dia
namespace Principal{//serve para agrupar class e nao deixar o codigo de forma desorganizada
    class Aula03{
        static void Main(){
            int num=0;//atribuir valores a principio para a variavel, e um bom costume, ja que antigamente nao existia os gerenciadores de lixo, onde os campos de memorias ficavam com valores lixos  dentro dela.
            char letra='c';//nao se usa aspas, so em strings que noa e um tipo primitivo
            float valor=5.3f;
            byte n1=10;//0 e 255
            string nome="samuel";//noa e primitivo, pois e um conjunto de char

            var aux=10;// um tipo noa especifico, msm sendo fortemente tipada, o var e declarado pelo tipo do valor que ela recebe, nao podendo mudar o tipo depois
        
            Console.WriteLine(aux);//um metodo de System

        }
    }
}
