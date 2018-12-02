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
    public partial class GestionTiendas : Form
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);

        public GestionTiendas()
        {
            InitializeComponent();
        }

        private void GestionTiendas_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
        private void llenarTabla()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Sucursal";
                //
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable consulta = new DataTable();
                da.Fill(consulta);
                tablaSucursales.DataSource = consulta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron obtener los datos", "Error");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if(btn_Modificar.Text == "Actualizar")
            {
                actualizar();
            }
            else if(btn_Modificar.Text == "Eliminar")
            {
                eliminar();
            }
        }

        private void check_Operacion_OnChange(object sender, EventArgs e)
        {
            if (check_Operacion.Checked)
            {
                txtID1.Enabled = true;
                txt_DT.Enabled = true;
                txt_Nombre.Enabled = true;
                txt_telFijo.Enabled = true;
                txt_Celu.Enabled = true;
                txt_DelMun.Enabled = true;
                txt_Calle.Enabled = true;
                txt_Colonia.Enabled = true;
                txtCP.Enabled = true;
                btn_Modificar.Text = "Actualizar";
            }
            else
            {
                txtID1.Enabled = false;
                txt_DT.Enabled = false;
                txt_Nombre.Enabled = false;
                txt_telFijo.Enabled = false;
                txt_Celu.Enabled = false;
                txt_DelMun.Enabled = false;
                txt_Calle.Enabled = false;
                txt_Colonia.Enabled = false;
                txtCP.Enabled = false;
                btn_Modificar.Text = "Eliminar";
            }
        }
        private void actualizar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Sucursal SET DT=@A,Nombre=@B,TelefonoFijo=@C,TelefonoCelular=@D,Calle=@E,Colonia=@F,DelegacionMunicipio=@G,CodigoPostal=@H WHERE ID_General =@ID";
                cmd.Parameters.Add(new SqlParameter("@A", txtDT.Value));
                cmd.Parameters.Add(new SqlParameter("@B", txt_Nombre.Text));
                cmd.Parameters.Add(new SqlParameter("@C", txt_telFijo.Text));
                cmd.Parameters.Add(new SqlParameter("@D", txt_Celu.Text));
                cmd.Parameters.Add(new SqlParameter("@E", txt_Calle.Text));
                cmd.Parameters.Add(new SqlParameter("@F", txt_Colonia.Text));
                cmd.Parameters.Add(new SqlParameter("@G", txt_DelMun.Text));
                cmd.Parameters.Add(new SqlParameter("@H", txtCP.Text));
                cmd.Parameters.Add(new SqlParameter("@ID", txtID1.Text));
                //
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            llenarTabla();
        }
        private void eliminar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Sucursal";
                //
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            llenarTabla();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            InsertarTienda();
            llenarTabla();
        }
        private void InsertarTienda()
        {
            int idTienda = Convert.ToInt32(txt_IDGeneral.Text);
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Sucursal VALUES(@A,@B,@C,@D,@E,@F,@G,@H,@I)";
                cmd.Parameters.Add(new SqlParameter("@A", idTienda));
                cmd.Parameters.Add(new SqlParameter("@B", txtDT.Value));
                cmd.Parameters.Add(new SqlParameter("@C", txt_NombreSucursal.Text));
                cmd.Parameters.Add(new SqlParameter("@D", fijo.Text));
                cmd.Parameters.Add(new SqlParameter("@E", txtCelular.Text));
                cmd.Parameters.Add(new SqlParameter("@F", txt_DelegacionMunicipio.Text));
                cmd.Parameters.Add(new SqlParameter("@G", txtCalle.Text));
                cmd.Parameters.Add(new SqlParameter("@H", txtColonia.Text));
                cmd.Parameters.Add(new SqlParameter("@I", txtCP.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sucursal Registrada", "Listo");
                txt_IDGeneral.Text = "";
                txt_DT.Value = 0;
                txt_NombreSucursal.Text = "";
                fijo.Text = "";
                txt_Celu.Text = "";
                txt_DelegacionMunicipio.Text = "";
                txtCalle.Text = "";
                txtColonia.Text = "";
                txtCP.Text = "";
                btn_Modificar.Text = "Actualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var ID_General = tablaSucursales.Rows[e.RowIndex].Cells[0].Value;
                txtID1.Text = ID_General.ToString();
                //
                var DT = tablaSucursales.Rows[e.RowIndex].Cells[1].Value;
                txtDT.Text = DT.ToString();
                //
                var Nombre = tablaSucursales.Rows[e.RowIndex].Cells[2].Value;
                txt_Nombre.Text = Nombre.ToString();
                //
                var TF = tablaSucursales.Rows[e.RowIndex].Cells[3].Value;
                txt_telFijo.Text = TF.ToString();
                //
                var Cel = tablaSucursales.Rows[e.RowIndex].Cells[4].Value;
                txt_Celu.Text = Cel.ToString();
                //
                var calle = tablaSucursales.Rows[e.RowIndex].Cells[5].Value;
                txt_Calle.Text = calle.ToString();
                //
                var colonia = tablaSucursales.Rows[e.RowIndex].Cells[6].Value;
                txt_Colonia.Text = colonia.ToString();
                //
                var DM = tablaSucursales.Rows[e.RowIndex].Cells[7].Value;
                txt_DelMun.Text = DM.ToString();
                //
                var CP = tablaSucursales.Rows[e.RowIndex].Cells[8].Value;
                txtCP.Text = CP.ToString();
                //
            }
            catch (Exception ex)
            {

            }
        }
    }
}
