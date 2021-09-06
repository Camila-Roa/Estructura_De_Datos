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
    //Crea un array de caracteres que contenga de la ‘A’ a la ‘Z’ (solo las mayúsculas). Después, ve pidiendo posiciones del array por teclado y si la posicion es correcta, se añadira a una cadena que se mostrara al final, se dejará de insertar cuando se introduzca un -1.Por ejemplo, si escribo los siguientes numeros0 //Añadira la ‘A’5 //Añadira la ‘F’25 //Añadira la ‘Z’50 //Error, inserteotro numero-1 //finCadena resultante: AFZ

    class Ejercicio_5
    {
        static void Main(string[] args)
        {
          
          int num1 = 0;
          int num2 = 0;         
          Console.WriteLine("Bienvenido al programa!");
          Console.WriteLine("Por favor ingrese la cantidad de letras que desea ingresar:");
          num2 = Convert.ToInt32(Console.ReadLine());
          for(int j = 0; j< num2; j++){

          
          char[] Abecedario;
          Abecedario = new char [27];
          Abecedario[0] = 'A';
          Abecedario[1] = 'B';
          Abecedario[2] = 'C';
          Abecedario[3] = 'D';
          Abecedario[4] = 'E';
          Abecedario[5] = 'F';
          Abecedario[6] = 'G';
          Abecedario[7] = 'H';
          Abecedario[8] = 'I';
          Abecedario[9] = 'J';
          Abecedario[10] = 'K';
          Abecedario[11] = 'L';
          Abecedario[12] = 'M';
          Abecedario[13] = 'N';
          Abecedario[14] = 'Ñ';
          Abecedario[15] = 'O';
          Abecedario[16] = 'P';
          Abecedario[17] = 'Q';
          Abecedario[18] = 'R';
          Abecedario[19] = 'S';
          Abecedario[20] = 'T';
          Abecedario[21] = 'U';
          Abecedario[22] = 'V';
          Abecedario[23] = 'W';
          Abecedario[24] = 'X';
          Abecedario[25] = 'Y';
          Abecedario[26] = 'Z';

        
          if( num1 < 26){
          Console.WriteLine("Por favor ingrese un numero para asi mostrar la letra correspondiente.");
          num1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Su letra es: "+Abecedario[num1]);
          Console.WriteLine("==========================================================================================");
           }
          }

        }
    }
}