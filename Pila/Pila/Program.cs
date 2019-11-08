using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            string men;
            // stack  es desapilar - clases preconstruidas
            Stack pila = new Stack();

            pila.Push("BRYAN");
            pila.Push("ALEJANDRO");
            pila.Push("GARCIA");
            pila.Push("MENDOZA");
            

            for (int i = 0; i < 4; i++)
            {
                men= (string)pila.Pop();
                Console.WriteLine(men + " ");
            }
            Console.ReadKey();
        }
    }
}
