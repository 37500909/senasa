using MySql.Data.MySqlClient;
using SENASA.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SENASA.Inspectores
{
    internal class TraerInspectores
    {
        public List<String>  traerInspectores()
        {

            List<String> list = new List<String>();
            String query;


            query = "SELECT apellido_nombre,codigo_inspector FROM cargar_inspectores" ;


            CConexion coneccion = new CConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConexion());

                cmd.CommandType = System.Data.CommandType.Text;
                /*
                cmd.Parameters.AddWithValue("@as_fecha_ini", fechaIni);
                cmd.Parameters.AddWithValue("@as_fecha_fin", fechaFin);
                */
                cmd.ExecuteScalar();
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    //TarjetonVentanaCalibre lectura = new TarjetonVentanaCalibre(leer[0].ToString(), leer[1].ToString());

                    /*   Procesado lectura = new Procesado(leer[0] is DBNull ? 0 : Convert.ToInt32(leer[0]), leer[1].ToString(), leer[2] is DBNull ? 0 : Convert.ToInt32(leer[2]), leer[3].ToString(),
                                           leer[4] is DBNull ? 0 : Convert.ToInt16(leer[4]), leer[5].ToString(), leer[6].ToString(), leer[7] is DBNull ? 0 : Convert.ToInt16(leer[7]), leer[8] is DBNull ? 0 : Convert.ToDecimal(leer[8]),
                                           leer[9].ToString(), leer[10].ToString(), leer[11] is DBNull ? 0 : Convert.ToDecimal(leer[11]), leer[12] is DBNull ? 0 : Convert.ToInt16(leer[12]));
                    */
                    String lectura = leer[0].ToString();
                    list.Add(lectura);


                }
                coneccion.cerrarConexion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConexion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }



            return list;


        }



    }
}
