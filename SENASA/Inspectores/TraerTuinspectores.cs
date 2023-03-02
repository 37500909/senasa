using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using SENASA.models;

namespace SENASA.Inspectores
{
    internal class TraerTuinspectores
    {
        public List<Inspec> traerTuInspectores()
        {
            List<Inspec> list = new List<Inspec>();
            String query;

            
            query = "SELECT * FROM cargar_inspectores";


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

                    Inspec lectura = new Inspec(leer[0].ToString(), leer[1].ToString(), leer[2].ToString());
                    
                    
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
