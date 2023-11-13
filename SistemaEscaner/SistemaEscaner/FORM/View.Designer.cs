
namespace SistemaEscaner.FORM
{
    partial class View
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
            this.BTN_ATRAS = new System.Windows.Forms.Button();
            this.BTN_SIGUE = new System.Windows.Forms.Button();
            this.lbE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ATRAS
            // 
            this.BTN_ATRAS.Location = new System.Drawing.Point(24, 16);
            this.BTN_ATRAS.Name = "BTN_ATRAS";
            this.BTN_ATRAS.Size = new System.Drawing.Size(71, 36);
            this.BTN_ATRAS.TabIndex = 0;
            this.BTN_ATRAS.Text = "<--";
            this.BTN_ATRAS.UseVisualStyleBackColor = true;
            this.BTN_ATRAS.Click += new System.EventHandler(this.BTN_ATRAS_Click);
            // 
            // BTN_SIGUE
            // 
            this.BTN_SIGUE.Location = new System.Drawing.Point(712, 16);
            this.BTN_SIGUE.Name = "BTN_SIGUE";
            this.BTN_SIGUE.Size = new System.Drawing.Size(71, 36);
            this.BTN_SIGUE.TabIndex = 1;
            this.BTN_SIGUE.Text = "-->";
            this.BTN_SIGUE.UseVisualStyleBackColor = true;
            this.BTN_SIGUE.Click += new System.EventHandler(this.BTN_SIGUE_Click);
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE.Location = new System.Drawing.Point(11, 160);
            this.lbE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(99, 18);
            this.lbE.TabIndex = 15;
            this.lbE.Text = "Expediente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 987);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbUsuario.Location = new System.Drawing.Point(22, 79);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(50, 12);
            this.lbUsuario.TabIndex = 50;
            this.lbUsuario.Text = "Usuario";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 1061);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_SIGUE);
            this.Controls.Add(this.BTN_ATRAS);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ATRAS;
        private System.Windows.Forms.Button BTN_SIGUE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.Label lbE;
    }
}