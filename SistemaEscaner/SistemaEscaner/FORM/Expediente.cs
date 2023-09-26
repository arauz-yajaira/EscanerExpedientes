using System;
using System.Collections;
using System.Drawing;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SistemaEscaner.FORM;

namespace SistemaEscaner.FORM
{
    public partial class Expediente : Form
    {
       
        ExpEntity Entity = new ExpEntity();

        public Expediente()
        {
            InitializeComponent();
            CargarDGV();
            txtBuscarExp.Enabled = false;
        }
        
        private void CargarDGV()
        {

            var TPaciente = from p in Entity.PACIENTE
                            .Take(25)
                            select new 
                           {
                               p.EXPEDIENTE,
                               p.NOMBRES_DEL_PACIENTE,
                               p.APELLIDO_1_DEL_PACIENTE,
                               p.APELLIDO_2_DEL_PACIENTE,
                               p.IDENTIDAD_DEL_PACIENTE                              
                           }; 

            DGVDatos.DataSource = TPaciente.CopyAnonymusToDataTable();
            

        }

        private void TxtBuscarExp_TextChanged(object sender, EventArgs e)
        {
            string Paciente = txtBuscarExp.Text.Trim();

            ///CONDICIONES DE FILTRADO POR MEDIO DE EVENTO TEXTCHANGE 
            
            if (ckId.Checked == true)
            {
                var TPaciente = from B in Entity.PACIENTE

                                where 
                                    B.IDENTIDAD_DEL_PACIENTE.Contains(Paciente)
                                    
                                select new
                                {
                                   
                                    B.IDENTIDAD_DEL_PACIENTE,
                                    B.NOMBRES_DEL_PACIENTE,
                                    B.APELLIDO_1_DEL_PACIENTE,
                                    B.APELLIDO_2_DEL_PACIENTE,
                                    B.EXPEDIENTE

                                };

                DGVDatos.DataSource = TPaciente.Take(20).ToList();
                DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            if (ckNE.Checked == true)
            {
                var TPaciente = from B in Entity.PACIENTE

                                where 
                                    B.EXPEDIENTE.ToString().Contains(Paciente) 
                                select new
                                {
                                    B.EXPEDIENTE,
                                    B.NOMBRES_DEL_PACIENTE,
                                    B.APELLIDO_1_DEL_PACIENTE,
                                    B.APELLIDO_2_DEL_PACIENTE,
                                    B.IDENTIDAD_DEL_PACIENTE
                                };
                DGVDatos.DataSource = TPaciente.Take(20).ToList();
                DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            if (ckNombre.Checked == true)
            {
                var TPaciente = from B in Entity.PACIENTE

                                where 
                                    B.NOMBRES_DEL_PACIENTE.Contains(Paciente)
                                   
                                // orderby B.NOMBRES_DEL_PACIENTE, B.APELLIDO_1_DEL_PACIENTE, B.APELLIDO_2_DEL_PACIENTE,B.IDENTIDAD_DEL_PACIENTE, B.EXPEDIENTE
                                select new
                                {
                                 
                                    B.NOMBRES_DEL_PACIENTE,
                                    B.APELLIDO_1_DEL_PACIENTE,
                                    B.APELLIDO_2_DEL_PACIENTE,
                                    B.IDENTIDAD_DEL_PACIENTE,
                                    B.EXPEDIENTE
                                };

                DGVDatos.DataSource = TPaciente.Take(20).ToList();
                DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else if(ckApellido.Checked == true)
            {
                var TPaciente = from B in Entity.PACIENTE

                                where( 
                                    B.APELLIDO_1_DEL_PACIENTE.Contains(Paciente) ||
                                    B.APELLIDO_2_DEL_PACIENTE.Contains(Paciente) 
                                    )
                                // orderby B.NOMBRES_DEL_PACIENTE, B.APELLIDO_1_DEL_PACIENTE, B.APELLIDO_2_DEL_PACIENTE,B.IDENTIDAD_DEL_PACIENTE, B.EXPEDIENTE
                                select new
                                {
                                    B.NOMBRES_DEL_PACIENTE,
                                    B.APELLIDO_1_DEL_PACIENTE,
                                    B.APELLIDO_2_DEL_PACIENTE,
                                    B.IDENTIDAD_DEL_PACIENTE,
                                    B.EXPEDIENTE
                                };

                DGVDatos.DataSource = TPaciente.Take(20).ToList();
                DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }

        #region checkBoxForm

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNombre.Checked == true)
            {
                txtBuscarExp.Enabled = true;
                ckId.Enabled = false;
                ckNE.Enabled = false;
                ckApellido.Enabled = false;
            }
            else if (ckNombre.Checked == false)
            {
                txtBuscarExp.Enabled = false;
                ckId.Enabled = true;
                ckNE.Enabled = true;
                ckApellido.Enabled = true;
                txtBuscarExp.Text = "";
                CargarDGV();
            }
           
        }

        private void ckApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (ckApellido.Checked == true)
            {
                txtBuscarExp.Enabled = true;
                ckId.Enabled = false;
                ckNE.Enabled = false;
                ckNombre.Enabled = false;
            }
            else if(ckApellido.Checked == false)
            {
                txtBuscarExp.Enabled = false;
                ckId.Enabled = true;
                ckNE.Enabled = true;
                ckNombre.Enabled = true;
                txtBuscarExp.Text = "";
                CargarDGV();
            }



        }

        private void ckNE_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNE.Checked == true)
            {
                txtBuscarExp.Enabled = true;
                ckId.Enabled = false;
                ckApellido.Enabled = false;
                ckNombre.Enabled = false;
            }
            else if (ckNE.Checked == false)
            {
                txtBuscarExp.Enabled = false;
                ckId.Enabled = true;
                ckApellido.Enabled = true;
                ckNombre.Enabled = true;
                txtBuscarExp.Text = "";
                CargarDGV();
            }
        }

        private void ckId_CheckedChanged(object sender, EventArgs e)
        {
            if (ckId.Checked == true)
            {
                txtBuscarExp.Enabled = true;
                ckNE.Enabled = false;
                ckApellido.Enabled = false;
                ckNombre.Enabled = false;
            }
            else if (ckId.Checked == false)
            {
                txtBuscarExp.Enabled = false;
                ckNE.Enabled = true;
                ckApellido.Enabled = true;
                ckNombre.Enabled = true;
                txtBuscarExp.Text = "";
                CargarDGV();
            }
        }

        #endregion
    }
}
