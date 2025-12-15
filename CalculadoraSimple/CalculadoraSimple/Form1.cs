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
    // Clase parcial Form1 que representa la interfaz gráfica
    public partial class Form1 : Form
    {
        // Instancia de la clase Calculadora para realizar operaciones
        Calculadora calc;
        // Variable para guardar el tipo de operación seleccionada
        string operacion;

        // Constructor del formulario
        public Form1()
        {
            // Inicializa los componentes gráficos del formulario
            InitializeComponent();
            // Crea una nueva calculadora
            calc = new Calculadora();
        }

        // Evento que se ejecuta cuando se presiona el botón de suma
        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Guarda que la próxima operación será suma
            operacion = "suma";
        }

        // Evento del botón de resta
        private void btnResta_Click(object sender, EventArgs e)
        {
            // Guarda que la próxima operación será resta
            operacion = "resta";
        }

        // Evento del botón de multiplicación
        private void btnMulti_Click(object sender, EventArgs e)
        {
            // Guarda que la operación será multiplicación
            operacion = "multi";
        }

        // Evento del botón de división
        private void btnDiv_Click(object sender, EventArgs e)
        {
            // Guarda que la operación será división
            operacion = "div";
        }

        // Evento que se ejecuta al presionar el botón igual (=)
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Convierte el texto ingresado a valores numéricos
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            // Variable para guardar el resultado
            double r = 0;

            // Dependiendo de la operación seleccionada se llama al método correspondiente
            switch (operacion)
            {
                case "suma": r = calc.Sumar(n1, n2); break;
                case "resta": r = calc.Restar(n1, n2); break;
                case "multi": r = calc.Multiplicar(n1, n2); break;
                case "div": r = calc.Dividir(n1, n2); break;
            }

            // Muestra el resultado en el cuadro de texto
            txtResultado.Text = r.ToString();
        }

        // Evento del botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia los tres cuadros de texto
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        // Evento para mostrar el historial de operaciones
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            // Muestra cada operación del historial en una MessageBox, separadas por saltos de línea
            MessageBox.Show(string.Join("\n", calc.Historial), "Historial");
        }

        // Evento del botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Close();
        }

        // Evento cuando cambia el texto del resultado (no usado actualmente)
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
