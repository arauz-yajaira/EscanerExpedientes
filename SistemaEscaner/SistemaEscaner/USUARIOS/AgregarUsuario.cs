using System;
using System.Collections;
using System.Drawing;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using SistemaEscaner;
using System.Windows.Forms;
using ClosedXML.Excel;
using static SistemaEscaner.USUARIOS.InicioSesion;

namespace SistemaEscaner.USUARIOS
{
    public partial class AgregarUsuario : Form
    {
        private bool showPassword = false;
        EscanerExpedienteEntinties Entity = new EscanerExpedienteEntinties();

        long IdUsuario = 0;
        bool Modificar = false;
        float clic = 0;
        int tam = 0;

        public AgregarUsuario()
        {
            InitializeComponent();
            this.KeyPreview = true;
            CargarDatosDGV();
            TootTipsProyecto();
            BTNContra.Visible = false;
            BTNEliminar.Visible = false;
            lblModificar.Visible = false;
            timer1.Enabled = true;
        }

        private void TootTipsProyecto()
        {
            var tt = new ToolTip();
            tt.SetToolTip(IMGVer, "Ver Contraseña");
            BTNContra.Enabled = false;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtContra, "La contraseña debe contener al menos 6 letras o numeros");
            toolTip.SetToolTip(BTNAgregar, "Agrega un nuevo Usuarrio");
            toolTip.SetToolTip(txtBuscar, "Busca el usuario");
            toolTip.SetToolTip(BTNCerrar, "Cerrar ventana");

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
            //lblModificar.Text = Modificar.ToString();
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

   
        public bool Validaciones()
        {
            //Validacion de llenado
            if (Modificar)
            {
                if (txtUsuario.Text.Equals("") || cbEstado.Equals("") || cbTipoUsuario.Equals(""))
                {
                    MessageBox.Show("Agrega Datos!", "Ingrese Todos los Datos, para agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 
                    return true;
                }
            }
            else
            {
                if (txtUsuario.Text.Equals("") || txtContra.Text.Equals("") || cbEstado.Equals("") || cbTipoUsuario.Equals(""))
                {
                    MessageBox.Show("Agrega Datos!", "Ingrese Todos los Datos, para agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
                    return true;
                }
            }
            
            return false;
        }
        private void BTNAgregar_Click(object sender, EventArgs e)
        {
          
            Validaciones();
            #region
      
         
            String Pass = Hash.obtenerHash256(txtContra.Text);
            String confirmPass = Hash.obtenerHash256(txtConfir.Text);
            


            if (Modificar)
            {
                if (Validaciones() == false )
                {
                    var TUsuarios = Entity.Usuarios.FirstOrDefault(x => x.IdUsuario == IdUsuario); //Validacion de existencia de variable IdUsuario
                    TUsuarios.Usuario = txtUsuario.Text;
                    TUsuarios.IdTipoUsuario = cbTipoUsuario.SelectedIndex + 1;
                    TUsuarios.IdEstado = cbEstado.SelectedIndex + 1;
                    if (txtContra.Enabled == true && txtConfir.Enabled == true)
                    {
                        TUsuarios.Contra = Pass;
                    }

                    if (ValidarContra())
                    {
                        // MessageBox.Show("Contraseña válida", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Usuario Guardado con Exito!");
                        // MessageBox.Show(Pass.Length.ToString());
                        MessageBox.Show("Usuario Modificado con Exito!");
                        TUsuarios.FechaModificado = DateTime.Now;
                        Entity.SaveChanges();
                        ReiniciarForm();
                    }
                    else if (!ValidarContra() && tam == 1)
                    {
                        MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                        // Puedes borrar los TextBox o realizar otras acciones en caso de que las contraseñas no coincidan
                        txtContra.Focus();
                        return;
                    }
                    else if (!ValidarContra() && tam == 0)
                    {

                        MessageBox.Show("La contraseña debe contener al menos 6 letras y al menos un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContra.Focus();
                        return;
                    }
                   
                    
                }
            }
            else
            {
                var user = Entity.Usuarios.FirstOrDefault(x => x.Usuario == txtUsuario.Text);//determina si hay existencia de usuario iguales
                if (user != null && Validaciones() == true )
                {
                    MessageBox.Show("Este nombre de Usuario ya Existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }
                Usuarios TbUsuarios = new Usuarios
                {

                    Usuario = txtUsuario.Text,
                    Contra = Pass,
                    FechaIngreso = DateTime.Now,                    
                    IdEstado = cbEstado.SelectedIndex+1,
                    IdTipoUsuario = cbTipoUsuario.SelectedIndex+1
                };
                
              
               
                // Obtenga el texto de ambos TextBox
            

                // Definir una expresión regular para verificar si la contraseña cumple con los requisitos
                // al menos 6 espacios letras
                string patron = @"^(.*[A-Za-z0-9]){4}$";


                // Comprobar si la contraseña cumple con la expresión regular  // Compara las contraseñas
                if (ValidarContra())
                {
                    // MessageBox.Show("Contraseña válida", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Usuario Guardado con Exito!");
                   // MessageBox.Show(Pass.Length.ToString());
                    Entity.Usuarios.Add(TbUsuarios);
                    Entity.SaveChanges();
                    ReiniciarForm();
                }
                else if (!ValidarContra() && tam==1)
                {
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                    // Puedes borrar los TextBox o realizar otras acciones en caso de que las contraseñas no coincidan
                    txtContra.Focus(); 
                    return;
                }else if (!ValidarContra() && tam == 0)
                {

                    MessageBox.Show("La contraseña debe contener al menos 6 letras y al menos un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContra.Focus();
                    return;
                }
                // Compara las contraseñas
              
            }
            #endregion

            LimpiarForm();
            CargarDatosDGV();
        }

        //metodo contra 4 espacios
        private bool ValidarContra()
        {
            String Pass = Hash.obtenerHash256(txtContra.Text);
            String confirmPass = Hash.obtenerHash256(txtConfir.Text);
            string patron = @"^(.*[A-Za-z0-9]){4}$";


            // Comprobar si la contraseña cumple con la expresión regular  // Compara las contraseñas
            if (Pass == confirmPass && Regex.IsMatch(Pass, patron) && Pass != "" && confirmPass != "")
            {
                // MessageBox.Show("Contraseña válida", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  MessageBox.Show("Usuario Guardado con Exito!");
              //  MessageBox.Show(Pass.Length.ToString());
                //Entity.Usuarios.Add(TbUsuarios);
                // Entity.SaveChanges();
                return true;
            }
            else if (Pass != confirmPass)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                // Puedes borrar los TextBox o realizar otras acciones en caso de que las contraseñas no coincidan
                txtContra.Focus();
                tam = 1;
                return false;
            }
            else
            {

                MessageBox.Show("La contraseña debe contener al menos 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContra.Focus();
                tam = 0;
                return false;
            }
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
            //lblModificar.Text = Modificar.ToString();
            txtContra.Enabled = true;
            txtConfir.Enabled = true;
            BTNContra.Enabled = false;
            BTNContra.Visible = false;
            lblModificar.Visible = false;
            BTNContra.Enabled = false;
            BTNContra.Visible = false;
           


        }

        private void ReiniciarForm()
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
            //lblModificar.Text = Modificar.ToString();
            txtContra.Enabled = true;
            txtConfir.Enabled = true;
            BTNContra.Enabled = false;
            BTNContra.Visible = false;
            lblModificar.Visible = false;


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
            
            try
            {
                IdUsuario = Convert.ToInt64(DGVUsuarios.SelectedCells[0].Value);
                var TUsuario = Entity.Usuarios.FirstOrDefault(x => x.IdUsuario == IdUsuario);
                txtUsuario.Text = TUsuario.Usuario;
                cbEstado.SelectedIndex = TUsuario.IdEstado - 1;
                cbTipoUsuario.SelectedIndex = TUsuario.IdTipoUsuario - 1;
                Modificar = true;
               // txtContra.Text = "";
                //txtConfir.Text = "";
                BTNContra.Enabled = false;
                txtContra.Enabled = false;
                txtConfir.Enabled = false;
                BTNAgregar.Text = "Modificar Usuario";
               // lblModificar.Text = Modificar.ToString();
                BTNContra.Enabled = true;
                BTNContra.Visible = true;
                BTNEliminar.Visible = true;
                BTNEliminar.Enabled = true;
                lblModificar.Text = "Si desea cambiar contraseña de click aqui ->";
                lblModificar.Visible = true;
                IMGVer.Enabled = false;
              
            }
            catch (Exception)
            {
                // LimpiarForm();
                DGVUsuarios.ClearSelection();

            }
        }
        public void EliminarUsuario()
        {
            try
            {
                long idUsuario = Convert.ToInt64(DGVUsuarios.SelectedCells[0].Value);

                // Obtener el usuario de la base de datos usando Entity Framework
                var usuarioAEliminar = Entity.Usuarios.FirstOrDefault(x => x.IdUsuario == idUsuario);

                if (usuarioAEliminar != null)
                {
                    Entity.Usuarios.Remove(usuarioAEliminar);
                    Entity.SaveChanges();  // Guardar los cambios en la base de datos
                    LimpiarForm();
                    CargarDatosDGV();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
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

        private void LblModificar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTNContra_Click(object sender, EventArgs e)
        {
            txtContra.Enabled = true;
            txtConfir.Enabled = true;
        }

        private void BTNContra_Click_1(object sender, EventArgs e)
        {
  
            if (clic % 2 == 0 )
            {
                //Primer click se habilita opcion de Cambiar contraseña 
                txtUsuario.Enabled = false;
                txtContra.Enabled = true;
                txtConfir.Enabled = true;
                DGVUsuarios.Enabled = false;
                BTNContra.Text = "Cancelar";
                txtBuscar.Enabled = false;
                IMGVer.Enabled = true;
                BTNLimpiar.Enabled = false;

            }
            else
            {
                //Al segundo click se cancela la opcion Cambiar Contraseña
                txtUsuario.Enabled = true;
                txtContra.Enabled = false;
                txtConfir.Enabled = false;
                DGVUsuarios.Enabled = true;
                BTNContra.Text = "Cambiar Contraseña";
                txtBuscar.Enabled = true;
                clic = 1;
                BTNLimpiar.Enabled = true;
                ReiniciarForm();
            }
            
            clic = clic+1;
           
        }

        
    //Instalar Nuget ClosedXML 
        private void BTNExcel_Click(object sender, EventArgs e)
        {/*
            try
            {
                //Indica donde guardaremos
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo de Excel|*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Creamos filePath archivo que gurdaremos = cuadro de dialogo de guardar
                    string filePath = saveFileDialog.FileName;

                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Datos");



                    // Agregar el texto del TextBox en una celda

                    worksheet.Cell(2, 1).Value = txtUsuario.Text;

                    // Agregar tres filas de espacio
                    worksheet.Row(2).InsertRowsBelow(3);

                    // Establecer los encabezados en negrita, uno por uno
                    for (int col = 1; col <= DGVUsuarios.Columns.Count; col++)
                    {
                        worksheet.Cell(5, col).Value = DGVUsuarios.Columns[col - 1].HeaderText;
                        worksheet.Cell(5, col).Style.Font.Bold = true;
                    }

                 

                    // Datos despues del encabezaado
                    for (int row = 0; row < DGVUsuarios.Rows.Count; row++)
                    {
                        for (int col = 0; col < DGVUsuarios.Columns.Count; col++)
                        {
                            //Espacios entre tabla 
                            worksheet.Cell(row + 6, col + 1).Value = DGVUsuarios.Rows[row].Cells[col].Value?.ToString();
                        }
                    }


                    // Guardar el archivo Excel
                    workbook.SaveAs(filePath);
                    MessageBox.Show("Exportación a Excel completada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }*/
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Desea Cerrar la ventana");
               
            }
            catch
            {

                Close();
            }
            return;

        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            lbUsuario.Text =  UsuarioIngresado.UsuarioNombre;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ActiveControl != null && ActiveControl is TextBox)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ActiveControl != null && ActiveControl is TextBox)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void txtConfir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ActiveControl != null && ActiveControl is TextBox)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void cbTipoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ActiveControl != null && ActiveControl is TextBox)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void cbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ActiveControl != null && ActiveControl is TextBox)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            FORM.MenuAdmin admin = new FORM.MenuAdmin();
            admin.Show();
            this.Dispose();
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("¿Desea eliminar este Usuario?", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EliminarUsuario();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
            }

        }

        private void BTNCerrar_Click_1(object sender, EventArgs e)
        {
            FORM.MenuAdmin admin = new FORM.MenuAdmin();
            admin.Show();
            this.Dispose();
        }
    }
}
