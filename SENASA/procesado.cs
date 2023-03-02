using SENASA.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENASA
{
    public partial class panelCentral : Form
    {
        public panelCentral()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void cargarFormulario(DataTable list)
        {
        this.dgv.DataSource= list;
         
        }

        private void panelCentral_Load(object sender, EventArgs e)
        {

        }
    }
}
