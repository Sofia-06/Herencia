using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //Maria, Karla, Sofia, Mijhal
    class Program
    {
        static Menu me = new Menu();
        static void Main(string[] args)
        {
            int opciones = 0;
            while (opciones != 7)
            {
                opciones = me.ListMenu();
                Console.Clear();
                if (opciones == 1)
                {
                    Console.WriteLine(me.Resultado('a'));
                }
                else if (opciones == 2)
                {
                    Console.WriteLine(me.Resultado('s'));
                }
                else if (opciones == 3)
                {
                    Console.WriteLine(me.Resultado('m'));
                }
                else if (opciones == 4)
                {
                    Console.WriteLine(me.Resultado('d'));
                }
                else if (opciones == 5)
                {
                    Console.WriteLine(me.Resultado('p'));
                }
                else if (opciones == 6)
                {
                    Console.WriteLine(me.Resultado('r'));
                }
                Console.WriteLine("\n \n \n");

            }
            Console.ReadKey();
        }
    }
}
