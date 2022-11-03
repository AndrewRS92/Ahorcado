using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class Partida
    {
        public void Lanzar()
        {
            int numeroDeFallos = 0;
            string palabra = "zopenco";
            while (true)
            {
                Dibujos.DibujoInicial();
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < palabra.Length; i++)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine();
                Console.WriteLine("Dame una letra");
                char letra = Convert.ToChar(Console.ReadLine());
            }
        }
        
        private void Dibujar(int numeroDeFallos)
        {
            if(numeroDeFallos == 0)
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
    }
}
