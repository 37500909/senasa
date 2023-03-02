namespace SENASA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.cb_horaFin = new System.Windows.Forms.ComboBox();
            this.cb_horaIni = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btcargarinspectores = new System.Windows.Forms.Button();
            this.btinspectores = new System.Windows.Forms.Button();
            this.btprocesado = new System.Windows.Forms.Button();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.iconoMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.INICIO = new System.Windows.Forms.Label();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.botonConfiguracion = new System.Windows.Forms.PictureBox();
            this.iconoMaximizar = new System.Windows.Forms.PictureBox();
            this.iconoRestaurar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(116)))));
            this.menuVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuVertical.Controls.Add(this.pictureBox2);
            this.menuVertical.Controls.Add(this.button4);
            this.menuVertical.Controls.Add(this.button5);
            this.menuVertical.Controls.Add(this.btcargarinspectores);
            this.menuVertical.Controls.Add(this.btinspectores);
            this.menuVertical.Controls.Add(this.btprocesado);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(247, 650);
            this.menuVertical.TabIndex = 0;
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // cb_horaFin
            // 
            this.cb_horaFin.FormattingEnabled = true;
            this.cb_horaFin.Location = new System.Drawing.Point(588, 16);
            this.cb_horaFin.Name = "cb_horaFin";
            this.cb_horaFin.Size = new System.Drawing.Size(103, 23);
            this.cb_horaFin.TabIndex = 4;
            this.cb_horaFin.SelectedIndexChanged += new System.EventHandler(this.cb_horaFin_SelectedIndexChanged);
            // 
            // cb_horaIni
            // 
            this.cb_horaIni.FormattingEnabled = true;
            this.cb_horaIni.Location = new System.Drawing.Point(312, 15);
            this.cb_horaIni.Name = "cb_horaIni";
            this.cb_horaIni.Size = new System.Drawing.Size(103, 23);
            this.cb_horaIni.TabIndex = 0;
            this.cb_horaIni.SelectedIndexChanged += new System.EventHandler(this.cb_horaIni_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(116)))));
            this.button4.BackgroundImage = global::SENASA.Properties.Resources.icono_de_limon21;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Turquoise;
            this.button4.Location = new System.Drawing.Point(0, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "IMPRIMIR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(116)))));
            this.button5.BackgroundImage = global::SENASA.Properties.Resources.icono_de_limon21;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Turquoise;
            this.button5.Location = new System.Drawing.Point(0, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "VISTA PREVIA";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btcargarinspectores
            // 
            this.btcargarinspectores.AutoSize = true;
            this.btcargarinspectores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(116)))));
            this.btcargarinspectores.BackgroundImage = global::SENASA.Properties.Resources.icono_de_limon21;
            this.btcargarinspectores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btcargarinspectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcargarinspectores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcargarinspectores.ForeColor = System.Drawing.Color.Turquoise;
            this.btcargarinspectores.Location = new System.Drawing.Point(0, 216);
            this.btcargarinspectores.Name = "btcargarinspectores";
            this.btcargarinspectores.Size = new System.Drawing.Size(238, 50);
            this.btcargarinspectores.TabIndex = 3;
            this.btcargarinspectores.Text = "CARGAR INSPECTOR";
            this.btcargarinspectores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcargarinspectores.UseVisualStyleBackColor = false;
            this.btcargarinspectores.Click += new System.EventHandler(this.btcargarinspectores_Click);
            // 
            // btinspectores
            // 
            this.btinspectores.AutoSize = true;
            this.btinspectores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(116)))));
            this.btinspectores.BackgroundImage = global::SENASA.Properties.Resources.icono_de_limon21;
            this.btinspectores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btinspectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btinspectores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btinspectores.ForeColor = System.Drawing.Color.Turquoise;
            this.btinspectores.Location = new System.Drawing.Point(0, 148);
            this.btinspectores.Name = "btinspectores";
            this.btinspectores.Size = new System.Drawing.Size(238, 50);
            this.btinspectores.TabIndex = 2;
            this.btinspectores.Text = "INSPECTORES";
            this.btinspectores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btinspectores.UseVisualStyleBackColor = false;
            this.btinspectores.Click += new System.EventHandler(this.button1_Click);
            // 
            // btprocesado
            // 
            this.btprocesado.AutoSize = true;
            this.btprocesado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(116)))));
            this.btprocesado.BackgroundImage = global::SENASA.Properties.Resources.icono_de_limon21;
            this.btprocesado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btprocesado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btprocesado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btprocesado.ForeColor = System.Drawing.Color.Turquoise;
            this.btprocesado.Location = new System.Drawing.Point(0, 82);
            this.btprocesado.Name = "btprocesado";
            this.btprocesado.Size = new System.Drawing.Size(238, 50);
            this.btprocesado.TabIndex = 1;
            this.btprocesado.Text = "PROCESADO";
            this.btprocesado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btprocesado.UseVisualStyleBackColor = false;
            this.btprocesado.Click += new System.EventHandler(this.btprocesado_Click);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.barraTitulo.Controls.Add(this.cb_horaFin);
            this.barraTitulo.Controls.Add(this.dateTimePicker1);
            this.barraTitulo.Controls.Add(this.cb_horaIni);
            this.barraTitulo.Controls.Add(this.button2);
            this.barraTitulo.Controls.Add(this.iconoMinimizar);
            this.barraTitulo.Controls.Add(this.label1);
            this.barraTitulo.Controls.Add(this.dateTimePicker2);
            this.barraTitulo.Controls.Add(this.INICIO);
            this.barraTitulo.Controls.Add(this.iconoCerrar);
            this.barraTitulo.Controls.Add(this.botonConfiguracion);
            this.barraTitulo.Controls.Add(this.iconoMaximizar);
            this.barraTitulo.Controls.Add(this.iconoRestaurar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(247, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1053, 64);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 22, 11, 49, 9, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(706, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iconoMinimizar
            // 
            this.iconoMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMinimizar.Image")));
            this.iconoMinimizar.Location = new System.Drawing.Point(912, 4);
            this.iconoMinimizar.Name = "iconoMinimizar";
            this.iconoMinimizar.Size = new System.Drawing.Size(58, 51);
            this.iconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMinimizar.TabIndex = 0;
            this.iconoMinimizar.TabStop = false;
            this.iconoMinimizar.Click += new System.EventHandler(this.iconoMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(430, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(472, 16);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 23);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2023, 2, 17, 11, 21, 0, 0);
            // 
            // INICIO
            // 
            this.INICIO.AutoSize = true;
            this.INICIO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.INICIO.Location = new System.Drawing.Point(143, 16);
            this.INICIO.Name = "INICIO";
            this.INICIO.Size = new System.Drawing.Size(60, 21);
            this.INICIO.TabIndex = 0;
            this.INICIO.Text = "INICIO";
            this.INICIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrar.Image")));
            this.iconoCerrar.Location = new System.Drawing.Point(1010, 10);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(43, 41);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrar.TabIndex = 3;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // botonConfiguracion
            // 
            this.botonConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConfiguracion.Dock = System.Windows.Forms.DockStyle.Left;
            this.botonConfiguracion.Image = global::SENASA.Properties.Resources.Sin_título;
            this.botonConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.botonConfiguracion.Name = "botonConfiguracion";
            this.botonConfiguracion.Size = new System.Drawing.Size(49, 64);
            this.botonConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonConfiguracion.TabIndex = 0;
            this.botonConfiguracion.TabStop = false;
            this.botonConfiguracion.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconoMaximizar
            // 
            this.iconoMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMaximizar.Image = global::SENASA.Properties.Resources.agrandar;
            this.iconoMaximizar.Location = new System.Drawing.Point(963, 10);
            this.iconoMaximizar.Name = "iconoMaximizar";
            this.iconoMaximizar.Size = new System.Drawing.Size(55, 41);
            this.iconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMaximizar.TabIndex = 2;
            this.iconoMaximizar.TabStop = false;
            this.iconoMaximizar.Click += new System.EventHandler(this.iconoMaximizar_Click);
            // 
            // iconoRestaurar
            // 
            this.iconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoRestaurar.Image = global::SENASA.Properties.Resources.agrandar;
            this.iconoRestaurar.Location = new System.Drawing.Point(963, 10);
            this.iconoRestaurar.Name = "iconoRestaurar";
            this.iconoRestaurar.Size = new System.Drawing.Size(50, 41);
            this.iconoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoRestaurar.TabIndex = 1;
            this.iconoRestaurar.TabStop = false;
            this.iconoRestaurar.Click += new System.EventHandler(this.iconoRestaurar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(247, 64);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1053, 586);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuVertical;
        private Panel barraTitulo;
        private PictureBox pictureBox2;
        private PictureBox botonConfiguracion;
        private PictureBox iconoCerrar;
        private PictureBox iconoMaximizar;
        private PictureBox iconoRestaurar;
        private PictureBox iconoMinimizar;
        private Panel panelContenedor;
        private Button btprocesado;
        private Button btinspectores;
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button5;
        private Button btcargarinspectores;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label INICIO;
        private Button button2;
        private ComboBox cb_horaFin;
        private ComboBox cb_horaIni;
    }
}