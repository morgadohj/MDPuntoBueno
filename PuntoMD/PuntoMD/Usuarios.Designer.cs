
namespace PuntoMD
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.btnguardar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.datausuarios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.btnguarda = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.btnguardar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datausuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.Controls.Add(this.label1);
            resources.ApplyResources(this.btnguardar, "btnguardar");
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnsalir, "btnsalir");
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtbuscar);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.White;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtbuscar, "txtbuscar");
            this.txtbuscar.Name = "txtbuscar";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Transparent;
            this.btnagregar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnagregar, "btnagregar");
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // datausuarios
            // 
            this.datausuarios.AllowUserToAddRows = false;
            this.datausuarios.AllowUserToResizeRows = false;
            this.datausuarios.BackgroundColor = System.Drawing.Color.White;
            this.datausuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.datausuarios, "datausuarios");
            this.datausuarios.Name = "datausuarios";
            this.datausuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnsalir);
            this.panel3.Controls.Add(this.btnagregar);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblErrorNombre);
            this.panel5.Controls.Add(this.btncancelar);
            this.panel5.Controls.Add(this.btnguardarcambios);
            this.panel5.Controls.Add(this.btnguarda);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.txtpass);
            this.panel5.Controls.Add(this.textlogin);
            this.panel5.Controls.Add(this.txtnombre);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btncancelar, "btncancelar");
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnguardarcambios, "btnguardarcambios");
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            // 
            // btnguarda
            // 
            this.btnguarda.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnguarda, "btnguarda");
            this.btnguarda.Name = "btnguarda";
            this.btnguarda.UseVisualStyleBackColor = true;
            this.btnguarda.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // txtpass
            // 
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtpass, "txtpass");
            this.txtpass.Name = "txtpass";
            // 
            // textlogin
            // 
            this.textlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textlogin, "textlogin");
            this.textlogin.Name = "textlogin";
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtnombre, "txtnombre");
            this.txtnombre.Name = "txtnombre";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblErrorNombre
            // 
            resources.ApplyResources(this.lblErrorNombre, "lblErrorNombre");
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Name = "lblErrorNombre";
            // 
            // Usuarios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.datausuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnguardar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.btnguardar.ResumeLayout(false);
            this.btnguardar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datausuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView datausuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.Button btnguarda;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox textlogin;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorNombre;
    }
}