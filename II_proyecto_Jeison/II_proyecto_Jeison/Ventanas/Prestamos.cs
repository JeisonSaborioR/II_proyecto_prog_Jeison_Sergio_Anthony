using System;
using System.Windows.Forms;
using II_proyecto_Jeison.Clases;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace II_proyecto_Jeison.Ventanas
{
    public partial class Prestamos : Form
    {

        public Prestamos()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void prestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDatosEECOMPSADataSet.prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.baseDatosEECOMPSADataSet.prestamos);
         
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void prestamosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data datos = new Data();
            SqlDataReader reader = datos.buscarClientes(cedulaClient.Text);
            if (!reader.Read())
            {
                MessageBox.Show(this, "El cliente no esta registrado!");
            }
            else MessageBox.Show(this, "El cliente se encuentra registrado!");
        }
        

        /// <summary>
        /// Evento del boton de buscar prestamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string ced = (!cedBuscar.Text.Equals("")) ? cedBuscar.Text : "null";
            string cod = (!codBuscar.Text.Equals("")) ? codBuscar.Text : "null";
            Data datos = new Data();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter = datos.buscarPrestamo(ced, cod);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de Sql " + ex.Message);
            }
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        /// <summary>
        /// Evento del boton que inserta prestamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            Data datos = new Data();
            int _plazo = Convert.ToInt16(plazo.Text);
            int _interes = Convert.ToInt16(interes.Text);
            int _monto = Convert.ToInt16(monto.Text);
            int _cuota = Convert.ToInt16(cuota.Text);
            datos.insertarPrestamo(cedulaClient.Text, _cuota, _plazo, _monto, _interes);
        }

        /// <summary>
        /// Evento para filtrar los caracteres que se ingresan en el texbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cedulaClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCedula(e);
        }


        private void codBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }


        /// <summary>
        /// Funcion auxiliar para los eventos de los TexBox, Filtra los caracteres ingresados
        /// </summary>
        /// <param name="e">evento del teclado</param>
        private void validarCedula(KeyPressEventArgs e)
        {
            List<char> n = new List<char> { '0', '1', '2', '3', '4', '5','6', '7', '8', '9', '-' };
            if (!(n.Contains(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void cedBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCedula(e);
        }

        /// <summary>
        /// Funcion auxiliar para los eventos de los TexBox, Solo permite caracteres numéricos
        /// </summary>
        /// <param name="e"> evento del teclado</param>
        private void validarNumeros(KeyPressEventArgs e)
        {
            List<char> n = new List<char> { '0', '1', '2', '3', '4', '5', '7', '8', '9' };
            if (!(n.Contains(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                MessageBox.Show(this,"Editar");
            }
        }
    }
}
