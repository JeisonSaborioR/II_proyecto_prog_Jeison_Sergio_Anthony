namespace II_proyecto_Jeison.Ventanas
{
    partial class Prestamos
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plazo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cuota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.interes = new System.Windows.Forms.TextBox();
            this.cedulaClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotaMensualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDatosEECOMPSADataSet = new II_proyecto_Jeison.baseDatosEECOMPSADataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.cedBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baseDatosEECOMPSADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new II_proyecto_Jeison.baseDatosEECOMPSADataSetTableAdapters.prestamosTableAdapter();
            this.tableAdapterManager = new II_proyecto_Jeison.baseDatosEECOMPSADataSetTableAdapters.TableAdapterManager();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosEECOMPSADataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosEECOMPSADataSetBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo Préstamo";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.plazo);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.cuota);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.monto);
            this.panel3.Controls.Add(this.interes);
            this.panel3.Controls.Add(this.cedulaClient);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(27, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 386);
            this.panel3.TabIndex = 0;
            // 
            // plazo
            // 
            this.plazo.Location = new System.Drawing.Point(172, 81);
            this.plazo.Name = "plazo";
            this.plazo.Size = new System.Drawing.Size(207, 20);
            this.plazo.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Crear Préstamo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Verificar( para prueba)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuota
            // 
            this.cuota.Location = new System.Drawing.Point(172, 277);
            this.cuota.Name = "cuota";
            this.cuota.Size = new System.Drawing.Size(207, 20);
            this.cuota.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cuota Mensual";
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(172, 205);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(207, 20);
            this.monto.TabIndex = 20;
            // 
            // interes
            // 
            this.interes.Location = new System.Drawing.Point(172, 134);
            this.interes.Name = "interes";
            this.interes.Size = new System.Drawing.Size(207, 20);
            this.interes.TabIndex = 19;
            // 
            // cedulaClient
            // 
            this.cedulaClient.Location = new System.Drawing.Point(172, 20);
            this.cedulaClient.Name = "cedulaClient";
            this.cedulaClient.Size = new System.Drawing.Size(207, 20);
            this.cedulaClient.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tasa de Interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Plazo (meses)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cédula Cliente";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(25, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 311);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPrestamoDataGridViewTextBoxColumn,
            this.cedClienteDataGridViewTextBoxColumn,
            this.cuotaMensualDataGridViewTextBoxColumn,
            this.plazoDataGridViewTextBoxColumn,
            this.tasaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prestamosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // codPrestamoDataGridViewTextBoxColumn
            // 
            this.codPrestamoDataGridViewTextBoxColumn.DataPropertyName = "codPrestamo";
            this.codPrestamoDataGridViewTextBoxColumn.HeaderText = "codPrestamo";
            this.codPrestamoDataGridViewTextBoxColumn.Name = "codPrestamoDataGridViewTextBoxColumn";
            this.codPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedClienteDataGridViewTextBoxColumn
            // 
            this.cedClienteDataGridViewTextBoxColumn.DataPropertyName = "cedCliente";
            this.cedClienteDataGridViewTextBoxColumn.HeaderText = "cedCliente";
            this.cedClienteDataGridViewTextBoxColumn.Name = "cedClienteDataGridViewTextBoxColumn";
            // 
            // cuotaMensualDataGridViewTextBoxColumn
            // 
            this.cuotaMensualDataGridViewTextBoxColumn.DataPropertyName = "cuotaMensual";
            this.cuotaMensualDataGridViewTextBoxColumn.HeaderText = "cuotaMensual";
            this.cuotaMensualDataGridViewTextBoxColumn.Name = "cuotaMensualDataGridViewTextBoxColumn";
            // 
            // plazoDataGridViewTextBoxColumn
            // 
            this.plazoDataGridViewTextBoxColumn.DataPropertyName = "plazo";
            this.plazoDataGridViewTextBoxColumn.HeaderText = "plazo";
            this.plazoDataGridViewTextBoxColumn.Name = "plazoDataGridViewTextBoxColumn";
            // 
            // tasaDataGridViewTextBoxColumn
            // 
            this.tasaDataGridViewTextBoxColumn.DataPropertyName = "tasa";
            this.tasaDataGridViewTextBoxColumn.HeaderText = "tasa";
            this.tasaDataGridViewTextBoxColumn.Name = "tasaDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "prestamos";
            this.prestamosBindingSource.DataSource = this.baseDatosEECOMPSADataSet;
            // 
            // baseDatosEECOMPSADataSet
            // 
            this.baseDatosEECOMPSADataSet.DataSetName = "baseDatosEECOMPSADataSet";
            this.baseDatosEECOMPSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cedBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.codBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 60);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cedBuscar
            // 
            this.cedBuscar.Location = new System.Drawing.Point(242, 23);
            this.cedBuscar.Name = "cedBuscar";
            this.cedBuscar.Size = new System.Drawing.Size(120, 20);
            this.cedBuscar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cédula Cliente";
            // 
            // codBuscar
            // 
            this.codBuscar.Location = new System.Drawing.Point(106, 23);
            this.codBuscar.Name = "codBuscar";
            this.codBuscar.Size = new System.Drawing.Size(113, 20);
            this.codBuscar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código del préstamo";
            // 
            // baseDatosEECOMPSADataSetBindingSource
            // 
            this.baseDatosEECOMPSADataSetBindingSource.DataSource = this.baseDatosEECOMPSADataSet;
            this.baseDatosEECOMPSADataSetBindingSource.Position = 0;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bienesTableAdapter = null;
            this.tableAdapterManager.cantonesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.datosClientesTableAdapter = null;
            this.tableAdapterManager.distritosTableAdapter = null;
            this.tableAdapterManager.emailTableAdapter = null;
            this.tableAdapterManager.excedentesTableAdapter = null;
            this.tableAdapterManager.fiadorPrestamoTableAdapter = null;
            this.tableAdapterManager.fiadorTableAdapter = null;
            this.tableAdapterManager.informacionBancariaTableAdapter = null;
            this.tableAdapterManager.ordenPatronalTableAdapter = null;
            this.tableAdapterManager.pagosTableAdapter = null;
            this.tableAdapterManager.personasTableAdapter = null;
            this.tableAdapterManager.prestamoBienesTableAdapter = null;
            this.tableAdapterManager.prestamosTableAdapter = this.prestamosTableAdapter;
            this.tableAdapterManager.provinciasTableAdapter = null;
            this.tableAdapterManager.proyectosTableAdapter = null;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.telefonoPersonasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = II_proyecto_Jeison.baseDatosEECOMPSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(654, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(651, 431);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(643, 405);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Realizar Pago";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(643, 405);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Buscar Pagos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosEECOMPSADataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosEECOMPSADataSetBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cedBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource baseDatosEECOMPSADataSetBindingSource;
        private baseDatosEECOMPSADataSet baseDatosEECOMPSADataSet;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private baseDatosEECOMPSADataSetTableAdapters.prestamosTableAdapter prestamosTableAdapter;
        private baseDatosEECOMPSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox plazo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cuota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.TextBox interes;
        private System.Windows.Forms.TextBox cedulaClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotaMensualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}