using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Hanoi Hanoi = new Hanoi();
            Console.WriteLine("bienvenido, elige el numero de disco");

            int n =  Convert.ToInt32(Console.ReadLine());
            Pila INI = new Pila(n, "ini");
            Pila AUX = new Pila("aux");
            Pila FIN = new Pila("fin");

            Console.WriteLine("Elige el metodo, i para iterativo, r para recursivo");
            string letra = Console.ReadLine();

            if (letra == "i")
            {
               
                int m = Hanoi.iterativo(n, INI, FIN, AUX);
                Console.WriteLine("Número de movimientos: " + m);
            }
            else if (letra == "r")
            {
                int m = Hanoi.algoritmoRecursivo(n, INI, FIN, AUX);
                Console.WriteLine("Número de movimientos 2: " + m);
            }
            

            //Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
