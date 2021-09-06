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
    //Crea un array de números donde le indicamos por teclado el tamaño del array, rellenaremos el array con números aleatorios entre 0 y9, al final muestra por pantalla el valor de cada posición y la suma de todos los valores. Haz un método para rellenar el array (que tenga como parámetros los números entre los que tenga que generar), para mostrar el contenido y la suma del array y un método privado para generar número aleatorio.

    public class Ejercicio_3
    {
	    public static void Main(string[] args)
	    {
            string Longitud;
            int NumeroX;
            int NumeroY;
		
		    Console.WriteLine("Introduce un tamaño");
            Longitud = Console.ReadLine();
		    int[] num = new int[int.Parse(Longitud)];

            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero inicial y final para el intervalo de los numeros aleatorios primos");
            Console.WriteLine("Ingrese el numero inicial");
            NumeroX = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese el numero final");
            NumeroY = int.Parse(System.Console.ReadLine());

		    rellenarNumPrimosAleatorioArray(num, NumeroX, NumeroY);

		    mostrarArray(num);
		
		    int primoMayor = mayor(num);
		    Console.WriteLine("El primo más grande es el " + primoMayor);

            int PrimoMenor = menor(num);
            Console.WriteLine("El primo más pequeño es el " + PrimoMenor);
	    }

	    public static void rellenarNumPrimosAleatorioArray(int[] lista, int a, int b)
	    {
		    int i = 0;
		
		    while (i < lista.Length)
		    {
			    int num = ((int)Math.Floor(GlobalRandom.NextDouble * (a - b) + b));
			    if (esPrimo(num))
			    {
				    lista[i] = num;
				    i++;
			    }
		    }
	    }
	
        private static bool esPrimo(int num)
	    {
            if (num <= 1)
		    {
			    return false;
		    }

		    else
		    {		   
			    int prueba;
			    int contador = 0;
			
			    prueba = (int)Math.Sqrt(num);
			
			    for (;prueba > 1;prueba--)
			    {
				    if (num % prueba == 0)
				    {
					    contador += 1;
				    }
			    }
			    return contador < 1;
		    }
	    }

	    public static void mostrarArray(int[] lista)
	    {
		    for (int i = 0;i < lista.Length;i++)
		    {
			    Console.WriteLine("En la fila " + (i+1) + " esta el valor " + lista[i]);
		    }
	    }

	    public static int mayor(int[] lista)
	    {
		    int mayor = 0;
		    for (int i = 0;i < lista.Length;i++)
		    {
			    if (lista[i] > mayor)
			    {
				    mayor = lista[i];
			    }
		    }
		    return mayor;
	    }

        public static int menor(int[] lista)
	    {
		    int menor = 0;
		    for (int n = 0; n < lista.Length;n++)
		    {
			    if (lista[n] < menor )
			    {
				    menor = lista[n];
			    }
		    }
		    return menor;
	    }
    }

    internal static class GlobalRandom
    {
	    private static System.Random randomInstance = null;

	    public static double NextDouble
	    {
		    get
		    {
			    if (randomInstance == null)
				    randomInstance = new System.Random();

			    return randomInstance.NextDouble();
		    }
	    }
    }
}