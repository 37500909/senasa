
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SENASA.Inspectores;
using SENASA.models;

namespace SENASA
{
    public partial class inspectores : Form
    {


        List<Inspec> lista = new List<Inspec>();
        List<String> listaNombreIspectores = new List<String>();
        List<String> listaNombreInspectores1 = new List<String>();
        List<String> listaNombreInspectores2 = new List<String>();
        
        public inspectores()
        {
            InitializeComponent();



            //lista.Add(" ");

            TraerTuinspectores getInspectores = new TraerTuinspectores();


            listaNombreIspectores.Add("");
            listaNombreInspectores1.Add("");
            listaNombreInspectores2.Add("");

            
            lista.AddRange(getInspectores.traerTuInspectores());
            foreach (var index in lista)
            {
                listaNombreIspectores.Add(index.ApellidoNombre);

            }
            foreach (var index in lista)
            {
                listaNombreInspectores1.Add(index.ApellidoNombre);
            }
            foreach (var index in lista)
            { 
            listaNombreInspectores2.Add(index.ApellidoNombre);
            }

                //lista2.AddRange(lista);

                // lista3.AddRange(tuinspectores.traerTuInspectores());
                // lista3.AddRange(lista3);


            cb_inspector1.DataSource= listaNombreIspectores;
            cb_inspector2.DataSource= listaNombreInspectores1;
            cb_inspector3.DataSource= listaNombreInspectores2;
            //cb_codigoInpector1.DataSource = lista3;
           
            



        }

        private void inspectores_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inspector Cargado en Planilla con Exito");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.texttuinspector1.Text = "";

           int index = lista.FindIndex(r => r.ApellidoNombre.Equals(this.cb_inspector1.Text));
            if(index>=0)
                
            this.texttuinspector1.Text = lista[index].Tu;
           
        }

        private void cb_inspector2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.texttuInspector2.Text = "";

            int index = lista.FindIndex(r => r.ApellidoNombre.Equals(this.cb_inspector2.Text));
            if (index >= 0)
                
            this.texttuInspector2.Text = lista[index].Tu;
        }

        private void texttuInspector3_TextChanged(object sender, EventArgs e)
        {

            int index = lista.FindIndex(r => r.ApellidoNombre.Equals(this.cb_inspector3.Text));
            if (index >= 0)
                this.texttuInspector3.Text = lista[index].Tu;
        }

        private void cb_inspector3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.texttuInspector3.Text = "";
            int index = lista.FindIndex(r => r.ApellidoNombre.Equals(this.cb_inspector3.Text));
            if (index >= 0)
                this.texttuInspector3.Text = lista[index].Tu;
        }
    }
}
