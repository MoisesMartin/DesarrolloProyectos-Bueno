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
    }
}
