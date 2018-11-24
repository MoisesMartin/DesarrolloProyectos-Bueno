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
    public partial class RegistrarTiendas : Form
    {
        public static string conString = @"Data Source=DESKTOP-GL238MR\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        public RegistrarTiendas()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            con.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
