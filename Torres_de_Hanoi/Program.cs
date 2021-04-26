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
           /*  //prueba de funcionamiento clase pila
            Disco hola = new Disco(1);
            Disco holat = new Disco(2);
            Pila pila = new Pila();
            pila.push(holat);
            pila.push(hola);
            pila.pop();
            Console.WriteLine("coprov si funciona, dime tamanyo "+pila.Size.ToString());
           //----------------------

           //prueba funcionamiento pila con la clase hanoi (mover_disco())
            Pila pilas = new Pila();
            Hanoi hanoi = new Hanoi();
            hanoi.mover_disco(pila,pilas);
            Console.WriteLine("tam pila primera"+pila.Size.ToString());
            Console.WriteLine("tam pila segunda"+pilas.Size.ToString());*/
            //---------------------------
            //prueba de funcionamiento iterativo()
           
            Hanoi iter = new Hanoi();//definimos el método iterativo
            Pila pila1 = new Pila();// las pilas
            Pila pila2 = new Pila();
            Pila pila3 = new Pila();
            Console.WriteLine("Introduzca el numero de discos para iterativo");
            int x = Convert.ToInt32(Console.ReadLine());//pedimos el numero de discos
            while(x <= 0)//comprobamos si hay un numero mayor a 0
            {
                 Console.WriteLine("Introduce un numero mayor a 0");
                 x = Convert.ToInt32(Console.ReadLine());//pedimos el numero de discos   
            }
            
                for (int i=x;i>0;i--)//introduciomos los discos en la pila ordenandolos del disco más grande al pequenyo en la pila
                {
                    pila1.push(new Disco(i));
                }

                int res = iter.iterativo(x,pila1,pila2,pila3);  
               Console.WriteLine(res.ToString());

            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            // probamos el reiterativo
            Hanoi reiter = new Hanoi();//definimos el método reiterativo
            Pila pila4 = new Pila();// las pilas
            Pila pila5 = new Pila();
            Pila pila6 = new Pila();
           
            Console.WriteLine("Introduzca el numero de discos para reiterativo");
            int y = Convert.ToInt32(Console.ReadLine());//pedimos el numero de discos
             while(y <= 0)//comprobamos si hay un numero mayor a 0
             {
                 Console.WriteLine("Introduce un numero mayor a 0");
                 y = Convert.ToInt32(Console.ReadLine());//pedimos el numero de discos   
             }

             for (int i=y;i>0;i--)//introduciomos los discos en la pila ordenandolos del disco más grande al pequenyo en la pila
              {
                    pila4.push(new Disco(i));
              }
            
            int resiter = iter.iterativo(y,pila4,pila5,pila6);  
               Console.WriteLine(resiter.ToString());
             

            
           // Keep the console window open in debug mode.
            
            Console.ReadKey();
        }
    }
}
