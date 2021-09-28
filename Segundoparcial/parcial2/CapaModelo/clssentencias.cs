using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo
{
    public class clssentencias
    {
        clsconexion con = new clsconexion();
        public OdbcDataAdapter llenartb1() //Metodo que obtiene el contenido de una tabla
        {
            string sql = "select * from compras_encabezado;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataAdapter llenartb2() //Metodo que obtiene el contenido de una tabla
        {
            string sql = "select * from compras_detalle;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        //Llenar los combobox
        public OdbcDataReader llenarcbotabla(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        //Hacer insert update o delete
        public void insertarconsulta(string cadena)
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo" + Error);
            }
        }


    }
}
