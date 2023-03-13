using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi

    {
        /*TODO: Implementar métodos*/
        private static int num_discos;
        private static int num_movimientos;
        private static Pila INI, FIN, AUX;




        public static void mover_disco(Pila a, Pila b)
        {
            if (!pruebaAutomatica())
            {
                if (a.isEmpty() == false)
                {
                    if (b.isEmpty() == true)
                    {
                        b.push(a.Pop());
                        num_movimientos++;
                        Console.WriteLine(a.Nombre + "-" + b.Top.Valor + "->" + b.Nombre);
                    }
                    else if (a.Top.Valor < b.Top.Valor)
                    {
                        b.push(a.Pop());
                        num_movimientos++;
                        Console.WriteLine(a.Nombre + "-" + b.Top.Valor + "->" + b.Nombre);

                    }
                    else
                    {
                        a.push(b.Pop());
                        num_movimientos++;
                        Console.WriteLine(b.Nombre + "-" + a.Top.Valor + "->" + a.Nombre);

                    }
                }
                else
                {
                    if (b.isEmpty() == false)
                    {
                        a.push(b.Pop());
                        num_movimientos++;
                        Console.WriteLine(b.Nombre + "-" + a.Top.Valor + "->" + a.Nombre);

                    }
                }
            }
          
            
        }

        public static int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {

            INI = ini;
            FIN = fin;
            AUX =aux;

            num_movimientos = 0;
            num_discos = n;

            if (n % 2 != 0) 
            {
                while (pruebaAutomatica() == false) 
                {
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                }
                
            }
            else
            {
                while (pruebaAutomatica() == false) 
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);
                }
            }
            
            return num_movimientos;
        }
       
        public static int algoritmoRecursivo(int n,Pila ini,Pila fin, Pila aux)
        {
            INI = ini;
            FIN = fin;
            AUX = aux;
                        
            num_discos = n;

            int m= 0;

            if (n == 1)
            {
                mover_disco(ini,fin);
                m++;
            }
            else
            {
                m += algoritmoRecursivo(n-1,ini,aux,fin);
                mover_disco(ini, fin);
                m++;
                m += algoritmoRecursivo(n - 1, aux, fin, ini);
            }
            return m;
        }

        private static bool pruebaAutomatica( )
        {
            if ((FIN.Size == num_discos) && (INI.Size == 0))
            {
                return true;
            }
            return false;
        }

    }
}
