using System;

namespace Principal
{
    class Aula27
    {
        static void Main()
        {
            Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);
            Product ManutencaoEletrica = new Product(2, "Manutencao eletrica residencial", 500, EProductType.Service);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.ConvertPriceToDollar(5.60));

            Console.WriteLine(ManutencaoEletrica.Price);
            Console.WriteLine(ManutencaoEletrica.Type);
        }

        struct Product
        {
            public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;

            }
            public int Id;
            public string Name;
            public double Price;
            public EProductType Type;

            public double ConvertPriceToDollar(double dolar)
            {

                return Price / dolar;

            }

        }

    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
