using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaEscaner
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new USUARIOS.InicioSesion());
           
            //METODO PARA CREAR CARPETA AL EJECUTAR EL ARCHIVO
            string carpetaExpedientes = @"C:\Archivos_y_Expedientes_Respaldo_HEAC"; // Direccion de la carpeta 

            try
            {
                // Verificamos si la carpeta ya existe
                if (!Directory.Exists(carpetaExpedientes))
                {
                    //crear la carpeta
                    Directory.CreateDirectory(carpetaExpedientes);
                    Console.WriteLine($"La carpeta de Expedientes {carpetaExpedientes} se ha creado con éxito.");
                }
                else
                {
                    Console.WriteLine($"La carpeta de Expedientes {carpetaExpedientes} ya existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la carpeta de Expedientes: {ex.Message}");
            }

        }
    }
}
