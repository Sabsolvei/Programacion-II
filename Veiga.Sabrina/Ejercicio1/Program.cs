using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int aux = 0;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            int promedio;
            Console.Title = "Ejercicio nro 1";
            for(int i= 0; i<5; i++)
            {
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(),out aux);
                if (i == 0)
                {
                    maximo = aux;
                    minimo = aux;
                }
                if (aux > maximo)
                {
                    maximo = aux;
                }
                if (aux < minimo)
                {
                    minimo = aux;
                }
                acumulador += aux;
            }
            Console.WriteLine("El numero maximo es: {0}", maximo);
            Console.WriteLine("El numero minimo es: {0}", minimo);
            Console.WriteLine("El numero promedio es: {0: #,#.00}", (float)acumulador/5);
            Console.ReadLine();
            */
            int h;
            int color = 0;
            Console.WriteLine("Ingrese altura: ");
            int.TryParse(Console.ReadLine(), out h);
            ConsoleColor miColor;
            for(int i=0; i<h; i++)
            {
                
                for (int j = 0; j<=i; j++)
                {

                    switch (color)
                    {
                        case 0:
                            color= 1
                            miColor = ConsoleColor.Blue;
                            break;

                        case 1:
                            color = 0
                            miColor = ConsoleColor.Red;
                            break;
                    }
                    Console.ForegroundColor = miColor;

                    Console.Write("* ");
                }
                
                Console.ReadLine();
            }

            

        }


    }
}


