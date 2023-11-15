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
using SistemaEscaner.Clases;



namespace SistemaEscaner.FORM
{
    public partial class View : Form
    {
        ExpEntity Entity = new ExpEntity();
        ExpedienteEntities Entities = new ExpedienteEntities();
        Escaner escaner = new Escaner();
        public int IDE = paciente.expediente;

        public PictureBox PictureBox1; // Asegúrate de tener un PictureBox en tu formulario

        public View()
        {
   
            InitializeComponent();
            BTN_ATRAS.Visible = false;
            //lbE.Text = IDP.ToString();
            txtNUM.Text = IDE.ToString();
            MostrarImagen();
        }



        public void MostrarImagen()
        {
            var paciente = Entities.Hoja.FirstOrDefault(p => p.IdPacienteESC == IDE);

            if (paciente != null && paciente.HojaAgregada != null)
            {
                // Convertimos el array de bytes a una imagen
                Image imagen = ByteArrayToImage(paciente.HojaAgregada);

                // Mostramos la imagen en el pictureBox1
                pictureBox1.Image = imagen;
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el paciente con ID " + IDE);
            }
        }


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
        }

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

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
