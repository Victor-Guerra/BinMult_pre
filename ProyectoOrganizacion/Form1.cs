using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOrganizacion.Classes;

namespace ProyectoOrganizacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        ProyectoOrganizacion.Classes.Control calc = new ProyectoOrganizacion.Classes.Control();


        private void Bttn_Calcular_Click(object sender, EventArgs e)
        {
            lstBoxResult.Items.Clear();
            
            calc.Calcular(ref txtbxMultiplicando, ref txtbxMultiplicador, ref lstBoxResult);
        }
    }
}
