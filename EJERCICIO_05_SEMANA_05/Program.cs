using System;
using System.Collections.Generic;

namespace EJERCICIO_05_SEMANA_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer una lista
            List<int> numeros = new List<int>();
            
            // meter los numeros del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }
            
            // voltear la lista
            numeros.Reverse();
            
            // imprimir separado por comas
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.Write(numeros[i]);
                if (i < numeros.Count - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}

