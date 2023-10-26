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


namespace SistemaEscaner.FORM
{
    public partial class Escaner : Form
    {
        ExpEntity Entity = new ExpEntity();
        ExpedienteEntities Entities = new ExpedienteEntities();

        public Escaner(string nombre, string apellido)
        {
            InitializeComponent();
            // Asignar los datos a los TextBox
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show("¿Seguro que quieres cerrar ventana?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Expediente formExp = new Expediente();
                Close();

            }
        }

        private void BTN_Regresar_Click(object sender, EventArgs e)
        {
            Expediente formExp = new Expediente();
            formExp.Show();
            Close();
        }
        
        public class Hoja
        {     public int IdHoja { get; set; }
              public byte[] HojaAgregada { get; set; }
             }

        private void BTN_AGDOC_Click(object sender, EventArgs e)
        {
            ///PRUEBA DE AGREGAR IMAGEN A LA BASE DE DATOS 
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen (*.jpg, *.png)|*.jpg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;
                    byte[] imagenBytes = File.ReadAllBytes(rutaImagen);

                    // Aquí puedes crear una nueva instancia de la entidad Imagen y guardarla en la base de datos.
                    // Asegúrate de llenar otros campos como nombre, descripción, etc.
                    Hoja nuevaImagen = new Hoja
                    {
                    
                        HojaAgregada = imagenBytes
                    };

               /*     using (var db = new Hoja())
                    {
                       db.HojaAgregada.Add(nuevaImagen);
                       db.SaveChanges();
                    }

                    MessageBox.Show("Imagen agregada a la base de datos.");*/
                }
            }
            }


        private void BTNEscaner_Click(object sender, EventArgs e)
        {
            CommonDialogClass commonDialog = new CommonDialogClass();
            ImageFile image = null;

            try
            {
                Device device = commonDialog.ShowSelectDevice();
                if (device != null)
                {
                    Item item = device.Items[1]; // 1 es el índice del primer elemento en la colección de elementos
                    item.Properties["6146"].set_Value(1); // Establece el tipo de escaneo en color
                    item.Properties["6147"].set_Value(300); // Establece la resolución en 300 ppp
                    image = (ImageFile)item.Transfer();

                    // Muestra la imagen escaneada 
                    if (image != null)
                    {
                        pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream((byte[])image.FileData.get_BinaryData()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escanear: " + ex.Message);
            }
            finally
            {
                if (image != null)
                {
                    Marshal.ReleaseComObject(image);
                }
            }
        }
    
    }
}
