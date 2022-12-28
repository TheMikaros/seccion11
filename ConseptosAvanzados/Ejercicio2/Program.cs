using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primero creamnos variables del tipo de clase generica, con el valor entre <> del
            //tipo que queremos
            ClaseGenerica<int> miClaseInt = new ClaseGenerica<int>();
            ClaseGenerica<string> miClaseString = new ClaseGenerica<string>();

            //agregamos elementos int
            miClaseInt.Agregar(1);
            miClaseInt.Agregar(2);
            miClaseInt.Agregar(3);
            //agregamos elementos string
            miClaseString.Agregar("Hola");
            miClaseString.Agregar("Mundo");

            //recorremos la clase generica int
            foreach (int valor in miClaseInt.listado)
            {
                Console.WriteLine(valor);
            }


            Console.ReadLine();
        }

        class ClaseGenerica<T>
        {
            public List<T> listado;

            public ClaseGenerica()
            {
                listado = new List<T>(); 
            }

            public void Agregar(T valor)
            {
                listado.Add(valor);
            }
        }
    }
}
