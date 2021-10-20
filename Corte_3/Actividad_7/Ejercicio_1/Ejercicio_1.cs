using System;
using System.Collections;

/*
    GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
    
    SHIFT
        diurnal

    GROUP
        63102C / 239-2A */

namespace AplicacionBase
{
/*Escriba un programa que inserte valores ordenadamente en una lista. La lista/pila/cola debe almacenar números enteros. El programa debe leer una secuencia de números
enteros de la entrada hasta que se ingrese el número cero.*/
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            Queue Cola = new Queue();
            int Salir = 0;
            do 
            {
                Console.WriteLine("Ingrese los numeros a la cola y ingrese 0 para salir");

                int NumCola = int.Parse(Console.ReadLine());

                if (NumCola == 0)
                {
                    Salir = 100;
                }

                else
                {
                    Cola.Enqueue(NumCola);
                }
            } while (Salir != 100);

            //Console.WriteLine();

            Console.WriteLine("");
            Console.WriteLine("La cola tiene {0} elemento(s)", Cola.Count);

            foreach (int n in Cola)
            {
                Console.WriteLine($"--  {n}  --");
                Console.WriteLine("---------");
                Console.WriteLine("");
            }
        }
    }
}
