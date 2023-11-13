﻿using System;
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

namespace SistemaEscaner.USUARIOS
{
    public partial class InicioSesion : Form
    {

        ExpedienteEntities Entity = new ExpedienteEntities();


        public InicioSesion()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        
        
        private bool showPassword = false;

      


        private void IMGVer_Click(object sender, System.EventArgs e)
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

        public static class UsuarioIngresado
        {
            public static string UsuarioNombre { get; private set; }

            public static void IniciarSesion(string nombreUsuario)
            {
                UsuarioNombre = nombreUsuario;
            }

            public static void CerrarSesion()
            {
                UsuarioNombre = null;
            }
        }


        private void BTNAgregar_Click(object sender, System.EventArgs e)
        {
            using (ExpedienteEntities db = new ExpedienteEntities())
            {
                string nombreUsuario = txtUsuario.Text;
                string contrasena = txtContra.Text;

                // Buscar al usuario por nombre de usuario
                var usuario = db.Usuarios.FirstOrDefault(u => u.Usuario == nombreUsuario);

                if (usuario != null)
                {
                    // Obtener el hash SHA-256 de la contraseña ingresada
                    string contrasenaHash = Hash.obtenerHash256(contrasena);

                    // Comparar el hash de la contraseña ingresada con el hash almacenado en la base de datos
                    if (usuario.Contra == contrasenaHash)
                    {
                        // Inicio de sesión exitoso
                        MessageBox.Show("Inicio de sesión exitoso");
                        UsuarioIngresado.IniciarSesion(nombreUsuario);
                        FORM.MenuAdmin admin = new FORM.MenuAdmin();
                        admin.Show();
                       /* FORM.Expediente expediente = new FORM.Expediente();
                        expediente.Show();*/
                        this.Hide();


                    }
                    else
                    {
                        // Inicio de sesión fallido
                        MessageBox.Show("Inicio de sesión fallido. Verifica tus datos.");
                    }
                }
                else
                {
                    // Usuario no encontrado en la base de datos
                    MessageBox.Show("Usuario no encontrado. Verifica tus datos ingresados.");
                }

               
            }

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
    }
}
