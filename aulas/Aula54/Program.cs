using System;
using System.Collections.Generic;

namespace Principal
{
    class Aula54
    {
        static void Main()
        {
            int n1, n2, res;
            n1 = n2 = res = 0;

            n1 = 12;
            n2 = 0;

            try
            {
                res = n1 / n2;
                Console.WriteLine("{0}/{1}={2}", n1, n2, res);
                throw new Exception("erro curso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro:{0}", e.Message);
            }

        }
    }
}