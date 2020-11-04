//Progrma base de menu 
// muy parecido al programa de Visual basic que hay en el github 
// creado por mi y que esta ahi
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuCSharpVisualStudio2019
{
    class Program
    {

        static void Main(string[] args)
        {// incio de l programa
            Menu();

        }

        private static void Menu()
        {
            Marco();// va la marco
                    // el menu en si. Presentacion de opcines
            Console.SetCursorPosition(20, 5);
            Console.Write(" MenuCharpVisualStudio2019");
            Console.SetCursorPosition(10, 7);
            Console.Write("0- salir");
            Console.SetCursorPosition(10, 9);
            Console.Write("1- opcoin ");




            Console.SetCursorPosition(10, 20);
            Console.Write("Que opcion eleiges: ");

            int opcion;
            opcion = Eleccion();
        }

        private static int Eleccion()
        {
            int opcion = Convert.ToInt32(Console.ReadLine());
            try
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        // opcion salida
                        Salida(opcion);
                        break;
                    case 1:
                        // opcion primaria
                        Borrado();
                        Marco();

                        Console.SetCursorPosition(10, 7);
                        Console.Write(" La oopcion  elegida:" + opcion);


                        break;

                    case 2:
                        //opcion segundaria
                        Console.SetCursorPosition(10, 5);
                        Console.Write("La opcion elegida es: " + opcion);

                        break;
                    case 3:
                        // opcion tercera
                        Console.SetCursorPosition(10, 5);
                        Console.Write("La opcion elegida es: " + opcion);


                        break;

                    default:

                        Borrado();
                        Marco();


                        Console.SetCursorPosition(10, 5);
                        Console.Write("La opcion elegida es: " + opcion + " no es reconocida por la aplicación");

                        break;

                }
            }
            catch
            {
                Console.SetCursorPosition(10, 19);
                Console.Write("Fallo; pulse cual quier tecla para salir del programa");
                Console.ReadKey();
            }

            // selecionar ruta por Switch



            Borrado();
            return opcion;
        }

        private static void Salida(int opcion)
        {
            Borrado();
            Marco();

            Console.SetCursorPosition(10, 5);
            Console.Write("La opcion elegida es: " + opcion);
            Console.SetCursorPosition(10, 10);
            Console.Write("gracias por utilzar mi aplicacion ");
            Console.ReadKey();


            Borrado();
        }

        private static void Borrado()
        {
            int Linea;
            for (Linea = 0; Linea <= 50; Linea++)
            {
                Console.WriteLine();
                Temporizador();
            }
            Console.Clear();
        }

        private static void Marco()
        {
            int Fila;
            int Columna;
            for (Columna = 0; Columna <= 80; Columna++)
            {
                Console.SetCursorPosition(Columna, 0);
                Console.Write("*");
                Temporizador();

            }
            for (Fila = 0; Fila <= 21; Fila++)
            {
                Console.SetCursorPosition(80, Fila);
                Console.Write("*");
                Temporizador();
            }
            for (Columna = 80; Columna >= 0; Columna += -1)
            {
                Console.SetCursorPosition(Columna, 21);
                Console.Write("*");
                Temporizador();

            }
            for (Fila = 21; Fila >= 0; Fila += -1)
            {
                Console.SetCursorPosition(0, Fila);
                Console.Write("*");
                Temporizador();
            }
        }

        private static void Temporizador()
        {

            // Este pequello codigo hace la vez de temporizador 
            double tempo;
            for (tempo = 0; tempo <= 100000000; tempo++)
            {
            }
        }
    }
}
