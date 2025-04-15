using System;

namespace Principal
{
    class Aula34
    {
        static void Main()
        {
            var aluno1 = new Aluno("samuel", 25, 8.6, 7.23);
            if (aluno1.CalcularMedia() >= 5)
            {
                Console.WriteLine("voce passou");
                Console.WriteLine($"Sua media foi {aluno1.CalcularMedia()}");
            }
            else
            {
                Console.WriteLine("voce reprovou");
                Console.WriteLine($"Sua media foi {aluno1.CalcularMedia()}");
            }
        }
    }

    public class Aluno
    {
        public string Nome = "";
        public int Idade = 0;
        public double Nota1 = 0;
        public double Nota2 = 0;
        public Aluno(string nome, int idade, double nota1, double nota2)
        {
            Nome = nome;
            Idade = idade;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        public double CalcularMedia()
        {
            var res = (Nota1 + Nota2) / 2;
            return res;
        }


    }
}