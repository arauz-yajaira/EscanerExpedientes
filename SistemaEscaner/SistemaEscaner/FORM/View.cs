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
        ExpEntity Entity = new ExpEntity();
        ExpedienteEntities Entities = new ExpedienteEntities();
        Escaner escaner = new Escaner();
       // public int IDE = paciente.expediente;
        int IDE = Expediente.exp;

        public PictureBox PictureBox1; // Asegúrate de tener un PictureBox en tu formulario

        public View()
        {
   
            InitializeComponent();
            BTN_ATRAS.Visible = false;   
            var paciente = Entity.PACIENTE.FirstOrDefault(u => u.EXPEDIENTE == IDE);
            lbE.Text = paciente.EXPEDIENTE.ToString();
            MostrarImagen();
        }



        public void MostrarImagen()
        {
            using (var Entities = new ExpedienteEntities())
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
                        // Actualiza la visibilidad del botón "BTN_ATRAS"
                        BTN_ATRAS.Visible = indiceActual > 0;
                    }
                }
                else
                {
                    // Si no se encuentran imágenes, muestra un mensaje de error o una imagen predeterminada.
                    pictureBox1.Image = Properties.Resources.noEncontrada; // Reemplaza con tu imagen predeterminada.
                }
            }

        }
        /*
        private Image ByteArrayToImage(byte[] byteArray)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir bytes a imagen: " + ex.Message);
                return null;
            }
        }*/




        public int indiceActual = 0;
        public int totalESC = 0;

        private void BTN_ATRAS_Click(object sender, EventArgs e)
        {
              if (indiceActual > 0)
              {
                  indiceActual--;
                  MostrarImagen();
              }
        }

        private void BTN_SIGUE_Click(object sender, EventArgs e)
        {
            if (indiceActual < totalESC - 1)
            {
                indiceActual++;
                MostrarImagen();
            }
        }

        private void View_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = "Usuario: " + UsuarioIngresado.UsuarioNombre;
            lbId.Text = "Id " + UsuarioIngresado.IdUsuario;

            // Verificar si el usuario es de tipo 3 (Usuario)
            if (UsuarioIngresado.TipoUsuario == 3)
            {
                // Bloquear los botones de agregar y escanear
                BTN_Eliminar.Visible = false;

                // Mostrar los botones de visualización y exportar
                BTN_ATRAS.Visible = true;
                BTN_SIGUE.Visible = true;
            }
            else
            {
                BTN_Eliminar.Visible = true;
                BTN_ATRAS.Visible = true;
                BTN_SIGUE.Visible = true;
            }

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
        }
        public void EliminarHoja()
        {
            try
            {
                using (var entities = new ExpedienteEntities())
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




    }
}
