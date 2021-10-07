using System;
using System.Collections;
using System.Collections.Generic;
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
    class Ejercicio_9
    {
        static void Main(string[] args)
        {
            
            ArrayList Pila = new ArrayList();
            int Tamaño1;
            Console.WriteLine("Por favor ingrese el rango de la pila: ");
            Tamaño1 = int.Parse(Console.ReadLine());
            Console.WriteLine("========================================");
            Console.WriteLine("SU PILA ES: ");

            Random Aleatorios1 = new Random();
            for(int j = 0; j < Tamaño1; j++)
            {
                Pila.Add(Aleatorios1.Next(1,100));
            }
          imprime(Pila);

           ArrayList Pila2 = new ArrayList();
           Console.WriteLine("SU COPIA DE SU PILA ES LA SIGUIENTE: ");

           Pila2 = Pila;
           imprime(Pila2);
        }
        static void imprime (ArrayList arreglo){
            foreach(int nums in arreglo)
            {
             Console.Write($"[{nums}]");
            }
            Console.WriteLine("\n==============");
        }    
    }
}
