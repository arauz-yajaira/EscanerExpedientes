namespace SistemaEscaner.USUARIOS
{
    partial class AgregarUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNContra = new System.Windows.Forms.Button();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.txtConfir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IMGVer = new System.Windows.Forms.PictureBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMGVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = " Módulo Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BTNLimpiar);
            this.panel1.Controls.Add(this.txtConfir);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.IMGVer);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.cbTipoUsuario);
            this.panel1.Controls.Add(this.txtContra);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 589);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.BTNContra);
            this.panel2.Controls.Add(this.BTNAgregar);
            this.panel2.Location = new System.Drawing.Point(47, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 163);
            this.panel2.TabIndex = 19;
            // 
            // BTNContra
            // 
            this.BTNContra.Location = new System.Drawing.Point(26, 69);
            this.BTNContra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTNContra.Name = "BTNContra";
            this.BTNContra.Size = new System.Drawing.Size(199, 40);
            this.BTNContra.TabIndex = 14;
            this.BTNContra.Text = "Cambiar Contraseña";
            this.BTNContra.UseVisualStyleBackColor = true;
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.BackColor = System.Drawing.Color.Indigo;
            this.BTNAgregar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAgregar.ForeColor = System.Drawing.Color.White;
            this.BTNAgregar.Location = new System.Drawing.Point(19, 3);
            this.BTNAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(334, 50);
            this.BTNAgregar.TabIndex = 12;
            this.BTNAgregar.Text = "Agregar Usuario";
            this.BTNAgregar.UseVisualStyleBackColor = false;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(362, 319);
            this.BTNLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(95, 40);
            this.BTNLimpiar.TabIndex = 15;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // txtConfir
            // 
            this.txtConfir.Location = new System.Drawing.Point(180, 235);
            this.txtConfir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfir.Name = "txtConfir";
            this.txtConfir.PasswordChar = '*';
            this.txtConfir.Size = new System.Drawing.Size(223, 23);
            this.txtConfir.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Confirme Contraseña";
            // 
            // IMGVer
            // 
            this.IMGVer.BackColor = System.Drawing.Color.Transparent;
            this.IMGVer.Image = global::SistemaEscaner.Properties.Resources.OIP__2_;
            this.IMGVer.Location = new System.Drawing.Point(412, 182);
            this.IMGVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IMGVer.Name = "IMGVer";
            this.IMGVer.Size = new System.Drawing.Size(29, 24);
            this.IMGVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMGVer.TabIndex = 16;
            this.IMGVer.TabStop = false;
            this.IMGVer.Click += new System.EventHandler(this.IMGVer_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(176, 329);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(164, 23);
            this.cbEstado.TabIndex = 11;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(176, 281);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(164, 23);
            this.cbTipoUsuario.TabIndex = 10;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(180, 182);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(223, 23);
            this.txtContra.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(180, 135);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 23);
            this.txtUsuario.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agregar Usuarios";
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Location = new System.Drawing.Point(591, 100);
            this.DGVUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.Size = new System.Drawing.Size(851, 455);
            this.DGVUsuarios.TabIndex = 2;
            this.DGVUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsuarios_CellClick);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 714);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMGVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button BTNContra;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.PictureBox IMGVer;
        private System.Windows.Forms.TextBox txtConfir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}