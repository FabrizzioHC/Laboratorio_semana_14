using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_semana_14
{
    internal class Program
    {
        static void Main()
        {
            Covid encuesta = new Covid();
            int opcion;

            do
            {
                Console.Clear();
                MostrarEncabezado("Encuesta Covid-19");
                Console.WriteLine("1: Realizar Encuesta\n2: Mostrar Datos de la Encuesta\n3: Mostrar Resultados\n4: Buscar Personas por Edad\n5: Salir");
                Console.WriteLine("===============================");
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        encuesta.RealizarEncuesta();
                        break;
                    case 2:
                        encuesta.MostrarDTS();
                        break;
                    case 3:
                        encuesta.MostrarRSTD();
                        break;
                    case 4:
                        encuesta.PersPorEdad();
                        break;
                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        Console.WriteLine("Presione una tecla para regresar al menú ...");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 5);
        }

        private static void MostrarEncabezado(string titulo)
        {
            Console.WriteLine("===============================");
            Console.WriteLine(titulo);
            Console.WriteLine("===============================");
        }
    }
}
