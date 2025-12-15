using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimple
{
    public partial class Form1 : Form
    {
        Calculadora calc;
        string operacion;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculadora();
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "suma";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "resta";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion = "multi";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = "div";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            double r = 0;

            switch (operacion)
            {
                case "suma": r = calc.Sumar(n1, n2); break;
                case "resta": r = calc.Restar(n1, n2); break;
                case "multi": r = calc.Multiplicar(n1, n2); break;
                case "div": r = calc.Dividir(n1, n2); break;
            }

            txtResultado.Text = r.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", calc.Historial), "Historial");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
