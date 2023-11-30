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
using static SistemaEscaner.USUARIOS.InicioSesion;

namespace SistemaEscaner.FORM
{
    public partial class VerExpEscan : Form
    {
        SIGAFEntities Entity = new SIGAFEntities();
        EscanerExpedienteEntinties Entities = new EscanerExpedienteEntinties();
        public static int exp = 0;

        public VerExpEscan()
        {
            InitializeComponent();
            CargarDGV();
         
        }

        private void VerExpEscan_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = UsuarioIngresado.UsuarioNombre;
            lbId.Text = UsuarioIngresado.IdUsuario.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int UTipo = UsuarioIngresado.TipoUsuario;

            DialogResult result = MessageBox.Show("¿Seguro que quieres cerrar ventana?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (UTipo == 2 || UTipo == 3)
                {

                    MenuUsuario UserMenu = new MenuUsuario();
                   UserMenu.Show();
                    this.Dispose();
                }
                else
                {

                    MenuAdmin admin = new MenuAdmin();
                    admin.Show();
                    this.Dispose();
                }
            }
            else
            {
                return;
            }
        }
  

        private void CargarDGV()
        {
            int cont = 0;
            var idAnterior = 0;

            var THojas = from h in Entities.Hoja
                         orderby h.IdPacienteESC
                         select new
                         {
                             h.IdPacienteESC,
                             h.FechaIngreso,
                             h.Comentario
                         };

            var TPaciente = from p in Entity.PACIENTE
                            select new
                            {
                                p.EXPEDIENTE,
                                p.NOMBRES_DEL_PACIENTE,
                                p.APELLIDO_1_DEL_PACIENTE,
                                p.APELLIDO_2_DEL_PACIENTE,
                                p.IDENTIDAD_DEL_PACIENTE
                            };

    
            DGVDatos.Rows.Clear();

            foreach (var item in THojas)
            {
                int idActual = Convert.ToInt32(item.IdPacienteESC);

                if (idAnterior != idActual)
                {
                    idAnterior = idActual;
                    cont = 0;
                }
                else if (idAnterior == idActual)
                {
                    cont++;
                    if (cont == 1)
                    {
                        var pacienteESC = TPaciente.FirstOrDefault(p => p.EXPEDIENTE == idActual);
                        if (pacienteESC != null)
                        {
                            DGVDatos.Rows.Add(
                                pacienteESC.EXPEDIENTE,
                                pacienteESC.NOMBRES_DEL_PACIENTE,
                                pacienteESC.APELLIDO_1_DEL_PACIENTE,
                                pacienteESC.APELLIDO_2_DEL_PACIENTE,
                                pacienteESC.IDENTIDAD_DEL_PACIENTE,
                                item.FechaIngreso,
                                item.Comentario
                                );
                            
                        }
                    }
                }
            }
        }
        #region
        private void ckId_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckNE_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckNombre_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ckApellido_CheckedChanged(object sender, EventArgs e)
        {

          
        }
        #endregion
        private void txtBuscarExp_TextChanged(object sender, EventArgs e)
        {
            string id = txtBuscarExp.Text.Trim();
             int cont = 0;
             var idAnterior = 0;

             var THojas = from h in Entities.Hoja
                          where h.IdPacienteESC.ToString().Contains(id)
                          orderby h.IdPacienteESC
                          select new
                          {
                              h.IdPacienteESC,
                              h.FechaIngreso,
                              h.Comentario
                          };

             var TPaciente = from p in Entity.PACIENTE
                             where p.EXPEDIENTE.ToString().Contains(id)
                             select new
                             {
                                 p.EXPEDIENTE,
                                 p.NOMBRES_DEL_PACIENTE,
                                 p.APELLIDO_1_DEL_PACIENTE,
                                 p.APELLIDO_2_DEL_PACIENTE,
                                 p.IDENTIDAD_DEL_PACIENTE
                             };


             DGVDatos.Rows.Clear();

             foreach (var item in THojas)
             {
                 int idActual = Convert.ToInt32(item.IdPacienteESC);

                 if (idAnterior != idActual)
                 {
                     idAnterior = idActual;
                     cont = 0;
                 }
                 else if (idAnterior == idActual)
                 {
                     cont++;
                     if (cont == 1)
                     {
                         var pacienteESC = TPaciente.FirstOrDefault(p => p.EXPEDIENTE == idActual);
                         if (pacienteESC != null)
                         {
                             DGVDatos.Rows.Add(
                                 pacienteESC.EXPEDIENTE,
                                 pacienteESC.NOMBRES_DEL_PACIENTE,
                                 pacienteESC.APELLIDO_1_DEL_PACIENTE,
                                 pacienteESC.APELLIDO_2_DEL_PACIENTE,
                                 pacienteESC.IDENTIDAD_DEL_PACIENTE,
                                 item.FechaIngreso,
                                 item.Comentario
                                 );

                         }
                     }
                 }
             }
        }
        private void DGVDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }


        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
