namespace SistemaEscaner.FORM
{
    partial class Expediente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbuscar = new System.Windows.Forms.Label();
            this.txtBuscarExp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEXP = new System.Windows.Forms.Label();
            this.lbP = new System.Windows.Forms.Label();
            this.ckNE = new System.Windows.Forms.CheckBox();
            this.ckApellido = new System.Windows.Forms.CheckBox();
            this.ckNombre = new System.Windows.Forms.CheckBox();
            this.ckId = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idUsuario = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.imgHospital = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbuscar
            // 
            this.lbuscar.AutoSize = true;
            this.lbuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuscar.Location = new System.Drawing.Point(58, 83);
            this.lbuscar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbuscar.Name = "lbuscar";
            this.lbuscar.Size = new System.Drawing.Size(155, 18);
            this.lbuscar.TabIndex = 0;
            this.lbuscar.Text = "Buscar Paciente:";
            // 
            // txtBuscarExp
            // 
            this.txtBuscarExp.Location = new System.Drawing.Point(221, 80);
            this.txtBuscarExp.Name = "txtBuscarExp";
            this.txtBuscarExp.Size = new System.Drawing.Size(354, 26);
            this.txtBuscarExp.TabIndex = 3;
            this.txtBuscarExp.TextChanged += new System.EventHandler(this.TxtBuscarExp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "EXPEDIENTES PACIENTES";
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDatos.Location = new System.Drawing.Point(81, 254);
            this.DGVDatos.MultiSelect = false;
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVDatos.Size = new System.Drawing.Size(1146, 568);
            this.DGVDatos.TabIndex = 7;
            this.DGVDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellClick);
            this.DGVDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.lbEXP);
            this.panel1.Controls.Add(this.lbP);
            this.panel1.Controls.Add(this.ckNE);
            this.panel1.Controls.Add(this.ckApellido);
            this.panel1.Controls.Add(this.ckNombre);
            this.panel1.Controls.Add(this.ckId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbuscar);
            this.panel1.Controls.Add(this.txtBuscarExp);
            this.panel1.Location = new System.Drawing.Point(81, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 117);
            this.panel1.TabIndex = 8;
            // 
            // lbEXP
            // 
            this.lbEXP.AutoSize = true;
            this.lbEXP.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEXP.Location = new System.Drawing.Point(903, 80);
            this.lbEXP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEXP.Name = "lbEXP";
            this.lbEXP.Size = new System.Drawing.Size(143, 18);
            this.lbEXP.TabIndex = 11;
            this.lbEXP.Text = "EXPEDIENTE/ID";
            this.lbEXP.Click += new System.EventHandler(this.lbEXP_Click);
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP.Location = new System.Drawing.Point(711, 80);
            this.lbP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(199, 18);
            this.lbP.TabIndex = 10;
            this.lbP.Text = " Paciente Expediente:";
            // 
            // ckNE
            // 
            this.ckNE.AutoSize = true;
            this.ckNE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckNE.Location = new System.Drawing.Point(298, 31);
            this.ckNE.Name = "ckNE";
            this.ckNE.Size = new System.Drawing.Size(142, 22);
            this.ckNE.TabIndex = 9;
            this.ckNE.Text = "N° EXPEDIENTE";
            this.ckNE.UseVisualStyleBackColor = true;
            this.ckNE.CheckedChanged += new System.EventHandler(this.ckNE_CheckedChanged);
            // 
            // ckApellido
            // 
            this.ckApellido.AutoSize = true;
            this.ckApellido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckApellido.Location = new System.Drawing.Point(590, 31);
            this.ckApellido.Name = "ckApellido";
            this.ckApellido.Size = new System.Drawing.Size(109, 22);
            this.ckApellido.TabIndex = 8;
            this.ckApellido.Text = "APELLIDOS";
            this.ckApellido.UseVisualStyleBackColor = true;
            this.ckApellido.CheckedChanged += new System.EventHandler(this.ckApellido_CheckedChanged);
            // 
            // ckNombre
            // 
            this.ckNombre.AutoSize = true;
            this.ckNombre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckNombre.Location = new System.Drawing.Point(463, 31);
            this.ckNombre.Name = "ckNombre";
            this.ckNombre.Size = new System.Drawing.Size(102, 22);
            this.ckNombre.TabIndex = 7;
            this.ckNombre.Text = "NOMBRES";
            this.ckNombre.UseVisualStyleBackColor = true;
            this.ckNombre.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckId
            // 
            this.ckId.AutoSize = true;
            this.ckId.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckId.Location = new System.Drawing.Point(234, 31);
            this.ckId.Name = "ckId";
            this.ckId.Size = new System.Drawing.Size(43, 22);
            this.ckId.TabIndex = 6;
            this.ckId.Text = "ID";
            this.ckId.UseVisualStyleBackColor = true;
            this.ckId.CheckedChanged += new System.EventHandler(this.ckId_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elija opcion de Filtrado: ";
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSize = true;
            this.idUsuario.BackColor = System.Drawing.Color.Navy;
            this.idUsuario.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.idUsuario.ForeColor = System.Drawing.Color.White;
            this.idUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idUsuario.Location = new System.Drawing.Point(75, 16);
            this.idUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(17, 12);
            this.idUsuario.TabIndex = 59;
            this.idUsuario.Text = "id";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Navy;
            this.lbUsuario.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbUsuario.Location = new System.Drawing.Point(100, 16);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(50, 12);
            this.lbUsuario.TabIndex = 58;
            this.lbUsuario.Text = "Usuario";
            // 
            // imgHospital
            // 
            this.imgHospital.BackColor = System.Drawing.Color.MidnightBlue;
            this.imgHospital.Image = global::SistemaEscaner.Properties.Resources.ImagenSistema1;
            this.imgHospital.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgHospital.Location = new System.Drawing.Point(0, 0);
            this.imgHospital.Name = "imgHospital";
            this.imgHospital.Size = new System.Drawing.Size(39, 38);
            this.imgHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHospital.TabIndex = 63;
            this.imgHospital.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaEscaner.Properties.Resources.Recurso_5;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(1284, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaEscaner.Properties.Resources.barra1;
            this.pictureBox2.Location = new System.Drawing.Point(-10, 858);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1431, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaEscaner.Properties.Resources.barra1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1431, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaEscaner.Properties.Resources._2___copia___copia__2_;
            this.pictureBox6.Location = new System.Drawing.Point(1373, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 64;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(668, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "EXPEDIENTE DIGITAL ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(737, 864);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "ARCHIVOS Y EXPEDIENTES HEAC";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Expediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 885);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.imgHospital);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.idUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVDatos);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Expediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente";
            this.Load += new System.EventHandler(this.Expediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbuscar;
        private System.Windows.Forms.TextBox txtBuscarExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckNE;
        private System.Windows.Forms.CheckBox ckApellido;
        private System.Windows.Forms.CheckBox ckNombre;
        private System.Windows.Forms.CheckBox ckId;
        protected System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Label lbEXP;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label idUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox imgHospital;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuElipse bunifuElipse1;
    }
}