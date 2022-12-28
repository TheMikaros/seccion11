using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJercicio3
{
    internal class Program
    {
        enum animales
        {
            perro = 5,
            gato = 8,
            canario = 2,
            caballo = 12
        }
        static void Main(string[] args)
        {

            // En el método principal del programa, solicitamos un número por consola
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());

            // Creamos una instancia de la clase "Animal" y le asignamos el valor del enumerado correspondiente al número introducido
            Animal a = new Animal();
            a.tipo = (animales)numero;

            // Comprobamos si el número introducido coincide con algún valor del enumerado y mostramos el nombre del animal correspondiente
            if (a.tipo == animales.perro) Console.WriteLine("Ese valor pertenece al perro");
            else if (a.tipo == animales.gato) Console.WriteLine("Ese valor pertenece al gato");
            else if (a.tipo == animales.canario) Console.WriteLine("Ese valor pertenece al canario");
            else if (a.tipo == animales.caballo) Console.WriteLine("Ese valor pertenece al caballo");
            else Console.WriteLine("Ese valor no pertenece a ningún animal del enumerado");

            Console.ReadLine();
        }

        class Animal
        {
            public animales tipo { get; set; }
        }

    }
}
