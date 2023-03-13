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

            Pila INI = new Pila(3, "ini");
            Pila AUX = new Pila("aux");
            Pila FIN = new Pila("fin");

            Console.WriteLine("bienvenido!");

            Hanoi Hanoi = new Hanoi();
            int m =Hanoi.iterativo(3, INI, FIN, AUX);
            Console.WriteLine("Número de movimientos: " + m);

            //Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
