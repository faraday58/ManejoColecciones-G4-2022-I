using System;
using System.Collections;

namespace ManejoColecciones_G4_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cadenasNumeros = new ArrayList();

            cadenasNumeros.Add("Uno");
            cadenasNumeros.Add("Dos");
            cadenasNumeros.Add("Tres");
            Console.WriteLine("Capacity = {0}", cadenasNumeros.Capacity);
            for (int i=0;i < cadenasNumeros.Count; i++)
            {
                Console.WriteLine("La posición del objeto 'Dos' es: {0}", cadenasNumeros.IndexOf("Dos"));
                Console.WriteLine(" {0} ", cadenasNumeros[i]);
            }

            cadenasNumeros.Remove("Dos");
            Console.WriteLine("Objeto 'Dos' fue eliminado");

            for (int i = 0; i < cadenasNumeros.Count; i++)
            {
                Console.WriteLine(" {0} ", cadenasNumeros[i]);
            }
            Console.WriteLine("Count = {0}", cadenasNumeros.Count);
            Console.WriteLine("Capacity = {0}", cadenasNumeros.Capacity);

            cadenasNumeros.Add(5);
            cadenasNumeros.Add(6);
        
            for (int i = 0; i < cadenasNumeros.Count; i++)
            {
                if( i> 1  )
                {
                    int suma= (int)cadenasNumeros[i] + 2;
                    Console.WriteLine(" {0} ", suma);
                }
                

                
            }


            Console.ReadLine();


        }
    }
}
