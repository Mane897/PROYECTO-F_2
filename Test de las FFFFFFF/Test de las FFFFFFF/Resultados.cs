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
    public partial class Resultados : Form 
    {
        
        public Resultados()
        {
            InitializeComponent();
            
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.nombre;
            btnRegresar.Visible = false;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_solo_letras.SoloNumeros(e);  
        }

        private void Button1_Click(object sender, EventArgs e) //YA NO HACEN FALTA IF
        {

            lbl2.Visible = false;
            btn2.Visible = false;
            tb2.Visible = false;
            int respuesta;
            if (tb2.Text == string.Empty) 
            {
                MessageBox.Show("Porfavor ingrese un numero");
                lbl2.Visible = true;
                btn2.Visible = true;
                tb2.Visible = true;
                btnRegresar.Visible = false;
            }
            else
            {
                respuesta = int.Parse(tb2.Text);
                if (respuesta <= 0)
                {
                    MessageBox.Show("Estas fuera de los parametros");
                    lbl2.Visible = true;
                    btn2.Visible = true;
                    tb2.Visible = true;
                    btnRegresar.Visible = false;
                }
                if (respuesta == 1)
                {
                    btnRegresar.Visible = true;
                    label1.Visible = true;

                    label1.Text += ", persona con";
                    label2.Visible = true;
                    label2.Text = "Pasiones profundas y escondidas";
                    label3.Visible = true;
                    label3.Text = "Callada";
                    label4.Visible = true;
                    label4.Text = "Solitaria";
                    label5.Visible = true;
                    label5.Text = "De sufrimientos intensos";
                    lblNum.Visible = true;
                    lblNum.Text = "1";
                }
                if (respuesta == 2)
                {
                    btnRegresar.Visible = true;
                    label1.Visible = true;
                    label1.Text += ", persona totalmente";
                    label2.Visible = true;
                    label2.Text = "Apasionada";
                    label3.Visible = true;
                    label3.Text = "No entiende razones";
                    label4.Visible = true;
                    label4.Text = "Posiblemente celosa";
                    label5.Visible = true;
                    label5.Text = "Posesiva";
                    label6.Visible = true;
                    label6.Text = "Absorbente y Terca";
                    lblNum.Visible = true;
                    lblNum.Text = "2";
                }
                if (respuesta == 3)
                {
                    btnRegresar.Visible = true;
                    label1.Visible = true;
                    label1.Text += ", persona";
                    label2.Visible = true;
                    label2.Text = "Emosionable";
                    label3.Visible = true;
                    label3.Text = "Visionaria";
                    label4.Visible = true;
                    label4.Text = "Busca retos";
                    label5.Visible = true;
                    label5.Text = "Gusta de lo novedoso";
                    label6.Visible = true;
                    label6.Text = "No analis el costo de las cosas y" +
                        " batalla para dar argumentos";
                    lblNum.Visible = true;
                    lblNum.Text = "3";
                }
                if (respuesta == 4)
                {
                    btnRegresar.Visible = true;
                    label1.Visible = true;
                    label1.Text += ", persona con";
                    label2.Visible = true;
                    label2.Text = "Equilibrada";
                    label3.Visible = true;
                    label3.Text = "Trata las cosas con la razon y" +
                        "la emocion";
                    label4.Visible = true;
                    label4.Text = "Busca el equilibrio en todo";
                    label5.Visible = true;
                    label5.Text = "Administra bien su dinero y su tiempo";
                    label6.Visible = true;
                    label6.Text = "Bueno en casi todo";
                    lblNum.Visible = true;
                    lblNum.Text = "4";
                }
                if (respuesta == 5)
                {
                    btnRegresar.Visible = true;
                    label1.Visible = true;
                    label1.Text += ", persona que";
                    label2.Visible = true;
                    label2.Text = "Batalla para iniciar algo";
                    label3.Visible = true;
                    label3.Text = "Muy racional";
                    label4.Visible = true;
                    label4.Text = "Muy analitico";
                    label5.Visible = true;
                    label5.Text = "Posiblemente descuidado";
                    label6.Visible = true;
                    label6.Text = "Fijado";
                    lblNum.Visible = true;
                    lblNum.Text = "5";
                }
                if (respuesta == 6)
                {
                    btnRegresar.Visible = true;
                    label1.Visible = true;
                    label1.Text += ", persona que";
                    label2.Visible = true;
                    label2.Text = "Quiere saber de mas";
                    label3.Visible = true;
                    label3.Text = "Pregunta el porque de " +
                        "todo, en casi todo";
                    label4.Visible = true;
                    label4.Text = "Tiende a dudar de todo y de todos";
                    label5.Visible = true;
                    label5.Text = "Cuida el dinero con sumo cuidado";
                    label6.Visible = true;
                    label6.Text = "Muy practicos y solucionadores" +
                        "de problemas";
                    lblNum.Visible = true;
                    lblNum.Text = "6";
                }
                if (respuesta == 7)
                {
                    btnRegresar.Visible = true;
                    label1.Visible = true;
                    label1.Text += ", persona";
                    label2.Visible = true;
                    label2.Text = "Exageradamente detallista";
                    label3.Visible = true;
                    label3.Text = "Perfeccionista";
                    label4.Visible = true;
                    label4.Text = "Radical";
                    label5.Visible = true;
                    label5.Text = "Solitaria";
                    label6.Visible = true;
                    label6.Text = "Los numeros tienen un significado" +
                        "muy especial para el o ella";
                    lblNum.Visible = true;
                    lblNum.Text = "7";
                }
                if (respuesta >= 8)
                {
                    MessageBox.Show("Estas fuera de los parametros");
                    lbl2.Visible = true;
                    btn2.Visible = true;
                    tb2.Visible = true;
                    btnRegresar.Visible = false;
                }
            }
        }
        //ESTE BOTON AHORA ABRE EL FORM DE LOS CREDITOS
        private void BtnExit_Click(object sender, EventArgs e) 
        {
            this.Close();
            Creditos abrir = new Creditos();
            abrir.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e) // boton para regresar antes de ingresar el numero de "F"
        {
            lbl2.Visible = true;
            btn2.Visible = true;
            tb2.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lblNum.Visible = false;
        }
    }
}
