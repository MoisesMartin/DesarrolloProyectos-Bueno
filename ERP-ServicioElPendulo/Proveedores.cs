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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
        public void llenarTabla()
        {
            try
            {
                con.Open();
                SqlCommand cmd_update = con.CreateCommand();
                cmd_update.CommandType = CommandType.Text;
                cmd_update.CommandText = "SELECT * FROM LaBallena";
                SqlDataAdapter da = new SqlDataAdapter(cmd_update);
                DataTable ballena = new DataTable();
                da.Fill(ballena);
                tablaLaBallena.DataSource = ballena;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo recuperar la informacion:" + ex.Message, "Error Desconocido");
            }
        }
        private void Proveedores_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'servicioElPenduloDataSet5.Cotizaciones' Puede moverla o quitarla según sea necesario.
            this.cotizacionesTableAdapter.Fill(this.servicioElPenduloDataSet5.Cotizaciones);
            llenarTabla();


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
                        MessageBox.Show("Archivo Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            borrarTablaCotizacion();
        }
        public void crearPDF(String nombre)
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

            /* iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("./IMG/LOGOPendulo.jpg");
             imagen.BorderWidth = 0;
             imagen.Alignment = Element.ALIGN_RIGHT;
             float percentage = 0.0f;
             percentage = 100 / imagen.Width;
             imagen.ScalePercent(percentage * 80);
             // Insertamos la imagen en el documento
             doc.Add(imagen);*/

            //
            doc.Add(new Paragraph("Cotización de Proveedor"));
            doc.Add(Chunk.NEWLINE);
            //
            //
            doc.Add(new Paragraph("Cotización Realizada el:" + fecha_Cotizacion.Value.ToString("dddd, dd MMMM yyyy")));
            doc.Add(Chunk.NEWLINE);
            //
            PdfPTable tblCotizacion = new PdfPTable(5);
            tblCotizacion.WidthPercentage = 100;
            //
            PdfPCell clPr = new PdfPCell(new Phrase("Proveedor", _standardFont));
            clPr.BorderWidth = 0;
            clPr.BorderWidthBottom = 0.75f;
            //
            PdfPCell clArt = new PdfPCell(new Phrase("Articulo", _standardFont));
            clArt.BorderWidth = 0;
            clArt.BorderWidthBottom = 0.75f;
            //
            PdfPCell clCant = new PdfPCell(new Phrase("Cantidad", _standardFont));
            clCant.BorderWidth = 0;
            clCant.BorderWidthBottom = 0.75f;
            //
            PdfPCell clCU = new PdfPCell(new Phrase("Costo Unitario", _standardFont));
            clCU.BorderWidth = 0;
            clCU.BorderWidthBottom = 0.75f;
            //
            PdfPCell clCT = new PdfPCell(new Phrase("Proveedor", _standardFont));
            clCT.BorderWidth = 0;
            clCT.BorderWidthBottom = 0.75f;       
            //
            doc.Add(new Paragraph("Tabla: " + sumaArticulos.Text));
            doc.Add(Chunk.NEWLINE);
            //
            tblCotizacion.AddCell(clPr);
            tblCotizacion.AddCell(clArt);
            tblCotizacion.AddCell(clCant);
            tblCotizacion.AddCell(clCU);
            tblCotizacion.AddCell(clCT);
            //Llenando la Tabla
            foreach (DataGridViewRow Row in tablaCotizaciones.Rows)
            {
                String strFila = Row.Index.ToString();
                if (!Row.IsNewRow)
                {
                    clPr = new PdfPCell(new Phrase(Convert.ToString(tablaCotizaciones.Rows[Convert.ToInt32(strFila)].Cells[1].Value.ToString()), _standardFont));
                    clPr.BorderWidth = 0;
                    clArt = new PdfPCell(new Phrase(Convert.ToString(tablaCotizaciones.Rows[Convert.ToInt32(strFila)].Cells[2].Value.ToString()), _standardFont));
                    clArt.BorderWidth = 0;
                    clCant = new PdfPCell(new Phrase(Convert.ToString(tablaCotizaciones.Rows[Convert.ToInt32(strFila)].Cells[3].Value.ToString()), _standardFont));
                    clCant.BorderWidth = 0;
                    clCU = new PdfPCell(new Phrase(Convert.ToString(tablaCotizaciones.Rows[Convert.ToInt32(strFila)].Cells[4].Value.ToString()), _standardFont));
                    clCU.BorderWidth = 0;
                    clCT = new PdfPCell(new Phrase(Convert.ToString(tablaCotizaciones.Rows[Convert.ToInt32(strFila)].Cells[5].Value.ToString()), _standardFont));
                    clCT.BorderWidth = 0;
                    //
                    tblCotizacion.AddCell(clPr);
                    tblCotizacion.AddCell(clArt);
                    tblCotizacion.AddCell(clCant);
                    tblCotizacion.AddCell(clCU);
                    tblCotizacion.AddCell(clCT);
                }
            }
            doc.Add(tblCotizacion);
            //
            doc.Add(new Paragraph("Total de Articulos: " + sumaArticulos.Text));
            doc.Add(Chunk.NEWLINE);
            //
            doc.Add(new Paragraph("Total de Cotización: " + costoTotal.Text + " pesos mexicanos"));
            doc.Add(Chunk.NEWLINE);
            //Margenes
      
            //Cerrando el Archivo
            doc.Close();
            writer.Close();
        }
  
        private void tablaCotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
