using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SENASA
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();


        static string servidor = "192.168.41.40";
        static string basedatos = "pm_vtrapani2020_prueba";
        static string usuario = "cons_vtrapani";
        static string password = "v7r4p4n1";
        static string puerto = "3306";


        string cadenaconexion = "server=" + servidor + ";" +
                                "port=" + puerto + ";" +
                                "user id=" + usuario + ";" +
                                "password=" + password + ";" +
                                "database=" + basedatos + ";";

        public MySqlConnection establecerConexion()
        {
            try{
                conex.ConnectionString = cadenaconexion;
            conex.Open();
              
            }
            catch (MySqlException e){
                MessageBox.Show("No Fue Posible Realizar la Conexion, Erro:"+e.ToString());
            }
            return conex;
        }


        public void cerrarConexion()
        {
            conex.Close();
            conex.Dispose();
        }
    }
}
