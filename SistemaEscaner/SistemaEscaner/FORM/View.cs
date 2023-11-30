using System;
using WIA;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SistemaEscaner.FORM;
using System.Runtime.InteropServices;
using System.Diagnostics;
using static SistemaEscaner.USUARIOS.InicioSesion;
using static SistemaEscaner.FORM.Expediente;
using static SistemaEscaner.FORM.Escaner;



namespace SistemaEscaner.FORM
{
    public partial class View : Form
    {
        SIGAFEntities Entity = new SIGAFEntities();
        EscanerExpedienteEntinties Entities = new EscanerExpedienteEntinties();
        Escaner esc = new Escaner();
        // public int IDE = paciente.expediente;
        int IDE = Expediente.exp;

        public int EXPED = Expediente.exp;

        public string nombre;
        public string apellido;

        public PictureBox PictureBox1; // Asegúrate de tener un PictureBox en tu formulario

        public View()
        {
            this.Load += View_Load;
            InitializeComponent();
            ATRAS_BTN.Visible = false;
            var paciente = Entity.PACIENTE.FirstOrDefault(u => u.EXPEDIENTE == IDE);
            lbE.Text = paciente.EXPEDIENTE.ToString();
            LBNombres.Text = paciente.NOMBRES_DEL_PACIENTE;
            LBApellidos.Text = paciente.APELLIDO_1_DEL_PACIENTE;
            MostrarImagen();
        }



        public void MostrarImagen()
        {
            using (var Entities = new EscanerExpedienteEntinties())
            {
                var hojas = Entities.Hoja.Where(
                    h => h.IdPacienteESC == IDE)
                    .ToList();
                totalESC = hojas.Count;
                if (totalESC > 0)
                {
                    if (indiceActual >= 0 && indiceActual < totalESC)
                    {
                        byte[] imageData = hojas[indiceActual].HojaAgregada;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }

                        LbfechaAGG.Text = hojas[indiceActual].FechaIngreso.ToString("dd/MM/yyyy");
                        ATRAS_BTN.Visible = indiceActual > 0;
                        MostrarComentario();
                    }
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.noEncontrada; // Reemplaza con tu imagen predeterminada.
                    LbfechaAGG.Text = string.Empty;
                }
            }

        }


        public int indiceActual = 0;
        public int totalESC = 0;

        private void BTN_ATRAS_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SIGUE_Click(object sender, EventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {
            CargarDatosDGVLista();
            lbUsuario.Text = UsuarioIngresado.UsuarioNombre;
            lbId.Text = UsuarioIngresado.IdUsuario.ToString();

            if (UsuarioIngresado.TipoUsuario == 3)
            {
                BTN_Eliminar.Visible = false;
                ATRAS_BTN.Visible = true;
                SIGUE_BTN.Visible = true;
                txtComentario.Enabled = false;
                BTN_Guardar.Visible = false;
            }
            else
            {
                BTN_Eliminar.Visible = true;
                ATRAS_BTN.Visible = true;
                SIGUE_BTN.Visible = true;
            }
          
            int idPacienteSeleccionado = exp;

 
            int totalHojas = ContarHojasEscaneadas(idPacienteSeleccionado);

           lbHojas.Text =  totalHojas.ToString();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta hoja?", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                EliminarHoja();
            }
            else
            {
                return;
            }
        }
        public void EliminarHoja()
        {
            try
            {
                using (var entities = new EscanerExpedienteEntinties())
                {
                    var hojaActual = entities.Hoja
                        .Where(h => h.IdPacienteESC == IDE)
                        .OrderBy(h => h.IdHoja)
                        .Skip(indiceActual)
                        .FirstOrDefault();

                    if (hojaActual != null)
                    {

                        entities.Hoja.Remove(hojaActual);
                        entities.SaveChanges();

                        // restar el contador total
                        totalESC--;
                        MostrarImagen();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la hoja: " + ex.Message);
            }
        }

        private void ATRAS_BTN_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                MostrarImagen();
            }
        }

        private void SIGUE_BTN_Click(object sender, EventArgs e)
        {
            if (indiceActual < totalESC - 1)
            {
                indiceActual++;
                MostrarImagen();
            }
        }
        private void MostrarComentario()
        {
            using (var Entities = new EscanerExpedienteEntinties())
            {
                var hojas = Entities.Hoja.Where(
                    h => h.IdPacienteESC == IDE)
                    .ToList();

                if (hojas.Count > 0 && indiceActual >= 0 && indiceActual < hojas.Count)
                {
                    txtComentario.Text = hojas[indiceActual].Comentario;
                }
                else
                {
                    txtComentario.Text = string.Empty;
                }
            }
        }


        private void LBApellidos_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Eliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta hoja?", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                EliminarHoja();
            }
            else
            {
                return;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cerrar ventana?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
                esc.Show();
            }
            else
            {
                return;
            }
        }

        private void GuardarComentario()
        {
            using (var Entities = new EscanerExpedienteEntinties())
            {
                var hojas = Entities.Hoja.Where(
                    h => h.IdPacienteESC == IDE)
                    .ToList();

                if (hojas.Count > 0 && indiceActual >= 0 && indiceActual < hojas.Count)
                {
                    hojas[indiceActual].Comentario = txtComentario.Text;

                    Entities.SaveChanges();
                }
            }
        }


        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            GuardarComentario();
            CargarDatosDGVLista();
            MessageBox.Show("Cambios guardados exitosamente.");
        }
        private void CargarDatosDGVLista()
        {

            var THojas = from p in Entities.Hoja.Where(h => h.IdPacienteESC == IDE)

                         select new
                            {
                                p.IdHoja,
                                p.IdPacienteESC,
                                p.Comentario
                            };

            DGVLista.DataSource = THojas.CopyAnonymusToDataTable();



            /*

            using (var Entities = new EscanerExpedienteEntinties())
            {
                var hojas = Entities.Hoja.Where(h => h.IdPacienteESC == IDE).ToList();

                DGVLista.DataSource = hojas;
                DGVLista.Columns["IdHoja"].HeaderText = "ID Hoja";
                DGVLista.Columns["IdPacienteESC"].HeaderText = "ID Paciente";
                DGVLista.Columns["Comentario"].HeaderText = "Hoja Agregada";
            }*/
        }

        private void CargarInformacionHoja(int idHoja)
        {
            using (var Entities = new EscanerExpedienteEntinties())
            {
                var hoja = Entities.Hoja.FirstOrDefault(h => h.IdHoja == idHoja);

                if (hoja != null)
                {
                    byte[] imageData = hoja.HojaAgregada;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }

                    txtComentario.Text = hoja.Comentario;

                    LbfechaAGG.Text = hoja.FechaIngreso.ToString("dd/MM/yyyy");
                }
            }
        }

        private void DGVLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idHojaSeleccionada = (int)DGVLista.Rows[e.RowIndex].Cells["IdHoja"].Value;

                CargarInformacionHoja(idHojaSeleccionada);
            }
        }

        private int ContarHojasEscaneadas(int idPaciente)
        {
            using (var Entities = new EscanerExpedienteEntinties())
            {
                return Entities.Hoja.Count(h => h.IdPacienteESC == idPaciente);
            }
        }

    }
}
