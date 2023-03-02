namespace SENASA
{
    partial class inspectores
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
            this.nombreinspector = new System.Windows.Forms.Label();
            this.texttuinspector1 = new System.Windows.Forms.TextBox();
            this.codigoinspector = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.texttuInspector2 = new System.Windows.Forms.TextBox();
            this.texttuInspector3 = new System.Windows.Forms.TextBox();
            this.cb_inspector1 = new System.Windows.Forms.ComboBox();
            this.cb_inspector2 = new System.Windows.Forms.ComboBox();
            this.cb_inspector3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nombreinspector
            // 
            this.nombreinspector.AutoSize = true;
            this.nombreinspector.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nombreinspector.Location = new System.Drawing.Point(3, 51);
            this.nombreinspector.Name = "nombreinspector";
            this.nombreinspector.Size = new System.Drawing.Size(162, 20);
            this.nombreinspector.TabIndex = 0;
            this.nombreinspector.Text = "APELLIDO Y NOMBRE";
            // 
            // texttuinspector1
            // 
            this.texttuinspector1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.texttuinspector1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texttuinspector1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.texttuinspector1.Location = new System.Drawing.Point(171, 82);
            this.texttuinspector1.Name = "texttuinspector1";
            this.texttuinspector1.Size = new System.Drawing.Size(169, 18);
            this.texttuinspector1.TabIndex = 3;
            // 
            // codigoinspector
            // 
            this.codigoinspector.AutoSize = true;
            this.codigoinspector.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigoinspector.Location = new System.Drawing.Point(14, 80);
            this.codigoinspector.Name = "codigoinspector";
            this.codigoinspector.Size = new System.Drawing.Size(151, 20);
            this.codigoinspector.TabIndex = 4;
            this.codigoinspector.Text = "CODIGO INSPECTOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "INSPECTORES DEL PROCESO";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(198, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(460, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "GUARDAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // texttuInspector2
            // 
            this.texttuInspector2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.texttuInspector2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texttuInspector2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.texttuInspector2.Location = new System.Drawing.Point(346, 82);
            this.texttuInspector2.Name = "texttuInspector2";
            this.texttuInspector2.Size = new System.Drawing.Size(169, 18);
            this.texttuInspector2.TabIndex = 14;
            // 
            // texttuInspector3
            // 
            this.texttuInspector3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.texttuInspector3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texttuInspector3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.texttuInspector3.Location = new System.Drawing.Point(521, 82);
            this.texttuInspector3.Name = "texttuInspector3";
            this.texttuInspector3.Size = new System.Drawing.Size(169, 18);
            this.texttuInspector3.TabIndex = 15;
            this.texttuInspector3.TextChanged += new System.EventHandler(this.texttuInspector3_TextChanged);
            // 
            // cb_inspector1
            // 
            this.cb_inspector1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_inspector1.FormattingEnabled = true;
            this.cb_inspector1.Location = new System.Drawing.Point(171, 48);
            this.cb_inspector1.Name = "cb_inspector1";
            this.cb_inspector1.Size = new System.Drawing.Size(169, 24);
            this.cb_inspector1.TabIndex = 16;
            this.cb_inspector1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_inspector2
            // 
            this.cb_inspector2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_inspector2.FormattingEnabled = true;
            this.cb_inspector2.Location = new System.Drawing.Point(346, 48);
            this.cb_inspector2.Name = "cb_inspector2";
            this.cb_inspector2.Size = new System.Drawing.Size(169, 24);
            this.cb_inspector2.TabIndex = 17;
            this.cb_inspector2.SelectedIndexChanged += new System.EventHandler(this.cb_inspector2_SelectedIndexChanged);
            // 
            // cb_inspector3
            // 
            this.cb_inspector3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_inspector3.FormattingEnabled = true;
            this.cb_inspector3.Location = new System.Drawing.Point(521, 48);
            this.cb_inspector3.Name = "cb_inspector3";
            this.cb_inspector3.Size = new System.Drawing.Size(169, 24);
            this.cb_inspector3.TabIndex = 18;
            this.cb_inspector3.SelectedIndexChanged += new System.EventHandler(this.cb_inspector3_SelectedIndexChanged);
            // 
            // inspectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(699, 294);
            this.Controls.Add(this.cb_inspector3);
            this.Controls.Add(this.cb_inspector2);
            this.Controls.Add(this.cb_inspector1);
            this.Controls.Add(this.texttuInspector3);
            this.Controls.Add(this.texttuInspector2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigoinspector);
            this.Controls.Add(this.texttuinspector1);
            this.Controls.Add(this.nombreinspector);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inspectores";
            this.Text = "inspectores";
            this.Load += new System.EventHandler(this.inspectores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreinspector;
        private TextBox texttuinspector1;
        private Label codigoinspector;
        private Label label1;
        private Button button2;
        private TextBox texttuInspector2;
        private TextBox texttuInspector3;
        private ComboBox cb_inspector1;
        private ComboBox cb_inspector2;
        private ComboBox cb_inspector3;
    }
}