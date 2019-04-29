using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoTest.Clases
{
    class Control
    {
        int[] AQ;
        int[] MQ;
        int qm1;

        public Control() {
            string a = "";
            string m = "";

            Eys.Recibir(ref a, ref m);

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

            qm1 = 0;
        }

        public void Calcular()
        {
            DataManip.Normalizar(ref AQ, ref MQ);
            Eys.EscribirIteracion(AQ, MQ, qm1);
            for(int it = 0; it < MQ.Length; it++)
            {
                Iteracion(ref AQ, MQ, ref qm1);
                Eys.EscribirIteracion(AQ,MQ,qm1);
            }
        }

        private static void Iteracion(ref int[] aq, int[] mq, ref int qm1)
        {
            if (DataManip.DoblImp(aq[aq.Length-1], qm1))
            {
                DataManip.SHR(ref aq, ref qm1);
            }
            else
            {
                
                DataManip.Sumar(ref aq, ref mq, (qm1==1)?true:false);
                DataManip.SHR(ref aq, ref qm1);
            }
        }
    }
}
