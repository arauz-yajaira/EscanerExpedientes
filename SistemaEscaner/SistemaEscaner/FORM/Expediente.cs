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

        EntitiesExpe Entity = new EntitiesExpe();

        public Expediente()
        {
            InitializeComponent();
           CargarDGV();
        }

        private void CargarDGV()
        {

            var TPaciente = from p in Entity.PACIENTE
                            .Take(15)
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
            string Paciente = txtBuscarExp.Text;

          
                var TPaciente = from B in Entity.PACIENTE
                                where B.NOMBRES_DEL_PACIENTE.Contains(Paciente)
                                orderby B.NOMBRES_DEL_PACIENTE

                                select new
                                {
                                    B.EXPEDIENTE,
                                    B.NOMBRES_DEL_PACIENTE,
                                    B.APELLIDO_1_DEL_PACIENTE,
                                    B.APELLIDO_2_DEL_PACIENTE,
                                    B.IDENTIDAD_DEL_PACIENTE

                                };
                DGVDatos.DataSource = TPaciente.Take(10).ToList();
                DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            
        }
    }
}
