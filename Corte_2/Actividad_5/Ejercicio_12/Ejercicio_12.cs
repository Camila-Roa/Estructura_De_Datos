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
    class Ejercicio_12
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] matriz= {0,0,0,0,0,0,0,0,0,0,0,0};
            int n=1, aux;
            for(int k=0;k<12;k++)
            {
                if(k!=n-1)
                {
                    matriz[k] =random.Next(1,4);
                }
            }
            Console.WriteLine("matriz inicial");
            for(int k=0;k<12;k++)
            {
                Console.Write(" | " +matriz[k]+ " | ");
            }
            if(n!=5)
            {
                for(int i=n-1;i<12-1;i++)
                {
                    aux = matriz[i];
                    matriz[i] = matriz[i+1];
                    matriz[i+1] = aux;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("matriz final");
            for(int k=0;k<12;k++)
            {
                Console.Write(" | " +matriz[k]+ " | ");
            }
        }
    }
}
