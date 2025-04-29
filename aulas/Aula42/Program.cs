using System;
namespace Principal
{
    class Aula42
    {
        static void Main()
        {
            Jogador j1 = new Jogador(29, true);
            Console.WriteLine("Energia do jogador {0}", j1.Energia);
        }


    }
    public class Jogador
    {
        public int Energia;
        public bool Vivo;
        public Jogador(int energia, bool vivo)
        {
            Energia = energia;
            Vivo = vivo;
        }
    }
}