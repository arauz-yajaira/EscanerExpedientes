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
            TooltipsProyecto();
            lbEXP.Visible = false;
            lbP.Visible = false;

            BTN_AGDOC.Enabled = false;
            BTN_EXPDF.Enabled = false;
            BTN_VIEW.Enabled = false;
        }
       
        public void TooltipsProyecto()
        {
            var tt = new ToolTip();
            tt.SetToolTip(imgHospital, "Hospital Enrique Aguilar Cerrato");
         

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BTN_AGDOC, "Agregue documentos al expediente del Paciente");
            toolTip.SetToolTip(BTN_EXPDF, "Exporta expediente a PDF");
            toolTip.SetToolTip(BTN_VIEW, "Visualizar el Expediente de Paciente");
            toolTip.SetToolTip(BTNCerrar, "Cerrar ventana");
            toolTip.SetToolTip(txtBuscarExp, "Busca paciente con una opcion de filtrado");
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

        private void BTN_AGDOC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona Boton");
        }

        private void BTN_EXPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona Boton");
        }

        private void BTN_VIEW_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona Boton");
        }

        private void DGVDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TooltipsProyecto();
            BTN_AGDOC.Enabled = true;
            BTN_EXPDF.Enabled = true;
            BTN_VIEW.Enabled = true;
            lbEXP.Visible = true;
            lbP.Visible = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene el valor de la celda EXP
                DataGridViewCell expedienteCell = DGVDatos.Rows[e.RowIndex].Cells["Expediente"];

                if (expedienteCell.Value != null)
                {
                    // AJUNTA EXP
                    string numeroExpediente = expedienteCell.Value.ToString();

                    // Asigna el valor combinado al TextBox
                    lbEXP.Text = numeroExpediente;
                    
                }
                else
                {
                    
                    lbEXP.Text = string.Empty; 

                }
            }
        }
    }
}
