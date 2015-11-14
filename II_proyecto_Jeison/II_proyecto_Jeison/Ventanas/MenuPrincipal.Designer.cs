namespace II_proyecto_Jeison.Ventanas
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtoConsultas = new System.Windows.Forms.Button();
            this.BtoPrestamos = new System.Windows.Forms.Button();
            this.BtoRegistro = new System.Windows.Forms.Button();
            this.BtoSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtoConsultas
            // 
            this.BtoConsultas.Image = global::II_proyecto_Jeison.Properties.Resources._318_9565;
            this.BtoConsultas.Location = new System.Drawing.Point(27, 172);
            this.BtoConsultas.Name = "BtoConsultas";
            this.BtoConsultas.Size = new System.Drawing.Size(114, 118);
            this.BtoConsultas.TabIndex = 2;
            this.BtoConsultas.UseVisualStyleBackColor = true;
            // 
            // BtoPrestamos
            // 
            this.BtoPrestamos.Image = global::II_proyecto_Jeison.Properties.Resources.prestamo;
            this.BtoPrestamos.Location = new System.Drawing.Point(184, 29);
            this.BtoPrestamos.Name = "BtoPrestamos";
            this.BtoPrestamos.Size = new System.Drawing.Size(112, 124);
            this.BtoPrestamos.TabIndex = 1;
            this.BtoPrestamos.UseVisualStyleBackColor = true;
            // 
            // BtoRegistro
            // 
            this.BtoRegistro.Image = global::II_proyecto_Jeison.Properties.Resources.registro;
            this.BtoRegistro.Location = new System.Drawing.Point(27, 29);
            this.BtoRegistro.Name = "BtoRegistro";
            this.BtoRegistro.Size = new System.Drawing.Size(114, 124);
            this.BtoRegistro.TabIndex = 0;
            this.BtoRegistro.UseVisualStyleBackColor = true;
            this.BtoRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtoSalir
            // 
            this.BtoSalir.Image = global::II_proyecto_Jeison.Properties.Resources.salir;
            this.BtoSalir.Location = new System.Drawing.Point(184, 172);
            this.BtoSalir.Name = "BtoSalir";
            this.BtoSalir.Size = new System.Drawing.Size(112, 118);
            this.BtoSalir.TabIndex = 3;
            this.BtoSalir.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 302);
            this.Controls.Add(this.BtoSalir);
            this.Controls.Add(this.BtoConsultas);
            this.Controls.Add(this.BtoPrestamos);
            this.Controls.Add(this.BtoRegistro);
            this.Name = "MenuPrincipal";
            this.Text = "EECOMPSA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtoRegistro;
        private System.Windows.Forms.Button BtoPrestamos;
        private System.Windows.Forms.Button BtoConsultas;
        private System.Windows.Forms.Button BtoSalir;
    }
}