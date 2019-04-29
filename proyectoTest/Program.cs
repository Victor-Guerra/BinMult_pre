using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoTest.Clases;

namespace proyectoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Control calc;
            bool on = true;
            while (on)
            {
                calc = new Control();
                calc.Calcular();

                Console.WriteLine("Continuar? y/n");
                char c = Console.ReadKey().KeyChar;
                if (c == 'y')
                    continue;
                else
                    break;
            }
        }
    }
}
