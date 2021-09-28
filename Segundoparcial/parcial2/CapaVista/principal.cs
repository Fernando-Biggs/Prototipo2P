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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        clscontrolador cn = new clscontrolador();
   
        public void actualizardatagrid()
        {
            DataTable dt = cn.llenartb1();
            dataGridView1.DataSource = dt;
        }
        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagrid();
            llenarcombo();
        }
        //Llenar el combobox, lo mandas a llamar donde lo necesite
        public void llenarcombo()
        {
            comboBox1.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo();
            while (datareader.Read())
            {
                comboBox1.Items.Add(datareader[0].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Para hacer el insert, update o delete
        //Esta no esta en una funcion, la mando a llamar directamente segun sus parametros
        //cn.ingresarconsulta(txtNombreConsulta.Text, txtCadenaGenerada.Text);





    }
}
