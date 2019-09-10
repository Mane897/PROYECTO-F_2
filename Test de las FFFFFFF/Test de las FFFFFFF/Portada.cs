using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_de_las_FFFFFFF
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void BtnAvanzar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 inicio = new Form1(); //esta parte es para abrir el form1
            inicio.Show();
        }
    }
}
