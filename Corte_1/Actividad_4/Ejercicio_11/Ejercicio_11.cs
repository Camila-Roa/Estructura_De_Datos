using System;
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


namespace Ejercicio_11
/*Crea un programa que pida por pantalla cuatro países y a continuación tres ciudades de cada uno de estos países. 
Los nombres de ciudades deben almacenarse en un array multidimensional cuyo primer índice sea el número asignado a cada país y el segundo índice el número asignado a cada ciudad.
 Ejemplo de resultados que debe mostrar el programa:
   País: Argentina Ciudades: Buenos Aires Cordoba La Plata
   País: España    Ciudades: Madrid       Lugo    Sevilla
   País: Francia   Ciudades: Paris        Niza    Lyon
   País: Italia    Ciudades: Roma         Napoles Sicilia
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] Paises = new string [4];
            string [] Pais1 = new string [3];
            string [] Pais2 = new string [3];
            string [] Pais3 = new string [3];
            string [] Pais4 = new string [3];
           
            for(int i = 0; i < Paises.Length;i++ )
            {
                Console.WriteLine($"Ingrese el nombre del país {i+1}:");
                Paises[i] = Console.ReadLine();
            }

            for(int i = 0; i < Pais1.Length;i++)
            {
                Console.WriteLine($"Ingrese la ciudad {i+1} del {Paises[0]}");
                Pais1[i] = Console.ReadLine();
            }
            for(int i = 0; i < Pais2.Length;i++)
            {
                Console.WriteLine($"Ingrese la ciudad {i+1} del {Paises[1]}");
                Pais2[i] = Console.ReadLine();
            }

            for(int i = 0; i < Pais3.Length;i++)
            {
                Console.WriteLine($"Ingrese la ciudad {i+1} del {Paises[2]}");
                Pais3[i] = Console.ReadLine();
            }
            for(int i = 0; i < Pais4.Length;i++)
            {
                Console.WriteLine($"Ingrese la ciudad {i+1} del {Paises[3]}");
                Pais4[i] = Console.ReadLine();
            }

            Console.WriteLine($"\nPaís: {Paises[0]}   Ciudades: {Pais1[0]}    {Pais1[1]}    {Pais1[2]}");
            Console.WriteLine($"\nPaís: {Paises[1]}   Ciudades: {Pais2[0]}    {Pais2[1]}    {Pais2[2]}");
            Console.WriteLine($"\nPaís: {Paises[2]}   Ciudades: {Pais3[0]}    {Pais3[1]}    {Pais3[2]}");
            Console.WriteLine($"\nPaís: {Paises[3]}   Ciudades: {Pais1[0]}    {Pais4[1]}    {Pais4[2]}");
            
            
           
        }
    }
}

