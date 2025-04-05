using System;

namespace Principal
{
    class Calculator
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma \n2 - Subtracao \n3 - Divisao \n4 - Multiplicacao \n5 - Exit \n ------------------");

            Console.WriteLine("Digite o numero correspondente ao que desejas");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite op primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite mais um numero");
            float v2 = float.Parse(Console.ReadLine());


            Console.WriteLine($"O valor da soma entre {v1} e {v2} deu {v1 + v2}");
            // Console.WriteLine($"O valor da soma entre {v1} e {v2} deu " + (v1 + v2));
            // Console.WriteLine("O valor da soma entre {0} e {1} deu " + (v1 + v2), v1, v2);
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite um valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da subtracao foi {v1 - v2}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()

        {
            Console.Clear();
            Console.WriteLine("Digite um numero");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisao foi:{v1 / v2}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da multiplicacao foi: {v1 * v2}");
            Console.ReadKey();
            Menu();
        }


    }
    public class Solution
    {
        Two
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int point = nums.Length - 1;

                if (nums[i] <= target)
                {
                    if ((nums[i] + nums[point]) == target)
                    {
                        return nums[i], nums[point];
                    }
                    point--;
                }

            }
        }
    }

}
