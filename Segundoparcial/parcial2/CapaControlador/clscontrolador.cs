using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Data.Odbc;

namespace CapaControlador
{
    public class clscontrolador
    {
        clssentencias sn = new clssentencias();
        //Llenar una tabla datagrid capa controlador
        public DataTable llenartb1()
        {
            OdbcDataAdapter dt = sn.llenartb1();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable llenartb2()
        {
            OdbcDataAdapter dt = sn.llenartb2();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Llenar un combobox
        public OdbcDataReader llenarcbo()
        {
            string sql = "SELECT documento_compraenca FROM compras_encabezado";
            return sn.llenarcbotabla(sql);
        }
        public OdbcDataReader llenarcbo2()
        {
            string sql = "SELECT codigo_producto FROM productos";
            return sn.llenarcbotabla(sql);
        }
        public OdbcDataReader llenarcbo3()
        {
            string sql = "SELECT codigo_bodega FROM bodegas";
            return sn.llenarcbotabla(sql);
        }

        //Para hacer un insert o un update o un delete
        public void ingresarconsultaComprasDetalle(string id, string codigoP, string cantidad, string total, string codBodega)
        {
            string sql = "insert into compras_detalle values ( '" + id + "', '" + codigoP + "','" + cantidad + "','" + total + "','" + codBodega + "') ;";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
        public void ingresarconsultaComprasEn(string id, string codP, string fecha, string costo, string codigo_bodega)
        {
            string sql = "insert into compras_encabezado values ( '" + id + "', '" + codP + "', '" + fecha + "', '" + costo + "', '" + codigo_bodega + "') ;";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
    }
}
