﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscaner.USUARIOS;
using static SistemaEscaner.USUARIOS.InicioSesion;

namespace SistemaEscaner.FORM
{
    public partial class MenuAdmin : Form
    {

       
        
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void BTN_AgreUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_Digit_Click(object sender, EventArgs e)
        {
          
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            lbUser.Text =  UsuarioIngresado.UsuarioNombre;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            USUARIOS.AgregarUsuario AGG = new AgregarUsuario();
            AGG.Show();
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            FORM.Expediente exp = new Expediente();
            exp.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cerrar ventana?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
                InicioSesion inicio = new InicioSesion();
                inicio.Show();

            }
            else
            {
                return;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            FORM.VerExpEscan verExp = new VerExpEscan();
            verExp.Show();
            this.Close();
        }
    }
}
