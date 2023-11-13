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


namespace SistemaEscaner.FORM
{
    public partial class View : Form
    {
        ExpEntity Entity = new ExpEntity();
        ExpedienteEntities Entities = new ExpedienteEntities();
        Escaner escaner = new Escaner();
        public int id = Escaner.Ide;

        public View()
        {
            InitializeComponent();
            BTN_ATRAS.Visible = false;
            LoadImage(); // Cargar la imagen cuando se crea el formulario
            lbE.Text = id.ToString();
        }

        public void LoadImage()
        {
            //Asegúrate de declarar la variable id y asignarle el valor de lbE.Text
        
                using (var Entities = new ExpedienteEntities())
                {
                    var hojas = Entities.Hoja.Where(
                        h => h.IdPacienteESC == id)
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


        public int indiceActual = 0;
        public int totalESC = 0;

        private void BTN_ATRAS_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                LoadImage();
            }
        }

        private void BTN_SIGUE_Click(object sender, EventArgs e)
        {
            if (indiceActual < totalESC - 1)
            {
                indiceActual++;
                LoadImage();
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
