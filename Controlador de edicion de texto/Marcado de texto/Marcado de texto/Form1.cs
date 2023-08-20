using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcado_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Conectar los eventos de los botones a sus manejadores
            boldButton.Click += (s, args) => ToggleFormatting(FontStyle.Bold);
            italicButton.Click += (s, args) => ToggleFormatting(FontStyle.Italic);
            underlineButton.Click += (s, args) => ToggleFormatting(FontStyle.Underline);
        }
        // Función para aplicar o quitar formato de texto
        private void ToggleFormatting(FontStyle style)
        {
            if (richTextTexto.SelectionFont != null)
            {
                FontStyle currentStyle = richTextTexto.SelectionFont.Style;

                // Si el estilo deseado ya está aplicado, quitarlo; de lo contrario, aplicarlo
                if ((currentStyle & style) == style)
                {
                    currentStyle &= ~style;
                }
                else
                {
                    currentStyle |= style;
                }
                richTextTexto.SelectionFont = new Font(richTextTexto.SelectionFont, currentStyle);
            }
        }

        private void richTextTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
