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
    public partial class Form2 : Form
    {
        private int x; //ACOMODAR EL TEXTO
        public Form2()
        {
            InitializeComponent();
            lbltexto.Visible = false;
            lblTimer.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lbltexto.Visible = true;
            label1.Visible = false;
            button1.Visible = false;
            timer1.Enabled = true;
            lblTimer.Visible = true;
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 0)     //El contador de 10 a 0 visible en el formulario
                lblTimer.Text = "10";           
            if (x == 1)           
                lblTimer.Text = "9";
            if (x == 2)
                lblTimer.Text = "8";
            if (x == 3)
                lblTimer.Text = "7";
            if (x == 4)
                lblTimer.Text = "6";
            if (x == 5)
                lblTimer.Text = "5";
            if (x == 6)
                lblTimer.Text = "4";
            if (x == 7)
                lblTimer.Text = "3";
            if (x == 8)
                lblTimer.Text = "2";
            if (x == 9)
                lblTimer.Text = "1";

            if (x == 10)
            {
                lblTimer.Text = "0";
                this.Close();
                Resultados form2a = new Resultados();
                form2a.Show();
                timer1.Stop();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Este es para que la label escriba el nombre de la persona, modifica el texto
            string nombre;
            nombre = Form1.nombre;
            label1.Text = nombre + " tiene usted 10 segundos para \r\n"; 
            label1.Text += "buscar letras " + "F" +" en el siguiente texto \r\n";
            //si te sirve, el "\r\n" es para que deje un espacio como si presionaras enter en word             
        }
    }
}
