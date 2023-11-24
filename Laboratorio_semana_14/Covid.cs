using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_semana_14
{
    internal class Covid
    {
        private const int PersonasMaximo = 100;
        private int[] edades = new int[PersonasMaximo];
        private bool[] vacunados = new bool[PersonasMaximo];
        private int PersonasTotal = 0;

        public void RealizarEncuesta()
        {
            Console.Clear();
            MostrarEncabezado("Realizar Encuesta");

            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("¿Está vacunado? (Sí/No): ");
            bool vacunado = Console.ReadLine().Trim().Equals("Sí", StringComparison.OrdinalIgnoreCase);

            edades[PersonasTotal] = edad;
            vacunados[PersonasTotal] = vacunado;
            PersonasTotal++;

            Console.Clear();
            MostrarEncabezado("¡Encuesta realizada!");
            MostrarMensaje("Presione una tecla para regresar al menú ...");
            Console.ReadKey();
        }

        public void MostrarDTS()
        {
            Console.Clear();
            MostrarEncabezado("Datos de la Encuesta");
            MostrarEncabezado("ID | Edad | Vacunado");

            for (int i = 0; i < PersonasTotal; i++)
            {
                Console.WriteLine($"{i:D4} | {edades[i]:D2} | {(vacunados[i] ? "Sí" : "No")}");
            }

            MostrarMensaje("\nPresione una tecla para regresar ...");
            Console.ReadKey();
        }

        public void MostrarRSTD()
        {
            Console.Clear();
            MostrarEncabezado("Resultados de la Encuesta");

            int vacunadosCount = ContarVacunados();
            int noVacunadosCount = PersonasTotal - vacunadosCount;

            MostrarMensaje($"{vacunadosCount:D2} personas se han vacunado");
            MostrarMensaje($"{noVacunadosCount:D2} personas no se han vacunado");

            MostrarMensaje("Existen:");
            MostrarEdadesConteo(1, 20);
            MostrarEdadesConteo(21, 30);
            MostrarEdadesConteo(31, 40);
            MostrarEdadesConteo(41, 50);
            MostrarEdadesConteo(51, 60);
            MostrarEdadesConteo(61, int.MaxValue);

            MostrarMensaje("\nPresione una tecla para regresar ...");
            Console.ReadKey();
        }

        public void PersPorEdad()
        {
            Console.Clear();
            MostrarEncabezado("Buscar Personas por Edad");

            Console.Write("¿Qué edad quieres buscar?: ");
            int edadBuscada = int.Parse(Console.ReadLine());

            int vacunadosEdad = 0;
            int noVacunadosEdad = 0;

            for (int i = 0; i < PersonasTotal; i++)
            {
                if (edades[i] == edadBuscada)
                {
                    if (vacunados[i])
                        vacunadosEdad++;
                    else
                        noVacunadosEdad++;
                }
            }

            Console.WriteLine($"{vacunadosEdad:D2} se vacunaron");
            Console.WriteLine($"{noVacunadosEdad:D2} no se vacunaron");

            MostrarMensaje("\nPresione una tecla para regresar ...");
            Console.ReadKey();
        }

        private int ContarVacunados()
        {
            int contador = 0;
            for (int i = 0; i < PersonasTotal; i++)
            {
                if (vacunados[i])
                {
                    contador++;
                }
            }
            return contador;
        }

        private void MostrarEdadesConteo(int edadInicio, int edadFin)
        {
            int conteo = 0;
            for (int i = 0; i < PersonasTotal; i++)
            {
                if (edades[i] >= edadInicio && edades[i] <= edadFin)
                {
                    conteo++;
                }
            }
            Console.WriteLine($"{conteo:D2} personas entre {edadInicio:D2} y {edadFin:D2} años");
        }

        private static void MostrarEncabezado(string titulo)
        {
            Console.WriteLine("===============================");
            Console.WriteLine($"Encuesta Covid-19 - {titulo}");
            Console.WriteLine("===============================");
        }

        private static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

}
