using System;

namespace Pricipal
{
    struct Carro
    {
        public string Marca;
        public string Modelo;

        public string Cor;

        public Carro(string marca, string modelo, string cor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
        }
    }
    class Aula49
    {
        static void Main()
        {
            Carro c1 = new Carro("vk", "golf", "prata");
            Carro[] carros = new Carro[2];

            carros[0].Modelo = "HRV";

        }
    }
}