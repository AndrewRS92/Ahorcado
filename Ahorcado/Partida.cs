using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class Partida
    {
        public string Palabra { get; set; }
        public Partida(int dificultad)
        {
            if (dificultad == 1)
            {
                Random rand = new Random();
                int aleatorio= rand.Next(0, Palabras.Facil.Count);
                Palabra = Palabras.Facil[aleatorio];

            }
            if (dificultad == 2)
            {
                Random rand = new Random();
                int aleatorio = rand.Next(0, Palabras.Media.Count);
                Palabra = Palabras.Facil[aleatorio];

            }
            if (dificultad == 3)
            {
                Random rand = new Random();
                int aleatorio = rand.Next(0, Palabras.Dificil.Count);
                Palabra = Palabras.Facil[aleatorio];

            }

        }
        public void Lanzar()
        {
            int numeroDeFallos = 0;
            string palabra = Palabra;
            List<char> letrasProbadas = new List<char>();
            List<char> letrasCorrectas = new List<char>();
            bool salir=false;
            while (!salir)
            {
                Dibujar(numeroDeFallos);
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (letrasCorrectas.Contains(palabra[i]))
                    {
                        Console.Write(palabra[i] + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();
                Console.Write("Has usado las letras: ");
                foreach (char letrilla in letrasProbadas)
                {
                    Console.Write(letrilla + ", ");
                }
                Console.WriteLine();
                Console.WriteLine("Dame una letra");
                char letra = Convert.ToChar(Console.ReadLine());

                if (letrasProbadas.Contains(letra) || !palabra.Contains(letra))
                {
                    numeroDeFallos++;
                    if (numeroDeFallos == 6)
                    {
                        Console.Clear();
                        Dibujar(numeroDeFallos);
                        Console.WriteLine("Has perdido  :(");
                        Console.WriteLine("La palabra era "+palabra);
                        Console.ReadLine();
                        salir = true;
                    }
                }
                else
                {
                    if (palabra.Contains(letra))
                    {
                        letrasCorrectas.Add(letra);
                        if (Ganar(palabra,letrasCorrectas))
                        {
                            Console.Clear();
                            Console.WriteLine("¡Felicidades! Has ganado.");
                            Console.WriteLine("La palabra era " + palabra);
                            Console.ReadLine();
                            salir = true;

                        }
                    }
                }
                letrasProbadas.Add(letra);
                Console.Clear();
            }
        }

        private void Dibujar(int numeroDeFallos)
        {
            if (numeroDeFallos == 0)
            {
                Dibujos.DibujoInicial();
            }
            if (numeroDeFallos == 1)
            {
                Dibujos.DibujoUno();
            }
            if (numeroDeFallos == 2)
            {
                Dibujos.DibujoDos();
            }
            if (numeroDeFallos == 3)
            {
                Dibujos.DibujoTres();
            }
            if (numeroDeFallos == 4)
            {
                Dibujos.DibujoCuatro();
            }
            if (numeroDeFallos == 5)
            {
                Dibujos.DibujoCinco();
            }
            if (numeroDeFallos == 6)
            {
                Dibujos.DibujoSeis();

            }

        }
        private bool Ganar(string palabra, List<char> letrasCorrectas)
        {
            for(int i = 0; i < palabra.Length; i++)
            {
                if (!letrasCorrectas.Contains(palabra[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
