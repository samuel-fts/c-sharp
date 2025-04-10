using System;
namespace Pricipal
{
    class Aula33
    {
        static void Main()
        {
            var arr = new int[3];
            try
            {
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops.algo due errado");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
        }
    }
}