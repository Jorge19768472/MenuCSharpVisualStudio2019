using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCSharpVisualStudio2019
{
    class Program
    {
        static void Main(string[] args)
        {// incio de l programa
            {
                Marco();// va la marco
                // el menu en si. Presentacion de opcines
                Console.SetCursorPosition(10, 5);
                Console.Write(" MenuCharpVisualStudio2019");


                Borrado();
            }

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
