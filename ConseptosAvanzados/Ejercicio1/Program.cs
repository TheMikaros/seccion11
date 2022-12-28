using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Crea un programa que use un diccionario, clave entera y valor string.
            //Se pedirá por consola, un numero y un a cadena, que se ira insertando en
            //el diccionario, hasta que se introduzca el valor "0". una vez se pulse "0"
            //, se pedirá por pantalla que se introduzca una cadena de 2 letras.  se
            // mostrara consultando el diccionario, todas las claves que contienen esos
            //2 caracteres en los valores del diccionario.

            Dictionary<int, string> diccionario = new Dictionary<int, string>();
           
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una cadena:");
            string cadena = Console.ReadLine();

            diccionario.Add(numero, cadena);


            while (numero != 0)
            {
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }

                Console.WriteLine("Ingrese una cadena:");
                cadena = Console.ReadLine();

                diccionario.Add(numero, cadena);
            }

            Console.WriteLine("Ingrese una cadena de 2 caracteres:");
            string cadenaABuscar = Console.ReadLine();

            var clavesConCadena = diccionario.Where(kvp => kvp.Value.Contains(cadenaABuscar)).Select(kvp => kvp.Key);

            foreach (int clave in clavesConCadena)
            {
                Console.WriteLine(clave);
            }

            Console.ReadLine();

        }
    }
}
