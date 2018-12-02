using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace ERP_ServicioElPendulo
{
    public partial class AsignarTrabajos : Form
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);

        public AsignarTrabajos()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AsignarTrabajos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tecnicosAsignacion.Tecnicos' Puede moverla o quitarla según sea necesario.
            this.tecnicosTableAdapter2.Fill(this.tecnicosAsignacion.Tecnicos);
            // TODO: esta línea de código carga datos en la tabla 'servicioElPenduloDataSet9.Tecnicos' Puede moverla o quitarla según sea necesario.
            this.tecnicosTableAdapter1.Fill(this.servicioElPenduloDataSet9.Tecnicos);
            // TODO: esta línea de código carga datos en la tabla 'servicioElPenduloDataSet8.CitasAgendadas' Puede moverla o quitarla según sea necesario.
            this.citasAgendadasTableAdapter.Fill(this.servicioElPenduloDataSet8.CitasAgendadas);
            // TODO: esta línea de código carga datos en la tabla 'dataSetListaTecnicos.Tecnicos' Puede moverla o quitarla según sea necesario.
            this.tecnicosTableAdapter.Fill(this.dataSetListaTecnicos.Tecnicos);

            list_Tecnicos.SelectedIndex = 0;
            txtIdTecnico.Text = list_Tecnicos.SelectedValue.ToString();
            list_Estatus.SelectedIndex = 0;
        }

        private void tablaAsignacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var claveServicio = tablaAsignacion.Rows[e.RowIndex].Cells[0].Value;
                idTrabajoText.Text = claveServicio.ToString();
                //
                var sucursal = tablaAsignacion.Rows[e.RowIndex].Cells[1].Value;
                txt_Sucursal.Text = sucursal.ToString();
                //
                var fechaCita = tablaAsignacion.Rows[e.RowIndex].Cells[3].Value;
                txtFecha.Text = fechaCita.ToString();
                //
                var horaCita = tablaAsignacion.Rows[e.RowIndex].Cells[4].Value;
                txt_horaCita.Text = horaCita.ToString();
                //
                var atendio = tablaAsignacion.Rows[e.RowIndex].Cells[5].Value;
                txt_PQAtendio.Text = atendio.ToString();
                //
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            int idTrabajoInt = Convert.ToInt32(idTrabajoText.Text);
            if(validaciones() == true)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Asignaciones(ID_Trabajo,Sucursal,ID_Tecnico,NombreTecnico,FechaCita,NombreCitante,EstatusTrabajo)"
                        + "VALUES(@A,@B,@C,@D,@E,@F,@G)";
                    cmd.Parameters.Add(new SqlParameter("@A", idTrabajoInt));
                    cmd.Parameters.Add(new SqlParameter("@B", txt_Sucursal.Text));
                    cmd.Parameters.Add(new SqlParameter("@C", txtIdTecnico.Text));
                    cmd.Parameters.Add(new SqlParameter("@D", list_Tecnicos.Text));
                    cmd.Parameters.Add(new SqlParameter("@E", txtFecha.Text));
                    cmd.Parameters.Add(new SqlParameter("@F", txt_PQAtendio.Text));
                    cmd.Parameters.Add(new SqlParameter("@G", list_Estatus.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Asignado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error con la Base de Datos");
                } 
            }
            else
            {
                MessageBox.Show("Falta algun parametro importante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool validaciones()
        {
            bool idTRABAJO = false;
            bool SUCURSAL = false;
            bool IDTECNICO = false;
            bool TECNICO = false;
            bool FECHA = false;
            bool ESTATUS = false;
            bool validacionCorrecta = false;
            bool puedeAsignar = false;
            if(String.IsNullOrEmpty(idTrabajoText.Text))
            {
                idTRABAJO = false;
            }
            else
            {
                idTRABAJO = true;
            }
            if (String.IsNullOrEmpty(txt_Sucursal.Text))
            {
                SUCURSAL = false;
            }
            else
            {
                SUCURSAL = true;
            }
            if (String.IsNullOrEmpty(list_Tecnicos.Text))
            {
                TECNICO = false;
            }
            else
            {
                TECNICO = true;
            }
            if (String.IsNullOrEmpty(txtFecha.Text))
            {
                FECHA = false;
            }
            else
            {
                FECHA = true;
            }
            if (String.IsNullOrEmpty(list_Estatus.Text))
            {
                ESTATUS = false;
            }
            else
            {
                ESTATUS = true;
            }
           if(idTRABAJO && SUCURSAL && TECNICO && FECHA && ESTATUS)
            {
                puedeAsignar = true;
            }
            else
            {
                puedeAsignar = false;
            }
            return puedeAsignar;
        }
        private void list_Tecnicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdTecnico.Text = list_Tecnicos.SelectedValue.ToString();
            }catch(Exception ex)
            {
                return;
            } 
        }

        private void tablaAsignacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
