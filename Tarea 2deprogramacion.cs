using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea 2
{
    internal class Program
    {
        public static float[] notas = new float[3];
        public static string[] estudiantes = new string[3];
        static void Main(string[] args)  
        {
            menu();
        }

        private static void menu()
        {
            string op = "";
            do
            {
                Console.Clear();
                Console.WriteLine("a-Ingresar notas");
                Console.WriteLine("b-Consultar notas");
                Console.WriteLine("c-modificar notas");
                Console.WriteLine("d-Reporte");
                Console.WriteLine("e-agregar notas");
                Console.WriteLine("f-Borrar notas");
                Console.WriteLine("g-imprimir notas");
                Console.WriteLine("h-inicializar arreglos");
                Console.WriteLine("i-Salir");
                Console.Write("Digite una opcion: "); 
                
                op = Console.ReadLine().ToLower();
                switch (op)
                {
                    case "a": Ingresarnotas(); break;
                    case "b": Consulta(); break;
                    case "c": Modificar(); break;
                    case "d": Reporte(); break;
                    case "e": Agregar(); break;
                    case "f": Borrar(); break;
                    case "g": Imprimir(); break;
                    case "h" inicializar arreglos(); break;
                    case "i": break;
                    default:
                        Console.WriteLine("Opcion no es valida!!");
                        break;
                }
            } while (!op.Equals("e"));
        }

        public static void Reporte()
        {
            Console.Clear();
            Console.WriteLine("********** Reporte de Estudiantes*************");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Nombre: {estudiantes[i]} Nota: {notas[i]}");
            }
            Console.WriteLine("********** Fin del reporte*************");
            Console.ReadLine();
        }

        public static void Modificar()
        {
            String nombEstudiante = "";
            Boolean Existe = false;
            Console.WriteLine("Digite un nombre de estudiante");
            nombEstudiante = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                {
                    Console.Clear();
                    Console.Write("Actualice el nombre:");
                    estudiantes[i] = Console.ReadLine();
                    Console.Write("Actualice la nota :");
                    notas[i] = float.Parse(Console.ReadLine());
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Estudiante no existe");
            }
        }

            public static void Consulta()
        {
            String nombEstudiante = "";
            Boolean Existe = false;
            Console.WriteLine("Digite un nombre de estudiante");
            nombEstudiante= Console.ReadLine();
            
            for (int i = 0; i < 3; i++)
            {
                if (estudiantes[i].Equals(nombEstudiante))
                { 
                    Console.Clear();
                    
                    Console.WriteLine("La nota de estudiante es: " + notas[i]);
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Estudiante no existe");
            }

            Console.Read();

        }
        public static void Ingresarnotas()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite el nombre:");
                estudiantes[i] = Console.ReadLine();
                Console.Write("Digite la nota :");
                notas[i] = float.Parse(Console.ReadLine());


                public static void Agregar()
                {
                    String nombEstudiante = "";
                    Boolean Existe = false;
                    Console.WriteLine("ingrese el nombre del estudiante");
                    nombEstudiante = Console.ReadLine();

                    for (int i = 0; i < 3; i++)
                    {
                        if (estudiantes[i].Equals(nombEstudiante))
                        {
                            Console.Clear();
                            Console.Write("agregado el nombre:");
                            estudiantes[i] = Console.ReadLine();
                            Console.Write("agregada y actualizada la nota :");
                            notas[i] = float.Parse(Console.ReadLine());
                            Existe = true;
                            break;
                        }

                    }

                    if (Existe == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Fallo al ingresar el nombre del estudiante");

                        public static void Borrar()
                        {
                            String nombEstudiante = "";
                            Boolean Existe = false;
                            Console.WriteLine("Digite el nombre del estudiante a borrar");
                            nombEstudiante = Console.ReadLine();

                            for (int i = 0; i < 3; i++)
                            {
                                if (estudiantes[i].Equals(nombEstudiante))
                                {
                                    Console.Clear();
                                    Console.Write("escriba el nombre a borrar:");
                                    estudiantes[i] = Console.ReadLine();
                                    Console.Write("¿esta seguro/a en borrar el nombre? :");
                                    notas[i] = float.Parse(Console.ReadLine());
                                    Existe = true;
                                    break;
                                }

                            }

                            if (Existe == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Error al borrar nombre");

                                public static void Imprimir()
                                {
                                    String nombarchivo = "";
                                    Boolean Existe = false;
                                    Console.WriteLine("seleccione el archivo que desea imprimir");
                                    nombEstudiante = Console.ReadLine();

                                    for (int i = 0; i < 3; i++)
                                    {
                                        if (estudiantes[i].Equals(nombarchivo))
                                        {
                                            Console.Clear();
                                            Console.Write("por favor seleccione la opcion Imprimir:");
                                            estudiantes[i] = Console.ReadLine();
                                            Console.Write("Imprimiendo archivo :");
                                            notas[i] = float.Parse(Console.ReadLine());
                                            Existe = true;
                                            break;
                                        }

                                    }

                                    if (Existe == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Archivo no encontrado");

                                        public static void InicializarArreglos()
                                        {
                                            String nombArchivo = "";
                                            Boolean Existe = false;
                                            Console.WriteLine("seleccione el archivo a restaurar");
                                            nombEstudiante = Console.ReadLine();

                                            for (int i = 0; i < 3; i++)
                                            {
                                                if (estudiantes[i].Equals(nombArchivo))
                                                {
                                                    Console.Clear();
                                                    Console.Write("¿este es el archivo que desea arreglar?:");
                                                    estudiantes[i] = Console.ReadLine();
                                                    Console.Write("Actualizado el archivo :");
                                                    notas[i] = float.Parse(Console.ReadLine());
                                                    Existe = true;
                                                    break;
                                                }

                                            }

                                            if (Existe == false)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("no se pudo restaurar o arreglar el archivo");
                                                                                 
                                            
                                           }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
    }
}
