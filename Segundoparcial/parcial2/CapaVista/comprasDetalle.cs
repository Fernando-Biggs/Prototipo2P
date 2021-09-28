using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using System.Data.Odbc;


namespace CapaVista
{
    public partial class comprasDetalle : Form
    {
        public comprasDetalle()
        {
            InitializeComponent();
        }
        public void llenarcombo()
        {
            cbodoc.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo();
            while (datareader.Read())
            {
                cbodoc.Items.Add(datareader[0].ToString());
            }
        }
        public void llenarcombo2()
        {
            comboBox1.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo2();
            while (datareader.Read())
            {
                comboBox1.Items.Add(datareader[0].ToString());
            }
        }

        public void llenarcombo3()
        {
            comboBox2.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo3();
            while (datareader.Read())
            {
                comboBox2.Items.Add(datareader[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new MDIParent1();
            formulario.Show();
            this.Hide();
        }
        clscontrolador cn = new clscontrolador();

        public void actualizardatagrid()
        {
            DataTable dt = cn.llenartb2();
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comprasDetalle_Load(object sender, EventArgs e)
        {
            llenarcombo();
            llenarcombo2();
            llenarcombo3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizardatagrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdoc.Text = cbodoc.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            cn.ingresarconsultaComprasDetalle(txtdoc.Text,txtCodigoProducto.Text,txtCantidad.Text,txtCostoCompra.Text,txtCodigoBodega.Text);
            MessageBox.Show("DATOS GUARDADOS EXITOSAMENTE");
            txtdoc.Clear();
            txtCostoCompra.Clear();
            txtCodigoProducto.Clear();
            txtCodigoBodega.Clear();
            txtCantidad.Clear();
            cbodoc.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtCodigoProducto.Text = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoBodega.Text = comboBox2.Text;
        }
    }
}
