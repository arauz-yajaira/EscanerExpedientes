using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscaner.USUARIOS
{
    public partial class AgregarUsuario : Form
    {
        private bool showPassword = false;
        ExpedienteEntities Entity = new ExpedienteEntities();

        long IdUsuario = 0;
        bool Modificar = false;
        bool Agregar = false;

        public AgregarUsuario()
        {
            InitializeComponent();
            CargarDatosDGV();
            var tt = new ToolTip();
            tt.SetToolTip(IMGVer, "Ver Contraseña");
            BTNContra.Enabled = false;
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
            DGVUsuarios.ClearSelection();
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
           
            #region
            //Validacion de llenado
            if (Agregar || txtUsuario.Text.Equals("") || txtContra.Text.Equals("") || cbEstado.Equals("") || cbTipoUsuario.Equals(""))
            {
                MessageBox.Show("Ingrese Todos los Datos, para agregar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
           if (Modificar)
                {
                    MessageBox.Show("Usuario Modificado Exitosamente!", "Usuario Modificado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

            String Pass = Hash.obtenerHash256(txtContra.Text);

            var user = Entity.Usuarios.FirstOrDefault(x => x.Usuario == txtUsuario.Text);//determina si hay existencia de usuario iguales
            if (Modificar)
            {
                var TUsuarios = Entity.Usuarios.FirstOrDefault(x => x.IdUsuario == IdUsuario); //Validacion de existencia de variable IdUsuario
                TUsuarios.Usuario = txtUsuario.Text;
                TUsuarios.IdTipoUsuario = cbTipoUsuario.SelectedIndex+1;
                TUsuarios.IdEstado = cbEstado.SelectedIndex+1;

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
                    IdEstado = cbEstado.SelectedIndex+1,
                    IdTipoUsuario = cbTipoUsuario.SelectedIndex+1
                };
                
              
               
                // Obtenga el texto de ambos TextBox
                string password = txtContra.Text;
                string confirmPassword = txtConfir.Text;

                // Compara las contraseñas
                if (password == confirmPassword)
                {
                   // MessageBox.Show("Las contraseñas coinciden");
                    MessageBox.Show("Usuario Guardado con Exito!");
                    Entity.Usuarios.Add(TbUsuarios);
                    Entity.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                    // Puedes borrar los TextBox o realizar otras acciones en caso de que las contraseñas no coincidan
                    txtContra.Focus();
                    return;
                }
            }
            #endregion

            LimpiarForm();
            CargarDatosDGV();
        }

        //Metodo Limpiar
        private void LimpiarForm()
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
            //cbEstado.Text = "";
            //cbTipoUsuario.Text = "";
            Modificar = false;
            DGVUsuarios.ClearSelection();
            BTNAgregar.Text = "Agregar Usuario  ";
            txtConfir.Text = "";
            txtBuscar.Text = "";


        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
         
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void IMGVer_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                txtContra.PasswordChar = '\0'; // Mostrar contraseña en texto normal
                txtConfir.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*'; // Ocultar contraseña con asteriscos
                txtConfir.PasswordChar = '*';
            }
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNContra.Enabled = false;
            BTNAgregar.Text = "Modificar Usuario";
            Modificar = true;

            try
            {
                IdUsuario = Convert.ToInt64(DGVUsuarios.SelectedCells[0].Value);
                var TUsuario = Entity.Usuarios.FirstOrDefault(x => x.IdUsuario == IdUsuario);
                txtUsuario.Text = TUsuario.Usuario;
                cbEstado.SelectedIndex = TUsuario.IdEstado - 1;
                cbTipoUsuario.SelectedIndex = TUsuario.IdTipoUsuario - 1;
                Modificar = true;
            }
            catch (Exception)
            {
                // LimpiarForm();
                DGVUsuarios.ClearSelection();

            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string Usuario = txtBuscar.Text;
            var TUsuario = from B in Entity.Usuarios
                           where B.Usuario.Contains(Usuario)
                           orderby B.Usuario
                           select new
                           {
                               B.IdUsuario,
                               B.Usuario,
                               B.FechaIngreso,
                               B.FechaModificado,
                               B.EstadoUsuario.EstadoUsuario1,
                               B.TipoUsuario.TipoUsuario1
                           };
            DGVUsuarios.DataSource = TUsuario.CopyAnonymusToDataTable();
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
