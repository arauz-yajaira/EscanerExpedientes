
namespace SistemaEscaner.FORM
{
    partial class Escaner
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbuscar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTNEscaner = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Regresar = new System.Windows.Forms.PictureBox();
            this.BTN_VIEW = new System.Windows.Forms.PictureBox();
            this.BTN_EXPDF = new System.Windows.Forms.PictureBox();
            this.BTN_AGDOC = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_EXPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_AGDOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "DATOS PACIENTES ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lbuscar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(88, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 130);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellidos Paciente:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(188, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(272, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // lbuscar
            // 
            this.lbuscar.AutoSize = true;
            this.lbuscar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuscar.Location = new System.Drawing.Point(24, 31);
            this.lbuscar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbuscar.Name = "lbuscar";
            this.lbuscar.Size = new System.Drawing.Size(160, 18);
            this.lbuscar.TabIndex = 0;
            this.lbuscar.Text = "Nombres Paciente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BTNCerrar);
            this.panel2.Location = new System.Drawing.Point(-110, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1445, 44);
            this.panel2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1012, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 43);
            this.button1.TabIndex = 40;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BTNEscaner);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(88, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 618);
            this.panel3.TabIndex = 43;
            // 
            // BTNEscaner
            // 
            this.BTNEscaner.Location = new System.Drawing.Point(278, 21);
            this.BTNEscaner.Name = "BTNEscaner";
            this.BTNEscaner.Size = new System.Drawing.Size(105, 35);
            this.BTNEscaner.TabIndex = 2;
            this.BTNEscaner.Text = "Escanear";
            this.BTNEscaner.UseVisualStyleBackColor = true;
            this.BTNEscaner.Click += new System.EventHandler(this.BTNEscaner_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista de Escaner";
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Regresar.Image = global::SistemaEscaner.Properties.Resources.png_clipart_arrow_computer_icons_symbol_previous_button_trademark_logo;
            this.BTN_Regresar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Regresar.Location = new System.Drawing.Point(12, 48);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(49, 46);
            this.BTN_Regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_Regresar.TabIndex = 44;
            this.BTN_Regresar.TabStop = false;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // BTN_VIEW
            // 
            this.BTN_VIEW.BackColor = System.Drawing.Color.Transparent;
            this.BTN_VIEW.Image = global::SistemaEscaner.Properties.Resources._5ff78c60095b7a30b6ab03c4_investigation;
            this.BTN_VIEW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_VIEW.Location = new System.Drawing.Point(772, 261);
            this.BTN_VIEW.Name = "BTN_VIEW";
            this.BTN_VIEW.Size = new System.Drawing.Size(95, 92);
            this.BTN_VIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_VIEW.TabIndex = 42;
            this.BTN_VIEW.TabStop = false;
            // 
            // BTN_EXPDF
            // 
            this.BTN_EXPDF.BackColor = System.Drawing.Color.Transparent;
            this.BTN_EXPDF.Image = global::SistemaEscaner.Properties.Resources.Raa;
            this.BTN_EXPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_EXPDF.Location = new System.Drawing.Point(772, 568);
            this.BTN_EXPDF.Name = "BTN_EXPDF";
            this.BTN_EXPDF.Size = new System.Drawing.Size(95, 92);
            this.BTN_EXPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_EXPDF.TabIndex = 41;
            this.BTN_EXPDF.TabStop = false;
            // 
            // BTN_AGDOC
            // 
            this.BTN_AGDOC.BackColor = System.Drawing.Color.Transparent;
            this.BTN_AGDOC.Image = global::SistemaEscaner.Properties.Resources.beyondhealth_willkommen_01_50eba149;
            this.BTN_AGDOC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_AGDOC.Location = new System.Drawing.Point(751, 395);
            this.BTN_AGDOC.Name = "BTN_AGDOC";
            this.BTN_AGDOC.Size = new System.Drawing.Size(126, 128);
            this.BTN_AGDOC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_AGDOC.TabIndex = 40;
            this.BTN_AGDOC.TabStop = false;
            this.BTN_AGDOC.Click += new System.EventHandler(this.BTN_AGDOC_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaEscaner.Properties.Resources.Recurso_5;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(860, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // Escaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 1026);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BTN_VIEW);
            this.Controls.Add(this.BTN_EXPDF);
            this.Controls.Add(this.BTN_AGDOC);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Escaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escaner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_EXPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_AGDOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lbuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox BTN_Regresar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox BTN_VIEW;
        private System.Windows.Forms.PictureBox BTN_EXPDF;
        private System.Windows.Forms.PictureBox BTN_AGDOC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNEscaner;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}