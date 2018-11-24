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
            // TODO: esta línea de código carga datos en la tabla 'servicioElPenduloDataSet8.CitasAgendadas' Puede moverla o quitarla según sea necesario.
            this.citasAgendadasTableAdapter.Fill(this.servicioElPenduloDataSet8.CitasAgendadas);
            // TODO: esta línea de código carga datos en la tabla 'dataSetListaTecnicos.Tecnicos' Puede moverla o quitarla según sea necesario.
            this.tecnicosTableAdapter.Fill(this.dataSetListaTecnicos.Tecnicos);

        }

        private void tablaAsignacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Asignaciones(Sucursal,ID_Tecnico,NombreTecnico,FechaCita,NombreCitante,EstatusTrabajo)"
                    + "VALUES(@A,@B,@C,@D,@E,@F)";
                cmd.Parameters.Add(new SqlParameter("@A", txt_Sucursal.Text));
                cmd.Parameters.Add(new SqlParameter("@B", txt_IDTecnico.Text));
                cmd.Parameters.Add(new SqlParameter("@C", list_Tecnicos.Text));
                cmd.Parameters.Add(new SqlParameter("@D", txtFecha.Text));
                cmd.Parameters.Add(new SqlParameter("@E", txt_horaCita.Text));
                cmd.Parameters.Add(new SqlParameter("@F", list_Estatus.Text));
                con.Close();
                MessageBox.Show("Asignado","Listo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
