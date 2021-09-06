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

namespace AplicacionBase
{
    //Crea un array de 15 posiciones de números con valores pedidos por teclado. Muestra por consola el indicéy el valor al que corresponde, al final en cada posición debe realizar la multiplicación división de un número que pida por teclado. Haz dos métodos, uno para rellenar valores y otro para mostrar
    class Ejercicio_1
    {

      private int[] numeros;
       int numeros2 = 0;

        public void Captura(){
            numeros = new int[15];
           
            for( int f = 0; f < 15; f++){
              Console.WriteLine($"Por favor ingrese el numero  {f+1}"); 
              numeros[f]= int.Parse(Console.ReadLine());
            }
           Console.WriteLine("Por favor ingrese el numero con el que se haran las operaciones");
           numeros2 = int.Parse(Console.ReadLine()); 
        }

        public void Multiplicacion()
        {
            float division = 0.0f;
            for(int k = 0; k < 15; k++){
            division = numeros[k]/numeros2;
            Console.WriteLine($"El indice es: {k+1} su valor es: {numeros[k]} -> La multiplicacion por {numeros2} es: {numeros[k] * numeros2}");  
            Console.WriteLine($"El indice es: {k+1} su valor es: {numeros[k]} -> La division por {numeros2} es: {division}");
         }
        }
        


        static void Main(string[] args)
        {
            Ejercicio_1 pv = new Ejercicio_1();
            pv.Captura();
            pv.Multiplicacion();
        }
    }
}