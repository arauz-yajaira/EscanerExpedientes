﻿namespace SistemaEscaner.FORM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbuscar = new System.Windows.Forms.Label();
            this.txtBuscarExp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckNE = new System.Windows.Forms.CheckBox();
            this.ckApellido = new System.Windows.Forms.CheckBox();
            this.ckNombre = new System.Windows.Forms.CheckBox();
            this.ckId = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BTN_VIEW = new System.Windows.Forms.PictureBox();
            this.BTN_EXPDF = new System.Windows.Forms.PictureBox();
            this.BTN_AGDOC = new System.Windows.Forms.PictureBox();
            this.imgHospital = new System.Windows.Forms.PictureBox();
            this.lbP = new System.Windows.Forms.Label();
            this.lbEXP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_EXPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_AGDOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHospital)).BeginInit();
            this.SuspendLayout();
            // 
            // lbuscar
            // 
            this.lbuscar.AutoSize = true;
            this.lbuscar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuscar.Location = new System.Drawing.Point(71, 83);
            this.lbuscar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbuscar.Name = "lbuscar";
            this.lbuscar.Size = new System.Drawing.Size(142, 18);
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
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ARCHIVOS Y EXPEDIENTES";
            // 
            // DGVDatos
            // 
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDatos.Location = new System.Drawing.Point(81, 254);
            this.DGVDatos.MultiSelect = false;
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(1146, 568);
            this.DGVDatos.TabIndex = 7;
            this.DGVDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
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
            // ckNE
            // 
            this.ckNE.AutoSize = true;
            this.ckNE.Location = new System.Drawing.Point(459, 31);
            this.ckNE.Name = "ckNE";
            this.ckNE.Size = new System.Drawing.Size(144, 22);
            this.ckNE.TabIndex = 9;
            this.ckNE.Text = "N° EXPEDIENTE";
            this.ckNE.UseVisualStyleBackColor = true;
            this.ckNE.CheckedChanged += new System.EventHandler(this.ckNE_CheckedChanged);
            // 
            // ckApellido
            // 
            this.ckApellido.AutoSize = true;
            this.ckApellido.Location = new System.Drawing.Point(751, 31);
            this.ckApellido.Name = "ckApellido";
            this.ckApellido.Size = new System.Drawing.Size(112, 22);
            this.ckApellido.TabIndex = 8;
            this.ckApellido.Text = "APELLIDOS";
            this.ckApellido.UseVisualStyleBackColor = true;
            this.ckApellido.CheckedChanged += new System.EventHandler(this.ckApellido_CheckedChanged);
            // 
            // ckNombre
            // 
            this.ckNombre.AutoSize = true;
            this.ckNombre.Location = new System.Drawing.Point(624, 31);
            this.ckNombre.Name = "ckNombre";
            this.ckNombre.Size = new System.Drawing.Size(104, 22);
            this.ckNombre.TabIndex = 7;
            this.ckNombre.Text = "NOMBRES";
            this.ckNombre.UseVisualStyleBackColor = true;
            this.ckNombre.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckId
            // 
            this.ckId.AutoSize = true;
            this.ckId.Location = new System.Drawing.Point(382, 34);
            this.ckId.Name = "ckId";
            this.ckId.Size = new System.Drawing.Size(44, 22);
            this.ckId.TabIndex = 6;
            this.ckId.Text = "ID";
            this.ckId.UseVisualStyleBackColor = true;
            this.ckId.CheckedChanged += new System.EventHandler(this.ckId_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elija opcion de Filtrado: ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.BTNCerrar);
            this.panel2.Location = new System.Drawing.Point(-16, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1445, 46);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaEscaner.Properties.Resources.Recurso_5;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(856, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.BackColor = System.Drawing.Color.Red;
            this.BTNCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNCerrar.FlatAppearance.BorderSize = 0;
            this.BTNCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCerrar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTNCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNCerrar.Location = new System.Drawing.Point(1387, 3);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(55, 43);
            this.BTNCerrar.TabIndex = 39;
            this.BTNCerrar.Text = "X";
            this.BTNCerrar.UseVisualStyleBackColor = false;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(0, 844);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1443, 46);
            this.panel3.TabIndex = 10;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // BTN_VIEW
            // 
            this.BTN_VIEW.BackColor = System.Drawing.Color.Transparent;
            this.BTN_VIEW.Image = global::SistemaEscaner.Properties.Resources._5ff78c60095b7a30b6ab03c4_investigation;
            this.BTN_VIEW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_VIEW.Location = new System.Drawing.Point(1280, 586);
            this.BTN_VIEW.Name = "BTN_VIEW";
            this.BTN_VIEW.Size = new System.Drawing.Size(95, 92);
            this.BTN_VIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_VIEW.TabIndex = 37;
            this.BTN_VIEW.TabStop = false;
            this.BTN_VIEW.Click += new System.EventHandler(this.BTN_VIEW_Click);
            // 
            // BTN_EXPDF
            // 
            this.BTN_EXPDF.BackColor = System.Drawing.Color.Transparent;
            this.BTN_EXPDF.Image = global::SistemaEscaner.Properties.Resources.Raa;
            this.BTN_EXPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_EXPDF.Location = new System.Drawing.Point(1280, 443);
            this.BTN_EXPDF.Name = "BTN_EXPDF";
            this.BTN_EXPDF.Size = new System.Drawing.Size(95, 92);
            this.BTN_EXPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_EXPDF.TabIndex = 36;
            this.BTN_EXPDF.TabStop = false;
            this.BTN_EXPDF.Click += new System.EventHandler(this.BTN_EXPDF_Click);
            // 
            // BTN_AGDOC
            // 
            this.BTN_AGDOC.BackColor = System.Drawing.Color.Transparent;
            this.BTN_AGDOC.Image = global::SistemaEscaner.Properties.Resources.beyondhealth_willkommen_01_50eba149;
            this.BTN_AGDOC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_AGDOC.Location = new System.Drawing.Point(1259, 303);
            this.BTN_AGDOC.Name = "BTN_AGDOC";
            this.BTN_AGDOC.Size = new System.Drawing.Size(126, 134);
            this.BTN_AGDOC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_AGDOC.TabIndex = 35;
            this.BTN_AGDOC.TabStop = false;
            this.BTN_AGDOC.Click += new System.EventHandler(this.BTN_AGDOC_Click);
            // 
            // imgHospital
            // 
            this.imgHospital.BackColor = System.Drawing.Color.Transparent;
            this.imgHospital.Image = global::SistemaEscaner.Properties.Resources.Recurso_5;
            this.imgHospital.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgHospital.Location = new System.Drawing.Point(1269, 80);
            this.imgHospital.Name = "imgHospital";
            this.imgHospital.Size = new System.Drawing.Size(95, 92);
            this.imgHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHospital.TabIndex = 34;
            this.imgHospital.TabStop = false;
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP.Location = new System.Drawing.Point(720, 80);
            this.lbP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(183, 18);
            this.lbP.TabIndex = 10;
            this.lbP.Text = " Paciente Expediente:";
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
            // 
            // Expediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 885);
            this.Controls.Add(this.BTN_VIEW);
            this.Controls.Add(this.BTN_EXPDF);
            this.Controls.Add(this.BTN_AGDOC);
            this.Controls.Add(this.imgHospital);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVDatos);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Expediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_EXPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_AGDOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHospital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbuscar;
        private System.Windows.Forms.TextBox txtBuscarExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.PictureBox imgHospital;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.CheckBox ckNE;
        private System.Windows.Forms.CheckBox ckApellido;
        private System.Windows.Forms.CheckBox ckNombre;
        private System.Windows.Forms.CheckBox ckId;
        private System.Windows.Forms.PictureBox BTN_VIEW;
        private System.Windows.Forms.PictureBox BTN_EXPDF;
        private System.Windows.Forms.PictureBox BTN_AGDOC;
        protected System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Label lbEXP;
        private System.Windows.Forms.Label lbP;
    }
}