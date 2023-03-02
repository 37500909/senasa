using SENASA.models;
using System.Data;
using System.Runtime.InteropServices;


namespace SENASA
{   
    

    public partial class Form1 : Form
    {
        List<String> horarioIni = new List<String>();
        List<String> horarioFin = new List<String>();

        public Form1()
        {
            InitializeComponent();
            cargarCombo();

           
                       
    
            horarioFin.AddRange(horarioIni);

            cb_horaIni.DataSource= horarioIni;
            cb_horaFin.DataSource= horarioFin;


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cargarCombo()
        {
            int i, j;

            for (i = 0; i < 24; i++)
            {
                for (j = 0; j < 60; j++)
                {
                    var hora = i.ToString("D2");
                    var minutos = j.ToString("D2");
                    if (i > 11)
                        horarioIni.Add($"{hora}:{minutos} PM");
                    else
                        horarioIni.Add($"{hora}:{minutos} AM");
                    j = j + 4;
                }
            }
            i++;
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
                menuVertical.Width = 65;

            else
                menuVertical.Width = 250;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cerrar la App?", "Esta por Cerrar la App", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void iconoRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;


            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            iconoRestaurar.Visible = false;
            iconoMaximizar.Visible = true;

        }
        int LX, LY, SW, SH;

        private void iconoMaximizar_Click(object sender, EventArgs e)
        {
            // this.WindowState |= FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconoRestaurar.Visible = true;
            iconoMaximizar.Visible = false;


            


        }

     

        private void btprocesado_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            panelCentral frm = new panelCentral();
            frm.TopLevel= false ;
            frm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frm);
            
            frm.Show();

            CargarDataGrid cargarDataGrid = new CargarDataGrid();
            ListToDataTableConverter listToDataTableConverter = new ListToDataTableConverter();
            DataTable dt = listToDataTableConverter.ToDataTable(cargarDataGrid.getDataGrid(this.dateTimePicker1.Text, this.dateTimePicker2.Text));
            frm.cargarFormulario(dt);

        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            inspectores frm = new inspectores();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frm);

            frm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // MessageBox.Show((this.dateTimePicker1.Text).Substring(0,9));
        }

        private void btcargarinspectores_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            cargarInspectores frm = new cargarInspectores();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frm);

            frm.Show();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
            CConexion objetoconexion = new CConexion();
            objetoconexion.establecerConexion();
        }

        private void cb_horaIni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_horaFin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {
         //   ReleaseCapture();
           // SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        

    }
    
   
}