﻿namespace Ejemplo_de_accion_2
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
            this.buttonAbrirArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAbrirArchivo
            // 
            this.buttonAbrirArchivo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAbrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirArchivo.Location = new System.Drawing.Point(316, 173);
            this.buttonAbrirArchivo.Name = "buttonAbrirArchivo";
            this.buttonAbrirArchivo.Size = new System.Drawing.Size(174, 34);
            this.buttonAbrirArchivo.TabIndex = 0;
            this.buttonAbrirArchivo.Text = "Abrir Archivo";
            this.buttonAbrirArchivo.UseVisualStyleBackColor = false;
            this.buttonAbrirArchivo.Click += new System.EventHandler(this.buttonAbrirArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbrirArchivo);
            this.Name = "Form1";
            this.Text = "Abrir Archivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAbrirArchivo;
    }
}

