using System;
using System.Windows.Forms;
using II_proyecto_Jeison.Clases;
using System.Data.SqlClient;
using System.Data;

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
            SqlDataReader reader = datos.buscarPersona(cedulaClient.Text);
            if (!reader.Read())
            {
                MessageBox.Show("La persona no se encuentra registrada!");
            }
            else MessageBox.Show("La persona se encuentra registrada!");
        }

      
 
        private void button3_Click(object sender, EventArgs e)
        {
            Data datos = new Data();
            SqlDataAdapter adapter = datos.buscarPrestamo(cedBuscar.Text);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Data datos = new Data();
            int _plazo = Convert.ToInt16(plazo.Text);
            int _interes = Convert.ToInt16(interes.Text);
            int _monto = Convert.ToInt16(monto.Text);
            int _cuota = Convert.ToInt16(cuota.Text);
            datos.insertarPrestamo(cedulaClient.Text, _cuota, _plazo, _monto, _interes);
        }

    }
}
