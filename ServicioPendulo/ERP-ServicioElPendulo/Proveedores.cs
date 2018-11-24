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
    public partial class Proveedores : Form
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);

        public Proveedores()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            borrarTablaCotizacion();
            Hide();
        }
        public void borrarTablaCotizacion()
        {
            tablaCotizaciones.DataSource = null;
            tablaCotizaciones.Update();
            tablaCotizaciones.Refresh();
            con.Open();
            SqlCommand cmd_update = con.CreateCommand();
            cmd_update.CommandType = CommandType.Text;
            cmd_update.CommandText = "DELETE FROM Cotizaciones";
            SqlDataAdapter da = new SqlDataAdapter(cmd_update);
            DataTable cotizacion = new DataTable();
            da.Fill(cotizacion);
            tablaCotizaciones.DataSource = cotizacion;
            con.Close();
        }
        public void suma()
        {
            float suma = 0.0f;
            int cantA = 0;
            int totalArtis = 0;
            string totalCotizacion = "", totalArtT="";
            for(int i=0; i<tablaCotizaciones.RowCount;i++)
            {
                suma += (float)Convert.ToDouble(tablaCotizaciones.Rows[i].Cells[5].Value);
                cantA += Convert.ToInt32(tablaCotizaciones.Rows[i].Cells[3].Value);
            }
            totalCotizacion = Convert.ToString(suma);
            costoTotal.Text = totalCotizacion;
            sumaArticulos.Text = cantA.ToString();
        }
        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'servicioElPenduloDataSet5.Cotizaciones' Puede moverla o quitarla según sea necesario.
            this.cotizacionesTableAdapter.Fill(this.servicioElPenduloDataSet5.Cotizaciones);
            // TODO: esta línea de código carga datos en la tabla 'servicioElPenduloDataSet4.LaBallena' Puede moverla o quitarla según sea necesario.
            this.laBallenaTableAdapter.Fill(this.servicioElPenduloDataSet4.LaBallena);


        }

        private void tablaLaBallena_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var item = tablaLaBallena.Rows[e.RowIndex].Cells[1].Value;
                lbl_Producto.Text = item.ToString();
                var precioItemC = tablaLaBallena.Rows[e.RowIndex].Cells[2].Value;
                precioItem.Text = precioItemC.ToString();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Operación inválida","Operación Imposible "+ ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string cantidadSeleccText = cantidadItems.Value.ToString();
            string precioItemText = precioItem.Text;
            int cantidadSelecc = Convert.ToInt32(cantidadSeleccText);
            int precioItemV = Convert.ToInt32(precioItemText);
            float total = cantidadSelecc * precioItemV;
            string totalText = Convert.ToString(total);
            totalProv.Text = totalText;
            costoTotal.Text = totalText;
            agregarCotizacion();
            actualizar();
            cantidadItems.Value = 1;
            suma();
        }
        public void actualizar()
        {
            tablaCotizaciones.DataSource = null;
            tablaCotizaciones.Update();
            tablaCotizaciones.Refresh();
            con.Open();
            SqlCommand cmd_update = con.CreateCommand();
            cmd_update.CommandType = CommandType.Text;
            cmd_update.CommandText = "SELECT * FROM Cotizaciones";
            SqlDataAdapter da = new SqlDataAdapter(cmd_update);
            DataTable cotizacion = new DataTable();
            da.Fill(cotizacion);
            tablaCotizaciones.DataSource = cotizacion;
            con.Close();
        }
        public void agregarCotizacion()
        {
            string nombreProveedor = nameP.Text;
            string valorArticulo = lbl_Producto.Text;
            int cantidadArts = Convert.ToInt32(cantidadItems.Value);
            float costoU = (float)Convert.ToDouble(precioItem.Text);
            float costoT = (float)Convert.ToDouble(totalProv.Text);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Cotizaciones (Proveedor,Articulo,Cantidad,CostoUnitario,CostoTotal)"
                + "VALUES(@a,@b,@c,@d,@e)";
            //
            cmd.Parameters.Add(new SqlParameter("@a", nombreProveedor));
            cmd.Parameters.Add(new SqlParameter("@b", valorArticulo));
            cmd.Parameters.Add(new SqlParameter("@c", cantidadArts));
            cmd.Parameters.Add(new SqlParameter("@d", costoU));
            cmd.Parameters.Add(new SqlParameter("@e", costoT));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            borrarTablaCotizacion();
        }

        private void tablaCotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
