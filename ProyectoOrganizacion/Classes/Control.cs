using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOrganizacion.Classes
{
    class Control
    {
        int[] AQ;
        int[] MQ;
        int qm1;
        string copia = "";

        public void Calcular(ref System.Windows.Forms.TextBox txtBoxA, ref System.Windows.Forms.TextBox txtBoxM, ref System.Windows.Forms.ListBox lst)
        {
            Eys.Recibir(ref txtBoxA, ref  txtBoxM, ref  AQ, ref MQ);
            qm1 = 0;

            DataManip.Normalizar(ref AQ, ref MQ);

            Eys.EscribirIteracion(AQ, MQ, qm1, copia, ref lst);
            for (int it = 0; it < MQ.Length; it++)
            {
                Iteracion(ref AQ, MQ, ref qm1);
                Eys.EscribirIteracion(AQ, MQ, qm1, copia, ref lst);
            }

            Eys.iteracion = 1;
            Eys.init = true;
        }

        private static void Iteracion(ref int[] aq, int[] mq, ref int qm1)
        {
            if (DataManip.DoblImp(aq[aq.Length - 1], qm1))
            {
                DataManip.SHR(ref aq, ref qm1);
            }
            else
            {
                DataManip.Sumar(ref aq, ref mq, (qm1 == 1) ? true : false);
                DataManip.SHR(ref aq, ref qm1);
            }
        }
    }
}
