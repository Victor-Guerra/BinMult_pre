using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoTest.Clases
{
    class Eys
    {
        private Eys() { }

        public static void Recibir(ref string aq, ref string mq) {
            Console.WriteLine("De un numero en binario de n bits en Ca2:");
            aq = Console.ReadLine();
            Console.WriteLine("De otro numero en binario de n bits en Ca2");
            mq = Console.ReadLine();
        }

        static bool init = true;
        static int iteracion = 1;
        public static void EscribirIteracion(int[] aq, int[] mq, int qm1)
        {
            if (init)
            {
                Console.WriteLine("En orden: Q -- A -- Q[-1] -- M");
                for (int i = 0; i < 2 * (aq.Length + mq.Length) + 7; i++)
                {
                    Console.Write("~");
                }
                Console.Write('\n');
                foreach (int i in aq)
                {
                    if (i == aq[aq.Length / 2])
                        Console.Write("| ");
                    Console.Write("{0} ", i);
                }
                Console.Write("| {0} | ", qm1);
                foreach(int i in mq)
                {
                    Console.Write("{0} ", i);
                }
                Console.Write("Inicializacion.\n");
                for(int i = 0; i < 2*(aq.Length+mq.Length)+7; i++)
                {
                    Console.Write("~");
                }
                init = false;
            }
            else
            {
                Console.Write('\n');
                foreach (int i in aq)
                {
                    if (i == aq[aq.Length / 2])
                        Console.Write("| "); 
                    Console.Write("{0} ", i);
                }
                Console.Write("| {0} | ", qm1);
                foreach (int i in mq)
                {
                    Console.Write("{0} ", i);
                }
                Console.Write("Iteracion #{0}\n", iteracion++);
                for (int i = 0; i < 2 * (aq.Length + mq.Length) + 7; i++)
                {
                    Console.Write("~");
                }
            }
            Console.Write('\n');
        }
    }
}
