using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public List<Disco> Elementos { get; set; }
        public string Nombre { get; set; }

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */
        public Pila(string n)
        {
            Nombre = n;
            Size = 0;
            Elementos = new List<Disco> ();
 
        }
        public Pila(int cantidad,string n)
        {
            Nombre = n;
            Size = cantidad;
            Elementos = new List<Disco>();
            
            for (int i = 0; i < Size; i++)
            {
                Disco nuevo = new Disco();
                nuevo.Valor = cantidad;
                Elementos.Add(nuevo);
                cantidad--;
            }

        }
        public Disco Top
        {
            get
            {
                if (isEmpty() == false)
                {
                    return Elementos[Size - 1];
                }
                return null;
            }
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;   
        }

        public Disco Pop()
        {
            Disco ultimoDisco = Top;
            Elementos.RemoveAt(Size-1);
            Size--;
            return ultimoDisco;
            
        }

        public bool isEmpty()
        {
            if (Size > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

    }
}
