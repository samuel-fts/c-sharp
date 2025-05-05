using System;

namespace Principal
{
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Base");
        }

    }

    public class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Derivada1");
        }
    }
    public class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Derivada2");
        }
    }
    class Aula46
    {
        static void Main()
        {
            var der = new Derivada2();
        }
    }
}