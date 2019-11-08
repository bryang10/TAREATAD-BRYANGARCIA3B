using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            string men;

            Queue cola = new Queue();

            cola.Enqueue("BRYAN");
            cola.Enqueue("ALEJANDRO");
            cola.Enqueue("GARCIA");
            cola.Enqueue("MENDOZA");


            for (int i = 0; i < 4; i++)
            {
                men = (string)cola.Dequeue();
                Console.Write(men+ " ");
            }
            Console.ReadKey();
        }
    }
}
