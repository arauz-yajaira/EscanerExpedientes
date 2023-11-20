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
using iTextSharp.text;
using iTextSharp.text.pdf;
using static SistemaEscaner.USUARIOS.InicioSesion;
using static SistemaEscaner.FORM.Expediente;
using Image = System.Drawing.Image;

namespace SistemaEscaner.FORM
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Escaner : Form
    {
        ExpEntity Entity = new ExpEntity(); // SIGAF
        ExpedienteEntities Entities = new ExpedienteEntities(); //sistema escaner
        Expediente expe = new Expediente(); // no se
   
        public int EXPED = Expediente.exp;
        int IDE = Expediente.exp;
        public string nombre;
        public string apellido;

      //  int nexpe = paciente.expediente;

        public Escaner()
        {
            InitializeComponent();
            string k = IDE.ToString();
            var paciente = Entity.PACIENTE.FirstOrDefault(u => u.EXPEDIENTE == IDE);
            lbExpe.Text = paciente.EXPEDIENTE.ToString();
            txtNombre.Text = paciente.NOMBRES_DEL_PACIENTE;
            txtApellido.Text = paciente.APELLIDO_1_DEL_PACIENTE;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            ///lbExpe.Text = idPA.PublicExpeInfo.ToString();
            //lbExpe.Text = EXPED.ToString();
            BTN_AGDOC.Enabled = false;
           
           // IDE = Convert.ToInt32(lbExpe.Text);
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
            // Utilizar using statement para garantizar la liberación adecuada de recursos
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void BTN_AGDOC_Click(object sender, EventArgs e)
        {
            Escaner escaner = new Escaner();
            try
            {
                // Convertir la imagen del PictureBox a un arreglo de bytes
                byte[] byteArrayImagen = ImageToByteArray(pictureBox1.Image);

                // Crear un objeto Hoja con los datos necesarios
                Hoja hoja = new Hoja
                {
                  //  usuarioCreo = escaner.lbUsuario.Text,
                    HojaAgregada = byteArrayImagen,
                    IdPacienteESC = IDE,
                    FechaIngreso = DateTime.Now,
                    usuarioCreo = UsuarioIngresado.IdUsuario


                };

                    // Agregar el objeto Hoja a la base de datos y guardar los cambios
                    Entities.Hoja.Add(hoja);
                    Entities.SaveChanges();

                    MessageBox.Show("Guardado Satisfactoriamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen: " + ex.Message);
                }
            

        }

        /*SqlCommand command = new SqlCommand();
             command.Text = "INSERT INTO Hoja (HojaAgregada) values (@imagen)";
             command.Parameters.AddWithValue("@imagen", byteArrayImagen);
             command.ExecuteNonQuery();*/

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
                        pictureBox1.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])image.FileData.get_BinaryData()));
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
           //Previsualizar();
            BTN_AGDOC.Enabled = true;
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



    private void BTN_VIEW_Click(object sender, EventArgs e)
        {
            
            View viewForm = new View();
            viewForm.Show();
           viewForm.lbE.Text = IDE.ToString();


        }

        public void ConvertirImagenesAPDF()
        {
            using (var Entities = new ExpedienteEntities())
            {
                var hojas = Entities.Hoja.Where(h => h.IdPacienteESC == IDE).ToList();
                MessageBox.Show(IDE.ToString());
                totalESC = hojas.Count;

                if (totalESC > 0)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.InitialDirectory = "C:\\Archivos_y_Expedientes_Respaldo_HEAC";
                        sfd.Filter = "Archivo PDF|*.pdf";
                        sfd.Title = "Guardar PDF";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (Document doc = new Document())
                            {
                                using (PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create)))
                                {
                                    doc.Open();

                                    foreach (var hoja in hojas)
                                    {
                                        byte[] imageData = hoja.HojaAgregada;
                                        using (MemoryStream ms = new MemoryStream(imageData))
                                        {
                                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms);

                                            // Centrar la imagen en la página
                                            float width = PageSize.LETTER.Width - doc.LeftMargin - doc.RightMargin;
                                            float height = PageSize.LETTER.Height - doc.TopMargin - doc.BottomMargin;
                                            img.Alignment = iTextSharp.text.Image.ALIGN_CENTER | iTextSharp.text.Image.ALIGN_MIDDLE;
                                            img.ScaleToFit(width, height);

                                            doc.Add(img);
                                        }
                                    }
                                    doc.Close();
                                }

                            }

                            MessageBox.Show("Expediente Digital PDF exportado y guardado en " + sfd.FileName);
                        }
                    }
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.noEncontrada;
                }
            }
        }


        public int indiceActual = 0;
        public int totalESC = 0;




        private void BTN_EXPDF_Click(object sender, EventArgs e)
        {
            ConvertirImagenesAPDF();
        }

        private void Escaner_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = "Usuario: " + UsuarioIngresado.UsuarioNombre;
            idUsuario.Text = "Id " + UsuarioIngresado.IdUsuario;

            // Verificar si el usuario es de tipo 3 (Usuario)
            if (UsuarioIngresado.TipoUsuario == 3)
            {
                // Bloquear los botones de agregar y escanear
                BTNEscaner.Visible = false;
                BTN_AGDOC.Visible = false;

                // Mostrar los botones de visualización y exportar
                BTN_VIEW.Visible = true;
                BTN_EXPDF.Visible = true;
            }
            else
            {
                BTNEscaner.Visible= true;
                BTN_AGDOC.Visible = true;
                BTN_VIEW.Visible = true;
                BTN_EXPDF.Visible = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void BTN_Vista_Click(object sender, EventArgs e)
        {
          
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
    }

}
