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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plazo = new System.Windows.Forms.TextBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotaMensualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDatosEECOMPSADataSet = new II_proyecto_Jeison.baseDatosEECOMPSADataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.cedBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.baseDatosEECOMPSADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new II_proyecto_Jeison.baseDatosEECOMPSADataSetTableAdapters.prestamosTableAdapter();
            this.tableAdapterManager = new II_proyecto_Jeison.baseDatosEECOMPSADataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosEECOMPSADataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosEECOMPSADataSetBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(743, 460);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(735, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo Préstamo";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(370, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 355);
            this.panel4.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tipo de terreno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Experiencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Actividad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre del Proyecto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.plazo);
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
            this.panel3.Size = new System.Drawing.Size(306, 355);
            this.panel3.TabIndex = 0;
            // 
            // plazo
            // 
            this.plazo.Location = new System.Drawing.Point(111, 118);
            this.plazo.Name = "plazo";
            this.plazo.Size = new System.Drawing.Size(124, 20);
            this.plazo.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Verificar( para prueba)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuota
            // 
            this.cuota.Location = new System.Drawing.Point(111, 279);
            this.cuota.Name = "cuota";
            this.cuota.Size = new System.Drawing.Size(121, 20);
            this.cuota.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cuota Mensual";
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(111, 227);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(124, 20);
            this.monto.TabIndex = 32;
            // 
            // interes
            // 
            this.interes.Location = new System.Drawing.Point(111, 175);
            this.interes.Name = "interes";
            this.interes.Size = new System.Drawing.Size(124, 20);
            this.interes.TabIndex = 31;
            // 
            // cedulaClient
            // 
            this.cedulaClient.Location = new System.Drawing.Point(111, 57);
            this.cedulaClient.Name = "cedulaClient";
            this.cedulaClient.Size = new System.Drawing.Size(121, 20);
            this.cedulaClient.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tasa de Interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Plazo (meses)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cédula Cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Crear Préstamo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(8, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 311);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPrestamoDataGridViewTextBoxColumn,
            this.cedClienteDataGridViewTextBoxColumn,
            this.cuotaMensualDataGridViewTextBoxColumn,
            this.plazoDataGridViewTextBoxColumn,
            this.tasaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridView1.DataSource = this.prestamosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "modificar";
            this.Edit.UseColumnTextForButtonValue = true;
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
            this.panel1.Location = new System.Drawing.Point(87, 20);
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
            this.cedBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedBuscar_KeyPress);
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
            this.codBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codBuscar_KeyPress);
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
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(735, 434);
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
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosEECOMPSADataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosEECOMPSADataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox plazo;
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotaMensualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}