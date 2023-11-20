namespace SistemaEscaner.USUARIOS
{
    partial class InicioSesion
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
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.txtUsuario = new ns1.BunifuMaterialTextbox();
            this.txtContra = new ns1.BunifuMaterialTextbox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.IMGVer = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BTNAgregar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAgregar.ForeColor = System.Drawing.Color.Black;
            this.BTNAgregar.Location = new System.Drawing.Point(651, 404);
            this.BTNAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(171, 44);
            this.BTNAgregar.TabIndex = 26;
            this.BTNAgregar.Text = "Ingresar";
            this.BTNAgregar.UseVisualStyleBackColor = false;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(617, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Inicio de Sesión";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(633, 260);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 32);
            this.txtUsuario.TabIndex = 40;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // txtContra
            // 
            this.txtContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContra.HintForeColor = System.Drawing.Color.Empty;
            this.txtContra.HintText = "";
            this.txtContra.isPassword = true;
            this.txtContra.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtContra.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContra.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtContra.LineThickness = 3;
            this.txtContra.Location = new System.Drawing.Point(633, 315);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(223, 32);
            this.txtContra.TabIndex = 41;
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContra.OnValueChanged += new System.EventHandler(this.txtContra_OnValueChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::SistemaEscaner.Properties.Resources._2___copia___copia__2_;
            this.pictureBox6.Location = new System.Drawing.Point(930, -5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaEscaner.Properties.Resources.Recurso_5;
            this.pictureBox3.Location = new System.Drawing.Point(516, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SistemaEscaner.Properties.Resources.Agregar_un_título;
            this.pictureBox4.Location = new System.Drawing.Point(-6, -5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(516, 491);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // IMGVer
            // 
            this.IMGVer.BackColor = System.Drawing.Color.Transparent;
            this.IMGVer.Image = global::SistemaEscaner.Properties.Resources.OIP__2_;
            this.IMGVer.Location = new System.Drawing.Point(872, 315);
            this.IMGVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IMGVer.Name = "IMGVer";
            this.IMGVer.Size = new System.Drawing.Size(29, 24);
            this.IMGVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMGVer.TabIndex = 27;
            this.IMGVer.TabStop = false;
            this.IMGVer.Click += new System.EventHandler(this.IMGVer_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::SistemaEscaner.Properties.Resources.ImagenSistema;
            this.pictureBox5.Location = new System.Drawing.Point(676, 124);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 484);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.IMGVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.PictureBox IMGVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ns1.BunifuMaterialTextbox txtUsuario;
        private ns1.BunifuMaterialTextbox txtContra;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}