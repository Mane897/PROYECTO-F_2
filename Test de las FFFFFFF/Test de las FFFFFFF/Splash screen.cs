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
    public partial class Splash_screen : Form
    {
        //NO HACE FALTA MOVER NADA AQUI
        public Splash_screen()
        {
            InitializeComponent();
        }

        private void Splash_screen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            Portada abrir = new Portada();
            abrir.Show();
        }
    }
}
