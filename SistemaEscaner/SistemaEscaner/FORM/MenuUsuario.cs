using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscaner.USUARIOS;
using SistemaEscaner.FORM;
using static SistemaEscaner.USUARIOS.InicioSesion;

namespace SistemaEscaner.FORM
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Expediente EXP = new Expediente();
            EXP.Show();
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            VerExpEscan verExp = new VerExpEscan();
            verExp.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cerrar ventana?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
                InicioSesion inicio = new InicioSesion();
                inicio.Show();

            }
            else
            {
                return;
            }
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            lbUser.Text = UsuarioIngresado.UsuarioNombre;
        }
    }
}
