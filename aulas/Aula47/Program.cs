using System;

namespace Principal
{
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Base");
        }
        virtual public void Info()
        {

        }
    }

    public class Derivada : Base
    {
        public Derivada()
        {
            Console.WriteLine("Derivada1");
        }
        override public void Info()
        {
            Console.WriteLine("foi sobrescrito");
        }
    }
    class Aula47
    {
        static void Main()
        {
            Base rif;
            Derivada derivada = new Derivada();
            rif = derivada;
            rif.Info();
        }
    }
}