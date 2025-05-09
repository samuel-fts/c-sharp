using System;

namespace Principal
{
    class Aula51
    {
        static void Main()
        {
            Calc calc = new Calc();
            var res = calc.Fat(5);
            Console.WriteLine(res);
        }
    }
    class Calc
    {
        public int Fat(int n)
        {
            int res;
            if (n <= 1)
            {
                res = 1;
            }
            else
            {
                res = n * Fat(n - 1);
            }
            return res;
        }
    }
}