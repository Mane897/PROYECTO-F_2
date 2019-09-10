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
    public partial class Form1 : Form
    {
        //NO CREO QUE HAGA FALTA ALGO AQUI, PERO REVISA POR SI ACASO
        public Form1()
        {
            InitializeComponent();
           
        }
        public static string nombre;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            
            if (tb1.Text == string.Empty) //Para que no pase nada si se da click en el boton con el campo vacio
            {
                MessageBox.Show("Porfavor ingrese su nombre en el campo solicitado");
            }
            else
            {                
                    nombre = tb1.Text;
                    Form2 form2a = new Form2();
                    form2a.Show();
                this.Close();
            }
        }

        private void Tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_solo_letras.SoloLetras(e); //Codigo para hacer que solo acepte letras
        }
    }
}
