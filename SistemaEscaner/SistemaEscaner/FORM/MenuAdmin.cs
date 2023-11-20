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
using static SistemaEscaner.USUARIOS.InicioSesion;

namespace SistemaEscaner.FORM
{
    public partial class MenuAdmin : Form
    {

        ExpedienteEntities Entity = new ExpedienteEntities();
        
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void BTN_AgreUsuario_Click(object sender, EventArgs e)
        {
            USUARIOS.AgregarUsuario AGG = new AgregarUsuario();
            AGG.Show();
            this.Close();
        }

        private void BTN_Digit_Click(object sender, EventArgs e)
        {
            FORM.Expediente exp = new Expediente();
            exp.Show();
            this.Close();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = "Usuario:" + UsuarioIngresado.UsuarioNombre;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
