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
using MiLibreria;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace ERP_ServicioElPendulo
{
    public partial class ConsultaSolicitudes : Form
    {

        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);
        /* Validar Cierre de formulario*

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Cerrar() == false)
                e.Cancel = true;
        }
        public static bool Cerrar()
        {
            const string mensaje = "¿Seguro que deseas salir?";
            const string cabecera = "Confirmacion de cierre";

            var resultado = MessageBox.Show(mensaje, cabecera, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
        /*-------------------*/

        public ConsultaSolicitudes()
        {
            InitializeComponent();
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_GenerarPDF_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog guardarComo = new SaveFileDialog();
            guardarComo.Filter = "Archivos PDF (*.pdf)|*.pdf";
            guardarComo.FilterIndex = 2;
            guardarComo.RestoreDirectory = true;
            //Invocando al cuadro Guardar y generand el PDF
            try
            {
                if (guardarComo.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = guardarComo.OpenFile()) != null)
                    {
                        myStream.Close();
                        crearPDF(guardarComo.FileName);
                        MessageBox.Show("Guardado exitosamente", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void crearPDF(string nombre)
        {
            Document doc = new Document(PageSize.LETTER);
            MessageBox.Show(nombre);
            //Creando el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@nombre, FileMode.Create));
            doc.AddTitle(nombre);
            doc.AddCreator("Servicio El Pendulo");
            doc.Open();
            //Tipo de fuente
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            // Creamos la imagen y le ajustamos el tamaño
            /*
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("./IMG/LOGOPendulo.jpg");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 100 / imagen.Width;
            imagen.ScalePercent(percentage * 80);
            // Insertamos la imagen en el documento
            doc.Add(imagen);
            */
            //
            doc.Add(new Paragraph("Reporte de Solicitudes de Servicio"));
            doc.Add(Chunk.NEWLINE);
            //Creando tabla y estableciendo un tamaño para cada una de las celdas
            PdfPTable tblSolicitudes = new PdfPTable(5);
            tblSolicitudes.WidthPercentage = 100;
            //
            PdfPCell clID = new PdfPCell(new Phrase("ID de Solicitud", _standardFont));
            clID.BorderWidth = 0;
            clID.BorderWidthBottom = 0.75f;
            //
            PdfPCell clContacto = new PdfPCell(new Phrase("Contacto Solicitante", _standardFont));
            clID.BorderWidth = 0;
            clID.BorderWidthBottom = 0.75f;
            //
            PdfPCell clTServicio = new PdfPCell(new Phrase("Tipo de Servicio", _standardFont));
            clTServicio.BorderWidth = 0;
            clTServicio.BorderWidthBottom = 0.75f;
            //
            PdfPCell clSucursal = new PdfPCell(new Phrase("Sucursal", _standardFont));
            clSucursal.BorderWidth = 0;
            clSucursal.BorderWidthBottom = 0.75f;
            //
            PdfPCell clFechaCaptura = new PdfPCell(new Phrase("Fecha de Captura", _standardFont));
            clFechaCaptura.BorderWidth = 0;
            clFechaCaptura.BorderWidthBottom = 0.75f;
            //Añadiendo las celdas
            tblSolicitudes.AddCell(clID);
            tblSolicitudes.AddCell(clContacto);
            tblSolicitudes.AddCell(clTServicio);
            tblSolicitudes.AddCell(clSucursal);
            tblSolicitudes.AddCell(clFechaCaptura);
            //Llenando tabla
            //Llenando la tabla
            foreach (DataGridViewRow Row in dt_SolicitudesR.Rows)
            {
                String strFila = Row.Index.ToString();
                if (!Row.IsNewRow)
                {
                    clID = new PdfPCell(new Phrase(Convert.ToString(dt_SolicitudesR.Rows[Convert.ToInt32(strFila)].Cells[0].Value.ToString()), _standardFont));
                    clID.BorderWidth = 0;
                    clContacto = new PdfPCell(new Phrase(Convert.ToString(dt_SolicitudesR.Rows[Convert.ToInt32(strFila)].Cells[1].Value.ToString()), _standardFont));
                    clContacto.BorderWidth = 0;
                    clTServicio = new PdfPCell(new Phrase(Convert.ToString(dt_SolicitudesR.Rows[Convert.ToInt32(strFila)].Cells[2].Value.ToString()), _standardFont));
                    clTServicio.BorderWidth = 0;
                    clSucursal = new PdfPCell(new Phrase(Convert.ToString(dt_SolicitudesR.Rows[Convert.ToInt32(strFila)].Cells[3].Value.ToString()), _standardFont));
                    clSucursal.BorderWidth = 0;
                    clFechaCaptura = new PdfPCell(new Phrase(Convert.ToString(dt_SolicitudesR.Rows[Convert.ToInt32(strFila)].Cells[5].Value.ToString()), _standardFont));
                    clFechaCaptura.BorderWidth = 0;
                    //
                    tblSolicitudes.AddCell(clID);
                    tblSolicitudes.AddCell(clContacto);
                    tblSolicitudes.AddCell(clTServicio);
                    tblSolicitudes.AddCell(clSucursal);
                    tblSolicitudes.AddCell(clFechaCaptura);
                }
            }
            //Añadiendo la tabla 
            doc.Add(tblSolicitudes);
            //Cerrando la edición del Archivo

            doc.Close();
            writer.Close();

        }
        private void rd_buscarPorContacto_CheckedChanged(object sender, EventArgs e)
        {
            if(rd_buscarPorContacto.Checked == true)
            {
                buscarPContacto.Enabled = true;
            }
            else
            {
                buscarPContacto.Enabled = false;
            }
        }

        private void rd_porFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_porFecha.Checked == true)
            {
                date_buscarPorFecha.Enabled = true;
            }
            else
            {
                date_buscarPorFecha.Enabled = false;
            }
        }

        private void rd_BuscarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if(rd_BuscarTodo.Checked == true)
            {
                buscarPContacto.Enabled = false;
                date_buscarPorFecha.Enabled = false;
            }
        }

        private void ayuda_Filtrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Seleccione un criterio de filtrado para realizar busquedas específicas, seleccione Mostrar todo para desplegar toda la información de la base de datos de Solicitudes","Ayuda de filtrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConsultaSolicitudes_Load(object sender, EventArgs e)
        {
            materialLabel1.ForeColor = System.Drawing.Color.White;
            materialLabel2.ForeColor = System.Drawing.Color.White;
            materialLabel3.ForeColor = System.Drawing.Color.White;
            materialLabel4.ForeColor = System.Drawing.Color.White;
            label4.ForeColor = System.Drawing.Color.White;
            cantColumnas.ForeColor = System.Drawing.Color.White;
            llenarTabla();

        }

        private void combo_buscarPorContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_SolicitudesR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenarTabla()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM solicitudServicio";
                //
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable consulta = new DataTable();
                da.Fill(consulta);
                dt_SolicitudesR.DataSource = consulta;
                con.Close();
            }
            catch(Exception ex){
                MessageBox.Show("No se pudieron obtener los datos", "Error");
            }
        }
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            if(rd_buscarPorContacto.Checked)
            {
                string patron = buscarPContacto.Text;
                dt_SolicitudesR.DataSource = null;
                dt_SolicitudesR.Update();
                dt_SolicitudesR.Refresh();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM solicitudServicio WHERE ContactoSolicitante=@PATRON";
                //
                cmd.Parameters.Add(new SqlParameter("@PATRON", patron));
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable consulta = new DataTable();
                da.Fill(consulta);
                dt_SolicitudesR.DataSource = consulta;
                con.Close();
            }
            else if (rd_porFecha.Checked)
            {
                string fecha = date_buscarPorFecha.Text;
                dt_SolicitudesR.DataSource = null;
                dt_SolicitudesR.Update();
                dt_SolicitudesR.Refresh();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM solicitudServicio WHERE FechaCaptura=@PATRON";
                //
                cmd.Parameters.Add(new SqlParameter("@PATRON", fecha));
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable consulta = new DataTable();
                da.Fill(consulta);
                dt_SolicitudesR.DataSource = consulta;
                con.Close();
            }
           else if (rd_BuscarTodo.Checked)
            {
                
                dt_SolicitudesR.DataSource = null;
                dt_SolicitudesR.Update();
                dt_SolicitudesR.Refresh();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM solicitudServicio";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable consulta = new DataTable();
                da.Fill(consulta);
                dt_SolicitudesR.DataSource = consulta;
                con.Close();
            }
        }
       
    }
}
