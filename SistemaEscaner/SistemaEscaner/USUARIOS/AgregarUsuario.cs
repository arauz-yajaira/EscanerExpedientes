using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscaner.USUARIOS
{
    public partial class AgregarUsuario : Form
    {
        ExpedienteEntities Entity = new ExpedienteEntities();

        long IdUsuario = 0;
        bool Modificar = false;
        public AgregarUsuario()
        {
            InitializeComponent();
            CargarDatosDGV();
        }

        private void CargarDatosDGV()
        {
            var TUsuario = from p in Entity.Usuarios
                           select new
                           {
                               p.IdUsuario,
                               p.Usuario,
                               p.FechaIngreso,
                               p.FechaModificado,
                               p.EstadoUsuario.EstadoUsuario1,
                               p.TipoUsuario.TipoUsuario1
                           };
            DGVUsuarios.DataSource = TUsuario.CopyAnonymusToDataTable();

            var Tipos = from c in Entity.TipoUsuario
                        select new
                        {
                            c.IdTipoUsuario,
                            c.TipoUsuario1,
                        };
            DataTable DTU = Tipos.CopyAnonymusToDataTable();
            cbTipoUsuario.DataSource = DTU;
            cbTipoUsuario.ValueMember = DTU.Columns[0].ColumnName;
            cbTipoUsuario.DisplayMember = DTU.Columns[1].ColumnName;

            var Estado = from e in Entity.EstadoUsuario
                         select new
                         {
                             e.IdEstado,
                             e.EstadoUsuario1,
                         };
            DataTable E = Estado.CopyAnonymusToDataTable();
            cbEstado.DataSource = E;
            cbEstado.ValueMember = E.Columns[0].ColumnName;
            cbEstado.DisplayMember = E.Columns[1].ColumnName;


        }

        public class Hash
        {
            public static string obtenerHash256(string text)
            {

                byte[] bytes = Encoding.Unicode.GetBytes(text);
                SHA256Managed hashString = new SHA256Managed();
                byte[] hash = hashString.ComputeHash(bytes);
                string hashStr = string.Empty;
                foreach (byte x in hash)
                {
                    hashStr += String.Format("{0:x2}", x);
                }
                return hashStr;
            }
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            //Validacion de llenado
            if (txtUsuario.Text.Equals("") || txtContra.Text.Equals("") || cbEstado.Equals("") || cbTipoUsuario.Equals(""))
            {
                MessageBox.Show("Ingrese Todos los Datos, para agregar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String Pass = Hash.obtenerHash256(txtContra.Text);
            var user = Entity.Usuarios.FirstOrDefault(x => x.Usuario == txtUsuario.Text);//determina si hay existencia de usuario iguales
            if (Modificar)
            {
                var TUsuarios = Entity.Usuarios.FirstOrDefault(x => x.IdUsuario == IdUsuario); //Validacion de existencia de variable IdUsuario
                TUsuarios.Usuario = txtUsuario.Text;
                TUsuarios.IdTipoUsuario = cbTipoUsuario.SelectedIndex;
                TUsuarios.IdEstado = cbEstado.SelectedIndex;

                Entity.SaveChanges();
            }
            else
            {
                if (user != null)
                {
                    MessageBox.Show("Este nombre de Usuario ya Existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }
                Usuarios TbUsuarios = new Usuarios
                {

                    Usuario = txtUsuario.Text,
                    Contra = txtContra.Text,
                    FechaIngreso = DateTime.Now,
                    FechaModificado = DateTime.Now,
                    IdEstado = cbEstado.SelectedIndex,
                    IdTipoUsuario = cbTipoUsuario.SelectedIndex
                };
                Entity.Usuarios.Add(TbUsuarios);
                Entity.SaveChanges();
            }
        }
    }
}
