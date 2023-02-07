using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosyProcedimientos
{
    internal class Datos
    {
        static float[] notas = new float[3];
        static byte i = 0; // Para la posición del arreglo
        static string[] nombre = new string[3];
        public static void menu()
        {
            byte opcion = 0;
            do
            {
                Console.WriteLine("1 - Agregar Estudiantes");
                Console.WriteLine("2 - Buscar Estudiantes");
                Console.WriteLine("3 - Agregar notas");
                Console.WriteLine("4 - Imprimir los datos del estudiante");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("Digite una opcion:");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEstudiantes();
                        break;
                    case 2:
                        BuscarEstudiantes();
                        break;
                    case 3:
                        Notas();
                        break;
                    case 4:
                        ImprimirDatos();    
                        break;  
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
            } while (opcion != 5); //false opcion == 4

        }

        static void CrearEstudiantes()
        {

            string continuar = "s";

            do
            {
                Console.Clear();
                Console.WriteLine("Digite el nombre");
                nombre[i] = Console.ReadLine();
                i++;
                Console.WriteLine("Desea continuar (s/n):");
                continuar = Console.ReadLine();

                if (i == 3)
                {
                    break;

                }

            } while (!continuar.Equals("n"));

            Console.Clear();
    
        }

        static void BuscarEstudiantes()
        {
            Console.Clear();
            Console.WriteLine("Digite el nombre del estudiante que desea buscar:");
            string nombre = Console.ReadLine();
            Boolean res = false;

            for (int i = 0; i < Datos.nombre.Length; i++)
            {
                if (nombre.Equals(Datos.nombre[i]))
                {
                    Console.WriteLine($"Estudiante registrado en el espacio [{i}]");
                    res = true;
                }
            }
            if (res == false)
            {
                Console.WriteLine("Estudiante no se encuentra registrado.");
            }
            Console.ReadLine();
        }

        static void Notas()
        {

            string continuar = "s";

            do
            {
               

                for (int i = 0; i < 3; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Digite la nota del estudiante en la posicion [{i}]");
                    notas[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Desea continuar (s/n):");
                    continuar = Console.ReadLine();

                    if (i == 2)
                    {
                   
                        continuar = "n";
                        break;

                    }

                }

            } while (!continuar.Equals("n"));

            Console.Clear();;
        }

        static void ImprimirDatos()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                if (nombre[i] == null)
                {
                    Console.WriteLine("Este espacio no tiene estudiante asignado");
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write($"Nombre: {nombre[i]}  Nota: {notas[i]}");
                    Console.WriteLine("");
                }

            }

        }
    }
}
    

