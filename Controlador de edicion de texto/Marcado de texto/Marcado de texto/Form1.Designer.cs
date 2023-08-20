namespace Marcado_de_texto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextTexto = new System.Windows.Forms.RichTextBox();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextTexto
            // 
            this.richTextTexto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextTexto.Location = new System.Drawing.Point(114, 89);
            this.richTextTexto.Name = "richTextTexto";
            this.richTextTexto.Size = new System.Drawing.Size(502, 244);
            this.richTextTexto.TabIndex = 0;
            this.richTextTexto.Text = "";
            this.richTextTexto.TextChanged += new System.EventHandler(this.richTextTexto_TextChanged);
            // 
            // boldButton
            // 
            this.boldButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boldButton.Location = new System.Drawing.Point(114, 45);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(111, 38);
            this.boldButton.TabIndex = 1;
            this.boldButton.Text = "Negrita";
            this.boldButton.UseVisualStyleBackColor = false;
            // 
            // italicButton
            // 
            this.italicButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.italicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.italicButton.Location = new System.Drawing.Point(231, 45);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(111, 38);
            this.italicButton.TabIndex = 2;
            this.italicButton.Text = "Cursiva";
            this.italicButton.UseVisualStyleBackColor = false;
            // 
            // underlineButton
            // 
            this.underlineButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.underlineButton.Location = new System.Drawing.Point(348, 45);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(111, 38);
            this.underlineButton.TabIndex = 3;
            this.underlineButton.Text = "Subrayado";
            this.underlineButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.richTextTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextTexto;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button underlineButton;
    }
}

