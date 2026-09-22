using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        string operador = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Operador_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResultado.Text, out numero1))
            {
                Button boton = (Button)sender;

                operador = boton.Text;

                txtResultado.Clear();
            }
        }
        private void Numero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            txtResultado.Text += boton.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "-";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";


        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtResultado.Clear();
            numero1 = 0;
            operador = "";
        

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "*";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResultado.Text, out double numero2))
            {
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;

                    case "-":
                        resultado = numero1 - numero2;
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        break;

                    case "/":
                        if (numero2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre cero.");
                            return;
                        }

                        resultado = numero1 / numero2;
                        break;
                }

                txtResultado.Text = resultado.ToString();
            }

        }
    }
}

