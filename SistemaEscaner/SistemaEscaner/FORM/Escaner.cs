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

namespace SistemaEscaner.FORM
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
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


        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
          
        }


        private void BTN_AGDOC_Click(object sender, EventArgs e)
        {
            byte[] byteArrayImagen = ImageToByteArray(pictureBox1.Image);
            Hoja Hoja = new Hoja
            {
                HojaAgregada = byteArrayImagen
             
            };
            Entities.Hoja.Add(Hoja);
            Entities.SaveChanges();

            /*SqlCommand command = new SqlCommand();
            command.Text = "INSERT INTO Hoja (HojaAgregada) values (@imagen)";
            command.Parameters.AddWithValue("@imagen", byteArrayImagen);
            command.ExecuteNonQuery();*/
        }

    
  
        private void Previsualizar()
        {
            CommonDialogClass commonDialog = new CommonDialogClass();
            ImageFile image = null;

            try
            {
                // Mostrar el cuadro de dilogo para seleccionar un dispositivo de escaneo
                Device device = commonDialog.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, true);

                if (device != null)
                {
                    Item item = device.Items[1];
                    item.Properties["6146"].set_Value(1);
                    item.Properties["6147"].set_Value(300);
                    image = (ImageFile)item.Transfer();

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


        private void BTNEscaner_Click(object sender, EventArgs e)
        {
            // Previsualizar();
            
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = getImage.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
            }

        } 

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
