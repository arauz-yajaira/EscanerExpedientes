
namespace SistemaEscaner.FORM
{
    partial class MenuAdmin
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
            this.BTN_AgreUsuario = new System.Windows.Forms.Button();
            this.BTN_Digit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_AgreUsuario
            // 
            this.BTN_AgreUsuario.Location = new System.Drawing.Point(100, 233);
            this.BTN_AgreUsuario.Name = "BTN_AgreUsuario";
            this.BTN_AgreUsuario.Size = new System.Drawing.Size(176, 89);
            this.BTN_AgreUsuario.TabIndex = 0;
            this.BTN_AgreUsuario.Text = "Agregar Usuarios";
            this.BTN_AgreUsuario.UseVisualStyleBackColor = true;
            this.BTN_AgreUsuario.Click += new System.EventHandler(this.BTN_AgreUsuario_Click);
            // 
            // BTN_Digit
            // 
            this.BTN_Digit.Location = new System.Drawing.Point(327, 233);
            this.BTN_Digit.Name = "BTN_Digit";
            this.BTN_Digit.Size = new System.Drawing.Size(176, 89);
            this.BTN_Digit.TabIndex = 1;
            this.BTN_Digit.Text = "Digitalizar Expediente";
            this.BTN_Digit.UseVisualStyleBackColor = true;
            this.BTN_Digit.Click += new System.EventHandler(this.BTN_Digit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(-192, -5);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 12);
            this.label10.TabIndex = 52;
            this.label10.Text = "Usuario";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbUsuario.Location = new System.Drawing.Point(23, 35);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(50, 12);
            this.lbUsuario.TabIndex = 54;
            this.lbUsuario.Text = "Usuario";
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 544);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BTN_Digit);
            this.Controls.Add(this.BTN_AgreUsuario);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_AgreUsuario;
        private System.Windows.Forms.Button BTN_Digit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbUsuario;
    }
}