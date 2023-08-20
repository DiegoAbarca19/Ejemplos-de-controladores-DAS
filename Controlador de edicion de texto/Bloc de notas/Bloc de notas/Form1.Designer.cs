namespace Bloc_de_notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.AbrirStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.GuardarStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoStripMenuItem1
            // 
            this.ArchivoStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ArchivoStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoStripMenuItem2,
            this.AbrirStripMenuItem3,
            this.GuardarStripMenuItem4});
            this.ArchivoStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchivoStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ArchivoStripMenuItem1.Name = "ArchivoStripMenuItem1";
            this.ArchivoStripMenuItem1.Size = new System.Drawing.Size(92, 29);
            this.ArchivoStripMenuItem1.Text = "Archivo";
            // 
            // NuevoStripMenuItem2
            // 
            this.NuevoStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoStripMenuItem2.Name = "NuevoStripMenuItem2";
            this.NuevoStripMenuItem2.Size = new System.Drawing.Size(224, 30);
            this.NuevoStripMenuItem2.Text = "Nuevo";
            this.NuevoStripMenuItem2.Click += new System.EventHandler(this.NuevoStripMenuItem2_Click);
            // 
            // AbrirStripMenuItem3
            // 
            this.AbrirStripMenuItem3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirStripMenuItem3.Name = "AbrirStripMenuItem3";
            this.AbrirStripMenuItem3.Size = new System.Drawing.Size(224, 30);
            this.AbrirStripMenuItem3.Text = "Abrir";
            this.AbrirStripMenuItem3.Click += new System.EventHandler(this.AbrirStripMenuItem3_Click);
            // 
            // GuardarStripMenuItem4
            // 
            this.GuardarStripMenuItem4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarStripMenuItem4.Name = "GuardarStripMenuItem4";
            this.GuardarStripMenuItem4.Size = new System.Drawing.Size(224, 30);
            this.GuardarStripMenuItem4.Text = "Guardar";
            this.GuardarStripMenuItem4.Click += new System.EventHandler(this.GuardarStripMenuItem4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(12, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 344);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoStripButton1,
            this.AbrirStripButton2,
            this.GuardarStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoStripButton1
            // 
            this.NuevoStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NuevoStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("NuevoStripButton1.Image")));
            this.NuevoStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoStripButton1.Name = "NuevoStripButton1";
            this.NuevoStripButton1.Size = new System.Drawing.Size(29, 24);
            this.NuevoStripButton1.Text = "toolStripButton1";
            this.NuevoStripButton1.Click += new System.EventHandler(this.NuevoStripButton1_Click);
            // 
            // AbrirStripButton2
            // 
            this.AbrirStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AbrirStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("AbrirStripButton2.Image")));
            this.AbrirStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AbrirStripButton2.Name = "AbrirStripButton2";
            this.AbrirStripButton2.Size = new System.Drawing.Size(29, 28);
            this.AbrirStripButton2.Text = "toolStripButton2";
            this.AbrirStripButton2.Click += new System.EventHandler(this.AbrirStripButton2_Click);
            // 
            // GuardarStripButton3
            // 
            this.GuardarStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("GuardarStripButton3.Image")));
            this.GuardarStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarStripButton3.Name = "GuardarStripButton3";
            this.GuardarStripButton3.Size = new System.Drawing.Size(29, 28);
            this.GuardarStripButton3.Text = "toolStripButton3";
            this.GuardarStripButton3.Click += new System.EventHandler(this.GuardarStripButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NuevoStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AbrirStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem GuardarStripMenuItem4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoStripButton1;
        private System.Windows.Forms.ToolStripButton AbrirStripButton2;
        private System.Windows.Forms.ToolStripButton GuardarStripButton3;
    }
}

