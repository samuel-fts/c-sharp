using System;

namespace Principal
{
    class Mat
    {
        public static int Dobrar(int n)
        {
            return n * 2;
        }
    }
    class Aula52
    {
        static void Main()
        {
            Console.WriteLine(Mat.Dobrar(2));//posso chamar o metodo static de uma classe nao static sem precisar instanciar ela
        }
    }
}