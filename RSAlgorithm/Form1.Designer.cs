namespace RSAlgorithm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botonCifrar = new System.Windows.Forms.Button();
            this.textBoxACifrar = new System.Windows.Forms.TextBox();
            this.textBoxCifrado = new System.Windows.Forms.TextBox();
            this.textBoxADescifrar = new System.Windows.Forms.TextBox();
            this.textBoxDescifrado = new System.Windows.Forms.TextBox();
            this.botonDescifrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonInicial = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clavesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clavesToolStripMenuItem
            // 
            this.clavesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.clavesToolStripMenuItem.Name = "clavesToolStripMenuItem";
            this.clavesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.clavesToolStripMenuItem.Text = "Claves";
            this.clavesToolStripMenuItem.Click += new System.EventHandler(this.clavesToolStripMenuItem_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Enabled = false;
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // botonCifrar
            // 
            this.botonCifrar.Enabled = false;
            this.botonCifrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonCifrar.Location = new System.Drawing.Point(216, 253);
            this.botonCifrar.Name = "botonCifrar";
            this.botonCifrar.Size = new System.Drawing.Size(75, 23);
            this.botonCifrar.TabIndex = 10;
            this.botonCifrar.Text = "CIFRAR";
            this.botonCifrar.UseVisualStyleBackColor = true;
            this.botonCifrar.Click += new System.EventHandler(this.botonCifrar_Click);
            // 
            // textBoxACifrar
            // 
            this.textBoxACifrar.Enabled = false;
            this.textBoxACifrar.Location = new System.Drawing.Point(7, 28);
            this.textBoxACifrar.Multiline = true;
            this.textBoxACifrar.Name = "textBoxACifrar";
            this.textBoxACifrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxACifrar.Size = new System.Drawing.Size(516, 223);
            this.textBoxACifrar.TabIndex = 11;
            this.textBoxACifrar.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxCifrado
            // 
            this.textBoxCifrado.Location = new System.Drawing.Point(6, 282);
            this.textBoxCifrado.Multiline = true;
            this.textBoxCifrado.Name = "textBoxCifrado";
            this.textBoxCifrado.ReadOnly = true;
            this.textBoxCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCifrado.Size = new System.Drawing.Size(516, 217);
            this.textBoxCifrado.TabIndex = 12;
            this.textBoxCifrado.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBoxADescifrar
            // 
            this.textBoxADescifrar.Enabled = false;
            this.textBoxADescifrar.Location = new System.Drawing.Point(547, 28);
            this.textBoxADescifrar.Multiline = true;
            this.textBoxADescifrar.Name = "textBoxADescifrar";
            this.textBoxADescifrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxADescifrar.Size = new System.Drawing.Size(516, 223);
            this.textBoxADescifrar.TabIndex = 13;
            this.textBoxADescifrar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxDescifrado
            // 
            this.textBoxDescifrado.Location = new System.Drawing.Point(547, 282);
            this.textBoxDescifrado.Multiline = true;
            this.textBoxDescifrado.Name = "textBoxDescifrado";
            this.textBoxDescifrado.ReadOnly = true;
            this.textBoxDescifrado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescifrado.Size = new System.Drawing.Size(516, 217);
            this.textBoxDescifrado.TabIndex = 14;
            // 
            // botonDescifrar
            // 
            this.botonDescifrar.Enabled = false;
            this.botonDescifrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonDescifrar.Location = new System.Drawing.Point(784, 253);
            this.botonDescifrar.Name = "botonDescifrar";
            this.botonDescifrar.Size = new System.Drawing.Size(82, 23);
            this.botonDescifrar.TabIndex = 15;
            this.botonDescifrar.Text = "DESCIFRAR";
            this.botonDescifrar.UseVisualStyleBackColor = true;
            this.botonDescifrar.Click += new System.EventHandler(this.botonDescifrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(529, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 472);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botonInicial);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 499);
            this.panel1.TabIndex = 17;
            // 
            // botonInicial
            // 
            this.botonInicial.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.botonInicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonInicial.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInicial.Location = new System.Drawing.Point(414, 198);
            this.botonInicial.Name = "botonInicial";
            this.botonInicial.Size = new System.Drawing.Size(231, 78);
            this.botonInicial.TabIndex = 0;
            this.botonInicial.Text = "Generar claves para iniciar";
            this.botonInicial.UseVisualStyleBackColor = false;
            this.botonInicial.Click += new System.EventHandler(this.botonInicial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonDescifrar);
            this.Controls.Add(this.textBoxDescifrado);
            this.Controls.Add(this.textBoxADescifrar);
            this.Controls.Add(this.textBoxCifrado);
            this.Controls.Add(this.textBoxACifrar);
            this.Controls.Add(this.botonCifrar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1082, 540);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSAlgorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button botonCifrar;
        private System.Windows.Forms.TextBox textBoxACifrar;
        private System.Windows.Forms.TextBox textBoxCifrado;
        private System.Windows.Forms.TextBox textBoxADescifrar;
        private System.Windows.Forms.TextBox textBoxDescifrado;
        private System.Windows.Forms.Button botonDescifrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonInicial;
    }
}

