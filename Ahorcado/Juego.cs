using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class Juego
    {

        public void Lanzar()
        {
           bool exit=false;
            while (exit==false)
            {   
                Console.WriteLine("Bienvenido al Ahorcado. Pulse enter para continuar o Escape para salir.");
                var tecla = Console.ReadKey();
                Console.Clear();
                if (tecla.Key == ConsoleKey.Escape)
                {
                    exit=true;  
                }
                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Elija la dificultad:");
                    Console.WriteLine("1. Fácil");
                    Console.WriteLine("2. Medio");
                    Console.WriteLine("3. Dificil");
                    int dificultad = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (dificultad == 1)
                    {

                    }
                    if (dificultad == 2)
                    {

                    }
                    if (dificultad == 3)
                    {

                    }
                }

            }

        }

    }
}

