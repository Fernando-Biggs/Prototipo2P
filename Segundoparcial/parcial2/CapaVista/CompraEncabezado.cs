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
    public partial class CompraEncabezado : Form
    {
        public CompraEncabezado()
        {
            InitializeComponent();
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
            DataTable dt = cn.llenartb1();
            dataGridView1.DataSource = dt;
        }




        private void button2_Click(object sender, EventArgs e)
        {
            cn.ingresarconsultaComprasEn(txtdoc.Text,txtcodproveedor.Text,txtfecha.Text,txtcompra.Text,txtestatus.Text);

            MessageBox.Show("DATOS GUARDADOS EXITOSAMENTE");
            txtestatus.Clear();
            txtdoc.Clear();
            txtcompra.Clear();
            txtcodproveedor.Clear();
            txtfecha.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizardatagrid();
        }

        private void CompraEncabezado_Load(object sender, EventArgs e)
        {

        }
    }
}
