using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_seleccion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregarTarea_Click(object sender, EventArgs e)
        {
            // Obtén el texto ingresado en el TextBox
            string nuevaTarea = textBoxNuevaTarea.Text;

            // Verifica si el texto no está vacío
            if (!string.IsNullOrWhiteSpace(nuevaTarea))
            {
                // Agrega la nueva tarea al ListBox
                listBoxTareas.Items.Add(nuevaTarea);

                // Limpia el contenido del TextBox después de agregarlo
                textBoxNuevaTarea.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una tarea válida.");
            }
        }

        private void buttonCompletarTarea_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedIndex != -1)
            {
                // Marca la tarea como completada agregando un texto adicional
                string tareaSeleccionada = listBoxTareas.SelectedItem.ToString();
                listBoxTareas.Items[listBoxTareas.SelectedIndex] = tareaSeleccionada + " (completada)";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para marcar como completada.");
            }
        }

        private void buttonEliminarTarea_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedIndex != -1)
            {
                // Elimina la tarea seleccionada del ListBox
                listBoxTareas.Items.RemoveAt(listBoxTareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.");
            }
        }
    }
}
