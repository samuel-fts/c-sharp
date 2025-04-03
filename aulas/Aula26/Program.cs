using System;

namespace Principal
{
    class Aula26
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = num1;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            num1 = 25;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            var arr = new string[2];
            arr[0] = "item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "item alterado";

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
        }
    }
}