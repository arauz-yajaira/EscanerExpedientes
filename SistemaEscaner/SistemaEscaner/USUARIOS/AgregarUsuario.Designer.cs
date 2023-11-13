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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.BTNContra = new System.Windows.Forms.Button();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.txtConfir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BTNExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.IMGVer = new System.Windows.Forms.PictureBox();
            this.BTN_Regresar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Controls.Add(this.BTNContra);
            this.panel1.Controls.Add(this.BTNAgregar);
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblModificar
            // 
            resources.ApplyResources(this.lblModificar, "lblModificar");
            this.lblModificar.Name = "lblModificar";
            // 
            // BTNContra
            // 
            resources.ApplyResources(this.BTNContra, "BTNContra");
            this.BTNContra.Name = "BTNContra";
            this.BTNContra.UseVisualStyleBackColor = true;
            this.BTNContra.Click += new System.EventHandler(this.BTNContra_Click_1);
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.BackColor = System.Drawing.Color.SpringGreen;
            resources.ApplyResources(this.BTNAgregar, "BTNAgregar");
            this.BTNAgregar.ForeColor = System.Drawing.Color.Black;
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.UseVisualStyleBackColor = false;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.BTNLimpiar, "BTNLimpiar");
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // txtConfir
            // 
            resources.ApplyResources(this.txtConfir, "txtConfir");
            this.txtConfir.Name = "txtConfir";
            this.txtConfir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfir_KeyDown);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            resources.ApplyResources(this.cbEstado, "cbEstado");
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbEstado_KeyDown);
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            resources.ApplyResources(this.cbTipoUsuario, "cbTipoUsuario");
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipoUsuario_KeyDown);
            // 
            // txtContra
            // 
            resources.ApplyResources(this.txtContra, "txtContra");
            this.txtContra.Name = "txtContra";
            this.txtContra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContra_KeyDown);
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            // DGVUsuarios
            // 
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DGVUsuarios, "DGVUsuarios");
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.TabStop = false;
            this.DGVUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsuarios_CellClick);
            // 
            // txtBuscar
            // 
            resources.ApplyResources(this.txtBuscar, "txtBuscar");
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BTNExcel
            // 
            resources.ApplyResources(this.BTNExcel, "BTNExcel");
            this.BTNExcel.Name = "BTNExcel";
            this.BTNExcel.UseVisualStyleBackColor = true;
            this.BTNExcel.Click += new System.EventHandler(this.BTNExcel_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.BTNCerrar);
            this.panel2.Controls.Add(this.lbUsuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Name = "panel2";
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.BackColor = System.Drawing.Color.Red;
            this.BTNCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNCerrar.FlatAppearance.BorderSize = 0;
            this.BTNCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BTNCerrar, "BTNCerrar");
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.UseVisualStyleBackColor = false;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // lbUsuario
            // 
            resources.ApplyResources(this.lbUsuario, "lbUsuario");
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Name = "lbUsuario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label11);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaEscaner.Properties.Resources.Recurso_5;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // IMGVer
            // 
            this.IMGVer.BackColor = System.Drawing.Color.Transparent;
            this.IMGVer.Image = global::SistemaEscaner.Properties.Resources.OIP__2_;
            resources.ApplyResources(this.IMGVer, "IMGVer");
            this.IMGVer.Name = "IMGVer";
            this.IMGVer.TabStop = false;
            this.IMGVer.Click += new System.EventHandler(this.IMGVer_Click);
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Regresar.Image = global::SistemaEscaner.Properties.Resources.png_clipart_arrow_computer_icons_symbol_previous_button_trademark_logo;
            resources.ApplyResources(this.BTN_Regresar, "BTN_Regresar");
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.TabStop = false;
            this.BTN_Regresar.Click += new System.EventHandler(this.BTN_Regresar_Click);
            // 
            // AgregarUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BTNExcel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Regresar)).EndInit();
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
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.PictureBox IMGVer;
        private System.Windows.Forms.TextBox txtConfir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Button BTNContra;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.PictureBox BTN_Regresar;
        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}