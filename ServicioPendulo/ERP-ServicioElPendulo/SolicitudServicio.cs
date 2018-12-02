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
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace ERP_ServicioElPendulo
{
    public partial class SolicitudServicio : Form
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);

        public SolicitudServicio()
        {
            InitializeComponent();
            //MaterialSkinManager sm = MaterialSkinManager.Instance;
            //sm.AddFormToManage(this);
            //sm.Theme = MaterialSkinManager.Themes.DARK;
            //sm.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
            this.AcceptButton = btn_Aceptar;
        }

        #region Validar Cierre Formulario

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


        #endregion



        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void link_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Este formulario se llenará usando el correo recibido por el director","Ayuda del formulario");
        }
        public bool validaciones()
        {
            bool validacionCorrecta = false;
            bool contacto = false;
            bool tipoServicio = false;
            bool sucursal = false;

            if (String.IsNullOrEmpty(list_ContactoSolicitante.Text))
            {
                contacto = false;
                MessageBox.Show("No se indico un contacto solicitante", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                contacto = true;
            }

            if (String.IsNullOrEmpty(list_TipoServicio.Text))
            {
                tipoServicio = false;
                MessageBox.Show("No se indicó un tipo de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tipoServicio = true;
            }
            if (String.IsNullOrEmpty(list_TipoServicio.Text))
            {
                sucursal = false;
                MessageBox.Show("No se indicó una sucursal", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sucursal = true;
            }
            if(contacto == true && tipoServicio == true && sucursal == true)
            {
                validacionCorrecta = true;
            }
            else
            {
                validacionCorrecta = false;
            }
            return validacionCorrecta;
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if(validaciones() == true)
            {
                bdOperations();
                Hide();
            }
            else
            {
                MessageBox.Show("Hay errores en la captura de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void SolicitudServicio_Load(object sender, EventArgs e)
        {
            materialLabel1.ForeColor = System.Drawing.Color.White;
            materialLabel2.ForeColor = System.Drawing.Color.White;
            materialLabel3.ForeColor = System.Drawing.Color.White;
            materialLabel4.ForeColor = System.Drawing.Color.White;
            materialLabel5.ForeColor = System.Drawing.Color.White;
            // TODO: esta línea de código carga datos en la tabla 'ds_ContactosSolicitud.ContactosInnova' Puede moverla o quitarla según sea necesario.
            //this.contactosInnovaTableAdapter.Fill(this.ds_ContactosSolicitud.ContactosInnova);

        }
        public void bdOperations()
        {
            string contactoSolicitante = list_ContactoSolicitante.Text;
            string tipoServicio = list_TipoServicio.Text;
            string sucursal = list_Sucursal.Text;
            string descrProbl = textBox_Descripcion.Text;
            string fechaC = fecha_Solicitud.Value.ToString("dd/MM/yyyy");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO solicitudServicio (ContactoSolicitante,TipoServicio,Sucursal,DescripcionProblema,FechaCaptura)"
                + "VALUES(@contacto,@Servicio,@Suacursal,@Descri,@fechaCaptura)";
            //
            cmd.Parameters.Add(new SqlParameter("@contacto", contactoSolicitante));
            cmd.Parameters.Add(new SqlParameter("@Servicio", tipoServicio));
            cmd.Parameters.Add(new SqlParameter("@Suacursal", sucursal));
            cmd.Parameters.Add(new SqlParameter("@Descri", descrProbl));
            cmd.Parameters.Add(new SqlParameter("@fechaCaptura", fechaC));
            //
            cmd.ExecuteNonQuery();
            MessageBox.Show("Solicitud registrada, puede administrarla en el apartado de solicitudes", "Exito!");
            con.Close();
        }
    }
}
