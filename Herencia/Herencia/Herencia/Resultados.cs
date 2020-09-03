using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Resultados
    {
        public opera op = new opera();
        public string Resultado(char t)

        {
            double total = 0;


            if (t == 'a')
            {
                total = op.Suma(Pedir(), Pedir());
            }
            else if (t == 's')
            {
                total = op.Resta(Pedir(), Pedir());
            }
            else if (t == 'm')
            {
                total = op.Multi(Pedir(), Pedir());
            }
            else if (t == 'd')
            {
                total = op.Divi(Pedir(), Pedir());
            }
            else if (t == 'p')
            {
                total = op.Poten(Pedir(), Pedir());
            }
            else if (t == 'r')
            {
                total = op.Raiz(Pedir());
            }

            return ("el resultado es: " + total);

        }
        private double Pedir()
        {
            double valor = 0;
            bool estado = false;
            while (estado == false)
            {
                Console.Write("ingrese un valor: ");
                try
                {
                    valor = double.Parse(Console.ReadLine());
                    estado = true;
                }
                catch
                {
                    Console.WriteLine("solo valores numericos...");
                }

            }
            return valor;
        }
    }
}
