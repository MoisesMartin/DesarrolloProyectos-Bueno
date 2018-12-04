using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ERP_ServicioElPendulo
{
    public partial class QuejasReincidencias : Form
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);

        public QuejasReincidencias()
        {
            InitializeComponent();
        }

        private void QuejasReincidencias_Load(object sender, EventArgs e)
        {
            graficarQuejasReincidencias();
        }
        public void graficarQuejasReincidencias()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM Asignaciones WHERE EstatusTrabajo =@Estatus";
                cmd.Parameters.Add(new SqlParameter("@Estatus", "Realizado"));
                Int32 counRealizados = (Int32)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                con.Close();
                nTotalServicios.Text = Convert.ToString(counRealizados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Error desconocido al recuperar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT COUNT(*) FROM Asignaciones WHERE EstatusTrabajo =@Estatus";
                cmd1.Parameters.Add(new SqlParameter("@Estatus", "Queja"));
                Int32 counQueja = (Int32)cmd1.ExecuteScalar();
                cmd1.ExecuteNonQuery();
                con.Close();
                nQuejas.Text = Convert.ToString(counQueja);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error desconocido al recuperar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                con.Open();
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT COUNT(*) FROM Asignaciones WHERE EstatusTrabajo =@Estatus";
                cmd2.Parameters.Add(new SqlParameter("@Estatus", "Reincidencia"));
                Int32 counReincidencia = (Int32)cmd2.ExecuteScalar();
                cmd2.ExecuteNonQuery();
                con.Close();
                nReincidencias.Text = Convert.ToString(counReincidencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error desconocido al recuperar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            int TotalServicios = Convert.ToInt32(nTotalServicios.Text);
            int Quejas = Convert.ToInt32(nQuejas.Text);
            int Reincidencias = Convert.ToInt32(nReincidencias.Text);
            int ServiciosCompletados=0;
            int ServiciosIncompletos=0;

            string[] series = {SerieTotal.Text,SerieQuejas.Text,SerieReincidencias.Text};
            int[] puntos = {TotalServicios,Quejas,Reincidencias};
            chartQuejas.Titles.Add("Total de Servicios vs Quejas Registradas");
            for(int i=0;i<series.Length;i++)
            {
                //encabezados
                Series serie = chartQuejas.Series.Add(series[i]);
                //Valores
                serie.Label = puntos[i].ToString();
                //Valores numericos
                serie.Points.Add(puntos[i]);
            }
            ServiciosCompletados = TotalServicios - Quejas - Reincidencias;
            ServiciosIncompletos = Quejas + Reincidencias;
            nExitosos.Text = ServiciosCompletados.ToString();
            n_NoExitosos.Text = ServiciosIncompletos.ToString();
        }
    }
}
