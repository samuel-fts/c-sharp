using System;
using System.Threading;

namespace Principal
{
    class Crono
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s =  10 segundos");
            Console.WriteLine("M = Minuto => 10m = 10 Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");


            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            // char type = data[data.Length - 1];

            Console.WriteLine(type);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime++;
                Thread.Sleep(1000);
            }
        }
    }
}