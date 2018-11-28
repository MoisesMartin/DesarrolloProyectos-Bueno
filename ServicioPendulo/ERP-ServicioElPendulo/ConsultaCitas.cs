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
using iTextSharp;
using iTextSharp.text.pdf;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace ERP_ServicioElPendulo
{
    public partial class rd_BuscarTodo : MaterialForm
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);
        /* Validar Cierre de formulario*/

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

        public rd_BuscarTodo()
        {
            InitializeComponent();
            MaterialSkinManager sm = MaterialSkinManager.Instance;
            sm.AddFormToManage(this);
            sm.Theme = MaterialSkinManager.Themes.DARK;
            sm.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_generarPDF_Click(object sender, EventArgs e)
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
        void sumarCeldas()
        {
            int sumaCeldas = 0;
            sumaCeldas = tablaCitas.Rows.Count - 1;
            cantColumnas.Text = Convert.ToString(sumaCeldas);
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

           /* iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("./IMG/LOGOPendulo.jpg");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 100 / imagen.Width;
            imagen.ScalePercent(percentage * 80);
            // Insertamos la imagen en el documento
            doc.Add(imagen);*/
           
            //
            doc.Add(new Paragraph("Reporte de Citas"));
            doc.Add(Chunk.NEWLINE);
            //
            doc.Add(new Paragraph(operacion.Text));
            doc.Add(Chunk.NEWLINE);
            //Creando tabla y estableciendo un tamaño para cada una de las celdas
            PdfPTable tblPrueba = new PdfPTable(7);
            tblPrueba.WidthPercentage = 100;
            //

            PdfPCell clID = new PdfPCell(new Phrase("ID de Cita", _standardFont));
            clID.BorderWidth = 0;
            clID.BorderWidthBottom = 0.75f;

            //
            PdfPCell clSucursal = new PdfPCell(new Phrase("Sucursal", _standardFont));
            clSucursal.BorderWidth = 0;
            clSucursal.BorderWidthBottom = 0.75f;
            //

            PdfPCell clfechaCita = new PdfPCell(new Phrase("Fecha de Cita", _standardFont));
            clfechaCita.BorderWidth = 0;
            clfechaCita.BorderWidthBottom = 0.75f;

            //
            PdfPCell clhoraCita = new PdfPCell(new Phrase("Hora de Cita", _standardFont));
            clhoraCita.BorderWidth = 0;
            clhoraCita.BorderWidthBottom = 0.75f;
            //

            PdfPCell clAtendio = new PdfPCell(new Phrase("Persona que Atendio", _standardFont));
            clAtendio.BorderWidth = 0;
            clAtendio.BorderWidthBottom = 0.75f;

            //
            PdfPCell clEstatus = new PdfPCell(new Phrase("Estatus de Servicio", _standardFont));
            clEstatus.BorderWidth = 0;
            clEstatus.BorderWidthBottom = 0.75f;
            //Añadiendo las celdas al pdf
            tblPrueba.AddCell(clID);
            tblPrueba.AddCell(clSucursal);
            tblPrueba.AddCell(clfechaCita);
            tblPrueba.AddCell(clhoraCita);
            tblPrueba.AddCell(clhoraCita);
            tblPrueba.AddCell(clAtendio);
            tblPrueba.AddCell(clEstatus);
            //Llenando la tabla
            foreach (DataGridViewRow Row in tablaCitas.Rows)
            {
                String strFila = Row.Index.ToString();
                if (!Row.IsNewRow)
                {
                    clID = new PdfPCell(new Phrase(Convert.ToString(tablaCitas.Rows[Convert.ToInt32(strFila)].Cells[0].Value.ToString()), _standardFont));
                    clID.BorderWidth = 0;
                    clSucursal = new PdfPCell(new Phrase(Convert.ToString(tablaCitas.Rows[Convert.ToInt32(strFila)].Cells[1].Value.ToString()), _standardFont));
                    clSucursal.BorderWidth = 0;
                    clfechaCita = new PdfPCell(new Phrase(Convert.ToString(tablaCitas.Rows[Convert.ToInt32(strFila)].Cells[2].Value.ToString()), _standardFont));
                    clfechaCita.BorderWidth = 0;
                    clhoraCita = new PdfPCell(new Phrase(Convert.ToString(tablaCitas.Rows[Convert.ToInt32(strFila)].Cells[3].Value.ToString()), _standardFont));
                    clhoraCita.BorderWidth = 0;
                    clAtendio = new PdfPCell(new Phrase(Convert.ToString(tablaCitas.Rows[Convert.ToInt32(strFila)].Cells[4].Value.ToString()), _standardFont));
                    clAtendio.BorderWidth = 0;
                    clEstatus = new PdfPCell(new Phrase(Convert.ToString(tablaCitas.Rows[Convert.ToInt32(strFila)].Cells[0].Value.ToString()), _standardFont));
                    clEstatus.BorderWidth = 0;
                    //
                    tblPrueba.AddCell(clID);
                    tblPrueba.AddCell(clSucursal);
                    tblPrueba.AddCell(clfechaCita);
                    tblPrueba.AddCell(clhoraCita);
                    tblPrueba.AddCell(clhoraCita);
                    tblPrueba.AddCell(clAtendio);
                    tblPrueba.AddCell(clEstatus);
                }
            }
            doc.Add(tblPrueba);
            //Siguiente 
            //
            doc.Add(new Paragraph("Consulta realizada el:" + DateTime.Now.ToString("yyyy-MM-dd ; HH: mm")));
            doc.Add(Chunk.NEWLINE);
            //
            doc.Add(new Paragraph("Total de Citas en Consulta: " + cantColumnas.Text));
            doc.Add(Chunk.NEWLINE);
            doc.Close();
            writer.Close();
        }
        private void btn_Back_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'servicioElPenduloDataSet3.CitasAgendadas' Puede moverla o quitarla según sea necesario.
            LlenarTabla();
            sumarCeldas();
            operacion.Text = "Consulta General de Citas Agendadas";
        }

        private void tablaCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calendarioCitas_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void LlenarTabla()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM CitasAgendadas";
                cmd.ExecuteNonQuery();
                //Actualizar Tabla
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable consulta = new DataTable();
                da.Fill(consulta);
                tablaCitas.DataSource = consulta;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error desconocido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            string statusV = combo_Estatus.Text;
            if (filtrarEstatus.Checked)
            {
                operacion.Text = "Consulta de Citas por Su Estatus:   " + combo_Estatus.Text;
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM CitasAgendadas WHERE EstatusCita = @statusValue";
                    cmd.Parameters.Add(new SqlParameter("@statusValue", statusV));
                    cmd.ExecuteNonQuery();
                    //Actualizar Tabla
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable consulta = new DataTable();
                    da.Fill(consulta);
                    tablaCitas.DataSource = consulta;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Error desconocido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sumarCeldas();
            }
            else if (porFechaA.Checked)
            {
                operacion.Text = "Consulta de Citas por Fecha en la que se Registró";
                string fechaCaptura = fechaCita.Text;
                filtrarEstatus.Checked = false;
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM CitasAgendadas WHERE FechaAgendacion = @fechaCita";
                    cmd.Parameters.Add(new SqlParameter("@fechaCita", fechaCaptura));
                    cmd.ExecuteNonQuery();
                    //Actualizar Tabla
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable consulta = new DataTable();
                    da.Fill(consulta);
                    tablaCitas.DataSource = consulta;
                    con.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message + "Error desconocido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (porFechaC.Checked)
            {
                operacion.Text = "Consulta de Citas por Fecha Acordada con la Sucursal";
                string fechaAgendada = porFechaAgenda.Text;
                filtrarEstatus.Checked = false;
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM CitasAgendadas WHERE FechaCita = @fechaCita";
                    cmd.Parameters.Add(new SqlParameter("@fechaCita", fechaAgendada));
                    cmd.ExecuteNonQuery();
                    //Actualizar Tabla
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable consulta = new DataTable();
                    da.Fill(consulta);
                    tablaCitas.DataSource = consulta;
                    con.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message + "Error desconocido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rdBuscarTodo.Checked)
            {
                operacion.Text = "Consulta de Todas las Citas Agendadas y Pendientes";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM CitasAgendadas";
                cmd.ExecuteNonQuery();
                //Actualizar Tabla
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable consulta = new DataTable();
                da.Fill(consulta);
                tablaCitas.DataSource = consulta;
                con.Close();
            }
            {

            }
        }

        private void combo_Estatus_TextChanged(object sender, EventArgs e)
        {
            string statusV = combo_Estatus.Text;
            if (filtrarEstatus.Checked)
            {
                operacion.Text = "Consulta de Citas por Su Estatus:   " + combo_Estatus.Text;
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM CitasAgendadas WHERE EstatusCita = @statusValue";
                    cmd.Parameters.Add(new SqlParameter("@statusValue", statusV));
                    cmd.ExecuteNonQuery();
                    //Actualizar Tabla
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable consulta = new DataTable();
                    da.Fill(consulta);
                    tablaCitas.DataSource = consulta;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Error desconocido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sumarCeldas();
            }
        }

        private void tablaCitas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
