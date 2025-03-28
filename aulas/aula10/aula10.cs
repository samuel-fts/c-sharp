using System;

namespace Principal{
    class Aula10{

        enum DiasSemana{Dom,Seg,Ter};//e um tipo que recebe valores diversos do tipo int

        static void Main(){
            DiasSemana ds = DiasSemana.Dom;//nesse caso,ele so retorna para a variavel o seu nome
            Console.WriteLine(ds);
        }
    }
}