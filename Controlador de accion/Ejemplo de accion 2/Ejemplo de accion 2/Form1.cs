using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_de_accion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbrirArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Abrir Archivo";
                openFileDialog.Filter = "Archivos de Texto|*.txt|Todos los Archivos|*.*"; // Define los tipos de archivo permitidos

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionado
                    string archivoSeleccionado = openFileDialog.FileName;

                    // Realiza la lógica para abrir el archivo aquí
                    // Por ejemplo, puedes mostrar el contenido del archivo en un TextBox
                    // textBoxContenido.Text = File.ReadAllText(archivoSeleccionado);
                }
            }
        }
    }
}
