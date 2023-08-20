namespace Ejemplo_seleccion_2
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
            this.textBoxNuevaTarea = new System.Windows.Forms.TextBox();
            this.buttonAgregarTarea = new System.Windows.Forms.Button();
            this.listBoxTareas = new System.Windows.Forms.ListBox();
            this.buttonCompletarTarea = new System.Windows.Forms.Button();
            this.buttonEliminarTarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNuevaTarea
            // 
            this.textBoxNuevaTarea.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxNuevaTarea.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNuevaTarea.Location = new System.Drawing.Point(199, 359);
            this.textBoxNuevaTarea.Name = "textBoxNuevaTarea";
            this.textBoxNuevaTarea.Size = new System.Drawing.Size(117, 22);
            this.textBoxNuevaTarea.TabIndex = 0;
            this.textBoxNuevaTarea.Text = "Nueva tarea";
            // 
            // buttonAgregarTarea
            // 
            this.buttonAgregarTarea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAgregarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarTarea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgregarTarea.Location = new System.Drawing.Point(355, 348);
            this.buttonAgregarTarea.Name = "buttonAgregarTarea";
            this.buttonAgregarTarea.Size = new System.Drawing.Size(131, 33);
            this.buttonAgregarTarea.TabIndex = 1;
            this.buttonAgregarTarea.Text = "Agregar Tarea";
            this.buttonAgregarTarea.UseVisualStyleBackColor = false;
            this.buttonAgregarTarea.Click += new System.EventHandler(this.buttonAgregarTarea_Click);
            // 
            // listBoxTareas
            // 
            this.listBoxTareas.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxTareas.FormattingEnabled = true;
            this.listBoxTareas.ItemHeight = 16;
            this.listBoxTareas.Location = new System.Drawing.Point(199, 104);
            this.listBoxTareas.Name = "listBoxTareas";
            this.listBoxTareas.Size = new System.Drawing.Size(287, 244);
            this.listBoxTareas.TabIndex = 2;
            // 
            // buttonCompletarTarea
            // 
            this.buttonCompletarTarea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCompletarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompletarTarea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCompletarTarea.Location = new System.Drawing.Point(338, 65);
            this.buttonCompletarTarea.Name = "buttonCompletarTarea";
            this.buttonCompletarTarea.Size = new System.Drawing.Size(148, 33);
            this.buttonCompletarTarea.TabIndex = 3;
            this.buttonCompletarTarea.Text = "Completar tarea";
            this.buttonCompletarTarea.UseVisualStyleBackColor = false;
            this.buttonCompletarTarea.Click += new System.EventHandler(this.buttonCompletarTarea_Click);
            // 
            // buttonEliminarTarea
            // 
            this.buttonEliminarTarea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarTarea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminarTarea.Location = new System.Drawing.Point(184, 68);
            this.buttonEliminarTarea.Name = "buttonEliminarTarea";
            this.buttonEliminarTarea.Size = new System.Drawing.Size(148, 30);
            this.buttonEliminarTarea.TabIndex = 4;
            this.buttonEliminarTarea.Text = "Eliminar Tarea";
            this.buttonEliminarTarea.UseVisualStyleBackColor = false;
            this.buttonEliminarTarea.Click += new System.EventHandler(this.buttonEliminarTarea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEliminarTarea);
            this.Controls.Add(this.buttonCompletarTarea);
            this.Controls.Add(this.listBoxTareas);
            this.Controls.Add(this.buttonAgregarTarea);
            this.Controls.Add(this.textBoxNuevaTarea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNuevaTarea;
        private System.Windows.Forms.Button buttonAgregarTarea;
        private System.Windows.Forms.ListBox listBoxTareas;
        private System.Windows.Forms.Button buttonCompletarTarea;
        private System.Windows.Forms.Button buttonEliminarTarea;
    }
}

