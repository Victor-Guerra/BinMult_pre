using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOrganizacion.Classes
{
    class Eys
    {
        private Eys() { }

        /*public static void Recibir(ref string aq, ref string mq)
        {
            //Console.WriteLine("De un numero en binario de n bits en Ca2:");
            aq = Console.ReadLine();
            //Console.WriteLine("De otro numero en binario de n bits en Ca2");
            mq = Console.ReadLine();
        }*/

         public static bool init = true;
         public static int iteracion = 1;

        public static void Recibir(ref System.Windows.Forms.TextBox txtBoxA, ref System.Windows.Forms.TextBox txtBoxM, ref int[] AQ, ref int[] MQ)
        {
            string a = txtBoxA.Text;
            string m = txtBoxM.Text;

            //Eys.Recibir(ref a, ref m);

            if (a.Length >= m.Length)
            {
                AQ = new int[a.Length];
                MQ = new int[m.Length];
                DataManip.ToIntArray(ref AQ, a);
                DataManip.ToIntArray(ref MQ, m);
            }
            else
            {
                AQ = new int[m.Length];
                MQ = new int[a.Length];
                DataManip.ToIntArray(ref AQ, m);
                DataManip.ToIntArray(ref MQ, a);
            }
        }
        public static void EscribirIteracion(int[] aq, int[] mq, int qm1, string copia, ref System.Windows.Forms.ListBox lst)
        {
            if (init)
            {
                lst.Items.Add("En orden: Q -- A -- Q[-1] -- M");

                for (int i = 0; i < 2 * (aq.Length + mq.Length) + 7; i++)
                {
                    copia += '~';
                }
                lst.Items.Add(copia);
                copia = "";

                foreach (int i in aq)
                {
                    int co = 1;
                    copia += (i.ToString() + " ");
                    if (co == aq.Length / 2)
                    {
                        copia += " | ";
                    }
                    co++;
                   
                }

                copia += " | " + qm1.ToString() + " | ";

                foreach (int i in mq)
                {
                    copia += (i.ToString() + " ");
                }
                copia += " Inicializacion.";
                lst.Items.Add(copia);
                copia = "";
                for (int i = 0; i < 2 * (aq.Length + mq.Length) + 7; i++)
                {
                    copia +="~";
                }
                lst.Items.Add(copia);
                copia = "";
                init = false;
            }
            else
            {

                foreach (int i in aq)
                {
                    int co = 1;
                    copia += (i.ToString() + " ");
                    if (co == aq.Length / 2)
                    {
                        copia += " | ";
                    }
                    co++;

                }

                copia += " | " + qm1.ToString() + " | ";

                foreach (int i in mq)
                {
                    copia += (i.ToString() + " ");
                }

                copia +=" Iteracion #" + iteracion++;

                lst.Items.Add(copia);
                copia = "";

                for (int i = 0; i < 2 * (aq.Length + mq.Length) + 7; i++)
                {
                    copia += "~";
                }
                lst.Items.Add(copia);

                if(iteracion > aq.Length/2)
                {
                    iteracion = 1;
                }
            }
        }
    }
}
