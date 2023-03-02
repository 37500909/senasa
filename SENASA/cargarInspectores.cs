using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using SENASA.models;

namespace SENASA
{
    public partial class cargarInspectores : Form
    {
        public cargarInspectores()
        {
            InitializeComponent();


        }

        private void cargarInspectores_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textNombre.Text == "" || this.texttuinspector.Text == "") 
           
            {
                    MessageBox.Show("El Campo se Encuentra Vacio");
                }
            else { 
                String tuInspector = "";
                CargarTablaInpectores cargar = new CargarTablaInpectores();
                tuInspector = cargar.getTuInspector(this.texttuinspector.Text);
                if (tuInspector == "")
                {
                    MessageBox.Show("Desea Cargar un Nuevo Inspector?", "Esta por Cerrar la App", MessageBoxButtons.YesNo);
                    cargar.setInspectores(this.textNombre.Text, this.texttuinspector.Text);
                    MessageBox.Show("Inspector cargado exitosamente");
                }
                else
                {
                    MessageBox.Show($"El inspector {tuInspector} ya posse el codigo");
                }
                 }
            
        
        }

}
}