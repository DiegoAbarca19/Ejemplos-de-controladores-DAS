using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1_seleccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agrega opciones al ComboBox
            comboBoxOpciones.Items.Add("Opción 1");
            comboBoxOpciones.Items.Add("Opción 2");
            comboBoxOpciones.Items.Add("Opción 3");

            // Configura un manejador de eventos para el ComboBox
            comboBoxOpciones.SelectedIndexChanged += (s, args) => MostrarSeleccion();
        }
        private void MostrarSeleccion()
        {
            if (comboBoxOpciones.SelectedItem != null)
            {
                // Muestra la opción seleccionada en el Label
                labelResultado.Text = "Seleccionado: " + comboBoxOpciones.SelectedItem.ToString();
            }
            else
            {
                // Maneja el caso en el que no se haya seleccionado ningún elemento
                labelResultado.Text = "Nada seleccionado";
            }
        }
    }
}

