using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENASA.models
{
    internal class CargarTablaInpectores
    {

       
           

              public String getTuInspector(String _tuImpector)
        {
            String tuInspector = "";

             CConexion coneccion = new CConexion();
            String query = "SELECT apellido_nombre FROM cargar_inspectores where codigo_inspector= @tu";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConexion());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@tu", _tuImpector);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tuInspector  = leer[0].ToString();


                }
                coneccion.cerrarConexion();
            }
            catch (Exception e)
            {
                coneccion.cerrarConexion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            return tuInspector;
        }





        public void setInspectores(String apellido_nombre, String tuInspectores)
        {


            String query;


            query = "sp_cargar_tabla_inspector";


            CConexion coneccion = new CConexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConexion());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@as_nombre_apellido", apellido_nombre);
                cmd.Parameters.AddWithValue("@as_codigo_inspector", tuInspectores);

                cmd.ExecuteNonQuery();


                coneccion.cerrarConexion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConexion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }





        }

    }
}
