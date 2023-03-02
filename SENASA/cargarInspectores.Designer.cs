namespace SENASA
{
    partial class cargarInspectores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.codigoinspector = new System.Windows.Forms.Label();
            this.texttuinspector = new System.Windows.Forms.TextBox();
            this.nombreinspector = new System.Windows.Forms.Label();
            this.btcargarInspectores = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "CARGAR INSPECTOR NUEVO";
            // 
            // codigoinspector
            // 
            this.codigoinspector.AutoSize = true;
            this.codigoinspector.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigoinspector.Location = new System.Drawing.Point(12, 90);
            this.codigoinspector.Name = "codigoinspector";
            this.codigoinspector.Size = new System.Drawing.Size(151, 20);
            this.codigoinspector.TabIndex = 21;
            this.codigoinspector.Text = "CODIGO INSPECTOR";
            // 
            // texttuinspector
            // 
            this.texttuinspector.Location = new System.Drawing.Point(169, 91);
            this.texttuinspector.Name = "texttuinspector";
            this.texttuinspector.Size = new System.Drawing.Size(169, 23);
            this.texttuinspector.TabIndex = 20;
            // 
            // nombreinspector
            // 
            this.nombreinspector.AutoSize = true;
            this.nombreinspector.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nombreinspector.Location = new System.Drawing.Point(1, 61);
            this.nombreinspector.Name = "nombreinspector";
            this.nombreinspector.Size = new System.Drawing.Size(162, 20);
            this.nombreinspector.TabIndex = 19;
            this.nombreinspector.Text = "APELLIDO Y NOMBRE";
            // 
            // btcargarInspectores
            // 
            this.btcargarInspectores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btcargarInspectores.FlatAppearance.BorderSize = 2;
            this.btcargarInspectores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btcargarInspectores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btcargarInspectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcargarInspectores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcargarInspectores.ForeColor = System.Drawing.Color.Black;
            this.btcargarInspectores.Location = new System.Drawing.Point(73, 141);
            this.btcargarInspectores.Name = "btcargarInspectores";
            this.btcargarInspectores.Size = new System.Drawing.Size(265, 30);
            this.btcargarInspectores.TabIndex = 27;
            this.btcargarInspectores.Text = "NUEVO";
            this.btcargarInspectores.UseVisualStyleBackColor = true;
            this.btcargarInspectores.Click += new System.EventHandler(this.button2_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(169, 58);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(169, 23);
            this.textNombre.TabIndex = 30;
            // 
            // cargarInspectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 317);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigoinspector);
            this.Controls.Add(this.texttuinspector);
            this.Controls.Add(this.nombreinspector);
            this.Controls.Add(this.btcargarInspectores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cargarInspectores";
            this.Text = "cargarInspectores";
            this.Load += new System.EventHandler(this.cargarInspectores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label codigoinspector;
        private TextBox texttuinspector;
        private Label nombreinspector;
        private Button btcargarInspectores;
        private TextBox textNombre;
    }
}