using System;
using System.Collections.Generic;

namespace Pricipal
{
    class Aula56
    {
        static void Main()
        {
            LinkedList<string> transp = new LinkedList<string>();
            transp.AddFirst("carro");
            transp.AddFirst("moto");
            transp.AddFirst("onibus");
            transp.AddFirst("aviao");

            LinkedListNode<string> no;
            no = transp.FindLast("carro").Next;
            transp.AddAfter(no, "patins");

            transp.Remove("carro");
            transp.Clear();
            transp.RemoveFirst();
            transp.RemoveLast();


            foreach (string t in transp)
            {
                Console.WriteLine("transporte:{0}", t);
            }
        }
    }
}