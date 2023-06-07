using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase3
{
    internal class program
    {
        public static float[] notas = new float[3];
        public static string[] estudiantes = new string[3];
        public static string[] cursos = new string[3];

        public static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            string opcion = "";
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\tBienvenido al registo de notas UH digital\n");//MENU PRINCIPAL, en el cual el usuario puede decidir si ingresar, ver, modificar o eliminar un dato.
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A -> Ingresar notas");
                Console.WriteLine("B -> Consultar notas");
                Console.WriteLine("C -> Modificar notas");
                Console.WriteLine("D -> Reporte de notas");
                Console.WriteLine("E -> Borrar notas");
                Console.WriteLine("J -> Salir");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Opcion elegida: ");
                Console.ForegroundColor = ConsoleColor.White;
                opcion = Console.ReadLine().ToUpper();
                switch (opcion)
                {
                    case "A": ingresarNotas(); break;
                    case "B": consultarNotas(); break;
                    case "C": modificarNotas(); break;
                    case "D": reporteNotas(); break;
                    case "E": borrarNotas(); break;
                    case "J": Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\n\tHasta la proxima, UH te desea un excelente día =)"); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t -- ERROR 504 - Error de formato de datos --");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Se ha detectado un error en el valor ingresado, intentalo de nuevo :)");
                        break;

                }
                Console.ReadLine();
            } while (!opcion.Equals("J"));
        }
        public static void ingresarNotas() //Se solicitan 3 datos diferentes tales como: nombre, curso y nota.
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\tREGISTRAR DATOS ESTUDIANTES");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nIngrese su nombre: ");
                Console.ForegroundColor = ConsoleColor.White;
                estudiantes[i] = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingrese el nombre del curso: ");
                Console.ForegroundColor = ConsoleColor.White;
                cursos[i] = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingrese la nota obtenida: ");
                Console.ForegroundColor = ConsoleColor.White;
                notas[i] = float.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\t- - - - - - - - - - - - - -");
            }
        }
        public static void consultarNotas() //Se solicita un dato que funciona como "Key" para encontrar la informacion de ese usuario.
        {
            Console.Clear();
            String nombEstudiante = "";
            Boolean Existe = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nIngresar el nombre del estudiante: ");
            Console.ForegroundColor = ConsoleColor.White;
            nombEstudiante = Console.ReadLine().ToLower();

            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("- - - - - - - - - - - - - -");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   INFOMACION PERSONAL:\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Estudiante: {estudiantes[i]}"); Console.WriteLine($"Curso: {cursos[i]}"); Console.WriteLine($"La nota obtenida es: {notas[i]}");
                    Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n- - - - - - - - - - - - - -");
                    Existe = true;
                    break;
                }
            }
            if (Existe == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n\t   -- Advertencia --"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("\tEl estudiante no existe.");
            }
            Console.Read();
        }
        public static void modificarNotas() //Se solicita un dato que funciona como "Key" para encontrar la informacion de ese usuario.
        {
            Console.Clear();
            String nombEstudiante = "";
            Boolean Existe = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nIngrese el nombre del estudiante: ");
            nombEstudiante = Console.ReadLine().ToLower();

            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\tMODIFICAR INFORMACIÓN\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Actualice el nombre: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    estudiantes[i] = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Actualice el curso: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    cursos[i] = Console.ReadLine().ToUpper();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Actualice la nota: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    notas[i] = float.Parse(Console.ReadLine());
                    Existe = true;
                    break;
                }
            }
            if (Existe == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n\t   -- Advertencia --"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("\tEl estudiante no existe.");
            }
            Console.Read();
        }
        public static void reporteNotas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\t----------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t- - - REPORTE DE NOTAS - - -\n");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($" Nombre: {estudiantes[i]} | Curso: {cursos[i]} | Nota obtenida: {notas[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\n\t- - - FIN DEL REPORTE - - -");
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t----------------------------");
        }
        public static void borrarNotas()
        {
            Console.Clear();
            String buscarNombre = "";
            Console.ForegroundColor= ConsoleColor.Cyan; Console.Write("\nIngrese el nombre del estudiante: ");
            Console.ForegroundColor = ConsoleColor.White; buscarNombre = Console.ReadLine();
            for (int i = 0;i < estudiantes.Length;i++)
            {
                if (estudiantes[i] == buscarNombre)
                {
                    estudiantes[i] = "";
                    cursos[i] = "";
                    notas[i] = 0;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\n\t  ---------------------------------------");
                    Console.Write("\n\t  |");Console.Write("\t\t\t\t\t|");
                    Console.Write("\n\t  |"); Console.ForegroundColor = ConsoleColor.White; Console.Write("ESTUDIANTE ELIMINADO CORRECTAMENTE =)"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("|");
                    Console.Write("\n\t  |");Console.Write("\t\t\t\t\t|");
                    Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\n\t  ---------------------------------------");
                }
            }
        }
    }
}


 