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
    class Ejercicio_4
    {
        
        static void Main(string[] args)
        {
          Console.WriteLine("======================================================");
          Console.WriteLine("ESTA ES SU PRIMERA LISTA:");
           ArrayList Listnum1 = new ArrayList();
           Listnum1.Add(11);
           Listnum1.Add(13);
           Listnum1.Add(15);
           Listnum1.Add(17);
           Listnum1.Add(19);

           imprime(Listnum1);

          Console.WriteLine("ESTA ES SU SEGUNDA LISTA:");
           ArrayList Listnum2 = new ArrayList();
           Listnum2.Add(12);
           Listnum2.Add(14);
           Listnum2.Add(16);
           Listnum2.Add(18);
           Listnum2.Add(20);

           imprime(Listnum2);

           Console.WriteLine("=====================================================");
           Console.WriteLine("LA CONCATENACION DE AMBAS LISTAS ES: ");
           Listnum1.AddRange(Listnum2);
           imprime(Listnum1);

        }
        static void imprime (ArrayList arreglo){
            foreach(int nums in arreglo)
            {
             Console.Write(" {0} ", nums);
             Console.WriteLine("\n=====================================================");
            }
        }
    }
}
