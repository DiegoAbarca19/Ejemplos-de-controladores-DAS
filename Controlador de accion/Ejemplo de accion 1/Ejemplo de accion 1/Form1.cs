using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_de_accion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Obtén el número ingresado como cadena desde el TextBox
            string numeroTexto = textBoxNumero.Text;

            // Intenta convertir la cadena a un número
            if (double.TryParse(numeroTexto, out double numero))
            {
                // Calcula el cuadrado del número
                double cuadrado = numero * numero;

                // Muestra el resultado en el Label
                labelResultado.Text = "El cuadrado es: " + cuadrado.ToString();
            }
            else
            {
                // Muestra un mensaje de error si la entrada no es válida
                labelResultado.Text = "Por favor, ingresa un número válido.";
            }
        }
    }
}
