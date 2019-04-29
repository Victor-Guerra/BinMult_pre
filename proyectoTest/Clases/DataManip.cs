using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoTest.Clases
{
    class DataManip
    {
        private DataManip() { }
        public static bool DoblImp(int p, int q)
        {
            if (p == q)
                return true;
            else
                return false;
        }

        public static void Sumar(ref int[] aq, ref int[] mq, bool suma)
        {
            int carry = 0;
            int[] negMQ = mq;
            if (!suma)
            {
                Complemento2(ref negMQ);
            }
            for(int cont = negMQ.Length-1; cont >=0; cont--)
            {
                if(aq[cont] != negMQ[cont])
                {
                    if (carry == 0)
                    {
                        aq[cont] = 1;
                    }
                    else if( carry == 1)
                    {
                        aq[cont] = 0;
                        carry = 1;
                    }
                }
                else if(aq[cont] == 1)
                {
                    if(carry == 0)
                    {
                        aq[cont] = 0;
                        carry = 1;
                    }
                    else if(carry == 1)
                    {
                        aq[cont] = 1;
                        carry = 1;
                    }
                }
                else if( aq[cont] == 0)
                {
                    if(carry == 0)
                    {
                        aq[cont] = 0;
                        carry = 0;
                    }
                    else if (carry == 1)
                    {
                        aq[cont] = 1;
                        carry = 0;
                    }
                }
            }
            if (!suma)
            {
                Complemento2(ref negMQ);
            }
        }

        private static void Complemento2(ref int[] nmq)
        {
            int firstIndex = 0;
            for (int cont = nmq.Length - 1; cont >=0; cont--)
            {
                if (nmq[cont] == 0)
                    continue;
                else if (nmq[cont] == 1)
                {
                    firstIndex = cont;
                    break;
                }
            }
            for(int i = 0; i < firstIndex; i++)
            {
                nmq[i] = (nmq[i] == 1) ? 0 : 1;
            }
        }
        public static void SHR(ref int[] aq, ref int qm1)
        {
            qm1 = aq[aq.Length - 1];
            for(int i = aq.Length-1; i > 0; i--)
            {
                aq[i] = aq[i - 1];
            }
            aq[0] = aq[1];
        }
        public static void ToIntArray(ref int[] arr, string s)
        {
            int cont = 0;

            if (int.TryParse(s, out int i))
            {
                foreach (char c in s)
                {
                    arr[cont++] = int.Parse(c.ToString());
                }
            }
            else
                return;
            
        }

        public static void Normalizar(ref int[] aq, ref int[] mq)
        {
            int taq = 2 * aq.Length;
            int tmq = mq.Length;

            if (mq.Length < (2 * aq.Length) / 2)
                tmq = (2 * aq.Length) / 2;
            

            int[] a = new int[taq];// El largo
            int[] m = new int[tmq];

            //for (int i = aq.Length; i < a.Length; i++)
            int cont = 0;
            int signo = aq[0];
            while (a.Length - aq.Length > cont)
            { 
                
                a[cont++] = signo;
            }
            int i = 0;
            while(cont < a.Length)
            {
                a[cont++] = aq[i++];
            }

            cont = 0;
            i = 0;
            signo = mq[0];
            while (m.Length - mq.Length > cont)
            {
                m[cont++] = signo;
            }
            while ( cont < m.Length)
            {
                m[cont++] = mq[i++];
            }

            aq = a;
            mq = m;
        }
    }
}
