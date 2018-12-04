using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ERP_ServicioElPendulo
{
    public partial class QuejasReincidencias : Form
    {
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
            int TotalServicios = Convert.ToInt32(nTotalServicios.Text);
            int Quejas = Convert.ToInt32(nQuejas.Text);
            int Reincidencias = Convert.ToInt32(nReincidencias.Text);
            int ServiciosCompletados=0;
            int ServiciosIncompletos=0;
            float porcentajeEfectividad = 0.0f;
            float auxPorcentaje = 0.0f;

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
            auxPorcentaje = ServiciosIncompletos / 100;
            porcentajeEfectividad = ServiciosCompletados * auxPorcentaje;
            nPorcentaje.Text = porcentajeEfectividad.ToString() + " %";
        }
    }
}
