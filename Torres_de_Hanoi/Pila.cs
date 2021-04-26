using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }//atr tamanyo de la pila con sus getters i setters
        
        public int Top { get; set; }//atr para saber la primera ficha mas arriba de la pila de discos
        
        public List<Disco> Elementos { get; set; }//lista de discos
        

        /* TODO: Implementar métodos */
        public Pila()//definimos el constructor por defecto
        {
            Size=0;
            Top=0;
            Elementos = new List<Disco>();
        }

        public Pila(List<Disco> Elemento)//constructor con elementos
        {
            Size=Elemento.Count;
            Top=Elemento.Last().Valor;
            Elementos = Elemento;
        }

        public void push(Disco d)//metodo para poner discos
        {
            Elementos.Add(d);
            Size=Elementos.Count;
            Top = d.Valor;
        }

        public Disco pop()//metodo para quitar disco y guardarse el disco mas arriba de la pila
        {
            Disco aux = Elementos.Last();
            Elementos.Remove(aux);
            Size=Elementos.Count;
           
            if(Size == 0)
            {
                Top = 0;//para que no de error si no hay ningun disco en la pila
            }
            else
            {
                 Top = Elementos.Last().Valor;//actualizamos el nuevo top
            }

            return aux;
        }                

        public bool isEmpty()//si esta vacía la pila devuelve verdadero, si no falso
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
