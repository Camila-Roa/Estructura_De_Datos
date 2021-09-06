﻿using System;
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
	//Crea un array de números y otro de textode 12posiciones donde insertaremos notas entre 0 y 10 (debemos controlar que inserte una nota valida), pudiendo ser decimal la nota en el array de números, en el de textose insertaran los nombres de los alumnos.Después, crearemos un array de String donde insertaremosel resultado de la nota con palabras.
	//Si la nota esta entre 0 y 4,99 , es insuficiente.
	//Si esta entre 5 y 6,99 , sera un aceptable.
	//Si esta entre 7 y 8,99 sera un sobresaliente.
	//Si esta entre 9 y 10 sera un excelente.
	//Muestra por pantalla, el alumno su nota y su resultado en palabras. Crea los métodos que creas conveniente.
    public class Ejercicio_7
    {

	    public static void Main(string[] args)
	    {
		    const int Longitud = 12;

		    string[] Nombres = new string[Longitud];
		    double[] Notas = new double[Longitud];

		    RellenarArrays(Notas, Nombres);

		    string[] resultado = MostrarDatos(Notas);

		    mostrarArrays(Nombres, Notas, resultado);
	    }

	    public static void RellenarArrays(double[] Notas, string[] Nombres)
	    {
		    for (int i = 0;i < Notas.Length;i++)
		    {
			    Console.WriteLine("Introduce el nombre del alaumno " + (i + 1));
                Nombres[i] = Console.ReadLine();

			    double nota;

			    do
			    {
				    Console.WriteLine("Introduce una nota del alumno " + (i + 1));
                    string texto = Console.ReadLine();

				    nota = double.Parse(texto);
				    Console.WriteLine(nota <= 0 || nota >= 10);
			    }while (nota <= 0 || nota >= 10);

			    Notas[i] = nota;
		    }
	    }

	    public static void mostrarArrays(string[] Nombres, double[] Notas, string[] resultado)
	    {
		    for (int i = 0;i < Nombres.Length;i++)
		    {
			    Console.WriteLine("El alumno " + Nombres[i] + " tiene una nota de " + Notas[i] + ", por lo que su resultado es " + resultado[i]);
		    }
	    }

	    public static string[] MostrarDatos(double[] Notas)
	    {

		    string[] resultado = new string[Notas.Length];
		    for (int i = 0;i < Notas.Length;i++)
		    {
			    switch ((int)Notas[i])
			    {
				    case 1:
				    case 2:
				    case 3:
				    case 4:
					    resultado[i] = "INEFICIENTE";
					    break;
				    case 5:
				    case 6:
					    resultado[i] = "ACEPTABLE";
					    break;
				    case 7:
				    case 8:
					    resultado[i] = "SOBRESALIENTE";
					    break;
				    case 9:
				    case 10:
					    resultado[i] = "EXCELENTE";
					    break;
			    }
		    }
		    return resultado;
	    }
    }
}