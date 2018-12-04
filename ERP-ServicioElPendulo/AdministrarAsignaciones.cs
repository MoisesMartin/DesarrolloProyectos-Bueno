using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ServicioElPendulo
{
    public partial class AdministrarAsignaciones : Form
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);

        public AdministrarAsignaciones()
        {
            InitializeComponent();
        }

        private void AdministrarAsignaciones_Load(object sender, EventArgs e)
        {
            llenarTabla();
            list_filtrarEstatus.SelectedIndex = 0;
            list_Estatus.SelectedIndex = 0;
        }
        public void llenarTabla()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Asignaciones";
                //
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable consulta = new DataTable();
                da.Fill(consulta);
                tablaAsignaciones.DataSource = consulta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void tablaAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var claveServicio = tablaAsignaciones.Rows[e.RowIndex].Cells[1].Value;
            idTrabajoText.Text = claveServicio.ToString();
            //
            var Sucursal = tablaAsignaciones.Rows[e.RowIndex].Cells[2].Value;
            txt_Sucursal.Text = Sucursal.ToString();
            //
            var IDTecnico = tablaAsignaciones.Rows[e.RowIndex].Cells[3].Value;
            txtIdTecnico.Text = IDTecnico.ToString();
            //
            var TecnicoN = tablaAsignaciones.Rows[e.RowIndex].Cells[4].Value;
            txt_NTecnico.Text = TecnicoN.ToString();
            //
            var Fecha = tablaAsignaciones.Rows[e.RowIndex].Cells[5].Value;
            txtFecha.Text = Fecha.ToString();
            //
            var Citante = tablaAsignaciones.Rows[e.RowIndex].Cells[6].Value;
            txtNombreCitante.Text = Citante.ToString();
            //
            var Estatus = tablaAsignaciones.Rows[e.RowIndex].Cells[7].Value;
            list_Estatus.Text = Estatus.ToString();
            //
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int idT = Convert.ToInt32(idTrabajoText.Text);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Asignaciones SET EstatusTrabajo =@Estatus WHERE ID_Trabajo =@ID";
            cmd.Parameters.Add(new SqlParameter("@ID", idT));
            cmd.Parameters.Add(new SqlParameter("@Estatus", list_Estatus.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            //
            llenarTabla();   
        }

        private void list_filtrarEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rd_FiltrarEstatus.Checked)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Asignaciones WHERE EstatusTrabajo = @statusValue";
                    cmd.Parameters.Add(new SqlParameter("@statusValue", list_filtrarEstatus.Text));
                    cmd.ExecuteNonQuery();
                    //Actualizar Tabla
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable consulta = new DataTable();
                    da.Fill(consulta);
                    tablaAsignaciones.DataSource = consulta;
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al filtrar los datos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void rd_BuscarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if(rd_BuscarTodo.Checked == true)
            {
                llenarTabla();
            }
        }

        private void tablaAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
