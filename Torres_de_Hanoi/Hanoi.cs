using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        //TODO: Implementar métodos
        public void mover_disco(Pila a, Pila b)  
        {
            
              //si hay algun disco en la pila 
            if (a.isEmpty().Equals(false))// si en la a pila hay algun disco
            {
                if (b.isEmpty().Equals(true))//se observa tambien si en la pila b hay alguno
                { 
                   Disco disco = a.pop(); //lo quitamos de la pila a
                    b.push(disco);//y a continuacion lo ponemos en b
                }
                else //si no se da el caso anterior
                {
                    if (a.Top > b.Top) // si el ultimo disco de la pila a > ultimo disco de la pila b
                    {
                        Disco disco = b.pop();//se quita en b
                        a.push(disco);//se anyade en a
                    }
                    else
                    {
                       Disco disco = a.pop();//se quita de a
                        b.push(disco);//se pone en b
                    }
                }
            }
            else if (b.isEmpty().Equals(false))//en la pila b esta llena
            {
                if (a.isEmpty().Equals(true))//y en la pila a esta vacia
                {
                    Disco disco = b.pop(); //cambiamos de la pila b a la a el disco
                    a.push(disco); 
                }
                else//igual que en el caso anterior coprobamos si el disco de mas arriba es mayor al disco de a
                { 
                    if (b.Top > a.Top) 
                    {
                        Disco disco = a.pop();
                        b.push(disco);
                    }
                    else
                    {
                       Disco disco = b.pop();
                       a.push(disco);
                    }
                }
            }
        }

        //metodo iterativo
        public int iterativo(int x, Pila ini, Pila fin, Pila aux)
        {
           int cuantos = 0;//movimientos que realizaremos
            bool resFin;//variable para saber si se ha acabado
            resFin=false;//como esto no esta acabado se inicializa en false
            if (x%2 == 0)//si los discos son pares
            {
                while (resFin.Equals(false))//mientras no hay resultado n == numero de discos en fin
                {
                    
                    Console.WriteLine("Movimiento inicio a aux");
                    mover_disco(ini, aux);
                    cuantos++;//contamos un movimiento
                    
                    
                   
                    Console.WriteLine("Movimiento inicio a fin");
                    mover_disco(ini, fin);
                    cuantos++;//el siguiente movimiento

                    
                    Console.WriteLine("Movimiento aux a fin");
                    mover_disco(aux, fin);
                    cuantos++;//el tercer movimiento
                if (fin.Size.Equals(x))//al acabar todos los movimientos comprobamos si el tamanyo de fin es el tamanyo de los discos
                    {
                        resFin=true; 
                    }
                }
            }
            else//si el numero es impar
            {
                while (resFin.Equals(false))
                {     
                    cuantos++;
                    Console.WriteLine("Movimiento inicio a fin");
                    mover_disco(ini, fin);
                    //comprobamos si ya ha terminado porque es impar, para evitar bucles
                    if (fin.Size.Equals(x))
                    {
                       resFin=true; //si la ultima pila tiene el numero que hemos introducido
                        return cuantos;
                    }
                    //realizamos el resto de movimientos restantes
                    cuantos++;
                    Console.WriteLine("Movimiento inicio a aux");
                    mover_disco(ini, aux);

                    cuantos++;
                    Console.WriteLine("Movimiento aux a fin");
                    mover_disco(aux, fin);

                    if (fin.Size.Equals(x))
                    {
                       resFin=true; 
                        return cuantos;
                    }
                    //al realizar el tercer movimiento, comprobamos si ya esta el resultado

                }
                    
            }
            return cuantos; //devolvemos los movimientos realizados
        }

        //metodo recusivo
        public int cuantos=0;
        public int recursivo(int x, Pila ini, Pila fin, Pila aux)
        {
            
            if(x == 1)
            {
                cuantos++;
                mover_disco(ini, fin);
                return cuantos;
            }
            else
            {
                recursivo(x - 1, ini, aux, fin);
                cuantos++;
                mover_disco(ini, fin);
                recursivo(x - 1, aux, fin, ini);
            }
            return cuantos;
        }
    }
}
