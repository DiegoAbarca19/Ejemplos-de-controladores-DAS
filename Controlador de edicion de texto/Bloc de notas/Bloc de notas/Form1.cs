using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloc_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Controlador de evento para menu "Nuevo"
        private void NuevoStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Limpiar el contenido de la caja de texto
            richTextBox1.Clear();
        }

        //Controlador de evento para el menu "Abrir"
        private void AbrirStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivo de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string contenido = File.ReadAllText(openFileDialog.FileName);
                    richTextBox1.Text = contenido;
                }
            }
        }

        //Controlador de evento para menu "Guardar"
        private void GuardarStripMenuItem4_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                }
            }
        }

        //Controlador de evento para el boton "Nuevo"
        private void NuevoStripButton1_Click(object sender, EventArgs e)
        {
            // Limpiar el contenido del RichTextBox
            richTextBox1.Clear();
        }

        //Controlador de evento para el boton "Abrir"
        private void AbrirStripButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        // Controlador de evento para el botón "Guardar"
        private void GuardarStripButton3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                }
            }
        }
    }
}
    
