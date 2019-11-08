using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Integracion
{
    class Program
    {
        static void Main(string[] args)
        {   
            Program.Menu();
            string opcion = Console.ReadLine();
            // stack -- pila preconstruida
            Stack pila = new Stack();
            string[] arreglo = new string[4];
            //Queue --- cola preconstruida
            Queue cola = new Queue();

            switch (opcion)
            {
                //caso 1 de swicht 
                case "1":
                    Console.WriteLine("Ingresar nombre para agregar la pila");
                    for (int i = 0; i < 4; i++)
                    {
                        arreglo[i] = Console.ReadLine();
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        pila.Push(arreglo[i]);
                    }
                    Console.WriteLine("\nEl resultado de pila es:");
                    for (int i = 0; i < 4; i++)
                    {
                        string men= (string)pila.Pop();
                        Console.WriteLine(men + " ");
                    }
                    Console.ReadKey();
                    break;
                //caso 2 del swicht 
                case "2":
                    Console.WriteLine("Ingresar cualquier nombre  la cola");
                    for (int i = 0; i < 4; i++)
                    {
                        arreglo[i] = Console.ReadLine();
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        cola.Enqueue(arreglo[i]);
                    }
                    Console.WriteLine("\n El resultado de  cola es:");
                    for (int i = 0; i < 4; i++)
                    {
                        string men = (string)cola.Dequeue();
                        Console.Write(men + " ");
                    }
                    Console.ReadKey();

                    //caso 3 que es salida del menu 
                    break;

                default:
                    break;
            }



        }
        //EL MENU DEL SISTEMA TAD
        static void Menu()
        {
            Console.WriteLine(" --- ----------------------------- ----");
            Console.WriteLine("       --- ELIJA UN NUMERO ----        ");
            
            Console.WriteLine("1.-   Crear Pila");
            Console.WriteLine("2.-   Crear Cola");
            Console.WriteLine("3.-   Salir");
            Console.WriteLine("---------------------------------------");
        }
    }
}