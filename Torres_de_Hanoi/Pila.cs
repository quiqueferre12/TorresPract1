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
        
        public int Top { get; set; }
        
       
        
        public List<Disco> Elementos { get; set; }
        

        /* TODO: Implementar métodos */
        public Pila()
        {
            
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
        }

        public Disco pop()
        {
            Disco aux = Elementos[Elementos.Count-1];
            Elementos.RemoveAt(Elementos.Count-1);
            Size--;
            return aux;
        }                

        public bool isEmpty()
        {
            if (Elementos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
