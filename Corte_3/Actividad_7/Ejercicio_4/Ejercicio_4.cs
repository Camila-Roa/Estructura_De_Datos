﻿using System;
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
        63102C / 239-2A 
    */

namespace AplicacionBase
/*
        Escriba un programa que dadas dos lista/pila/cola ordenadas de números enteros, realice
        la concatenación en forma ordenada de ambas lista/pila/cola.
        */
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            Queue primerC = new Queue();

            primerC.Enqueue("1");
            primerC.Enqueue("2");
            primerC.Enqueue("3");
            primerC.Enqueue("4");
            primerC.Enqueue("5");

            Queue segundaC = new Queue();
            segundaC.Enqueue("6");
            segundaC.Enqueue("7");
            segundaC.Enqueue("8");
            segundaC.Enqueue("9");
            segundaC.Enqueue("10");

           Console.WriteLine("LOS VALORES DE LA PRIMERA COLA SON: ");


            foreach( string nums in primerC){
                Console.WriteLine($" {nums}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("================================================================");
          
          Console.WriteLine("LOS VALORES DE LA SEGUNDA COLA SON: ");
            foreach( string nums2 in segundaC){
                Console.WriteLine($" {nums2}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("================================================================");
          Console.WriteLine("LA CONCATENACION ES: ");
            foreach( string nums in primerC){
                Console.WriteLine($" {nums}");
            }
             foreach( string nums2 in segundaC){
                Console.WriteLine($" {nums2}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("================================================================");
    
        }
    }
}
