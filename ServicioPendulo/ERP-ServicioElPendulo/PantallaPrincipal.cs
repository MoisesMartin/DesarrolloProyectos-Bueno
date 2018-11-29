using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ServicioElPendulo
{
    public partial class PantallaPrincipal : Form
    {

        public PantallaPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
        }



        #region Validar_Cierre_Formulario
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

        
        private void infoNS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Permite registrar las solicitudes de servicio enviadas por los contactos innova","Nueva Solicitud de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoAgenda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Permite agendar citas con las tiendas a las que se les va a realizar algún mantenimiento","Agendación de Citas",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Solicitud_Click_1(object sender, EventArgs e)
        {
            SolicitudServicio solicitud = new SolicitudServicio();
            solicitud.Show();
            Hide();
        }

        private void btn_Agendar_Click(object sender, EventArgs e)
        {
            AgendarCita agendar = new AgendarCita();
            agendar.Show();
            Hide();
        }

        private void btn_ConsultaCitas_Click(object sender, EventArgs e)
        {
            rd_BuscarTodo consultacitas = new rd_BuscarTodo();
            consultacitas.Show();
            Hide();
        }

        private void btn_VerSolicitudes_Click(object sender, EventArgs e)
        {
            ConsultaSolicitudes solicitudes = new ConsultaSolicitudes();
            solicitudes.Show();
            Hide();
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            Correos correo = new Correos();
            correo.Show();
            Hide();
        }

        private void btn_gestionTecnicos_Click(object sender, EventArgs e)
        {
            OperacionesUsuarios gestionTecnicos = new OperacionesUsuarios();
            gestionTecnicos.Show();
            Hide();
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.Show();
            Hide();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void link_SalirLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_Login salir = new form_Login();
            salir.Show();
            Hide();
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            AsignarTrabajos asignarTrabajos = new AsignarTrabajos();
            asignarTrabajos.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            reporteOptions.Visible = false;
            tecnicosOptions.Visible = false;
            recursosOptions.Visible = false;
            quejasOptions.Visible = false;
            registroOptions.Visible = false;

            if (barraLateral.Width < 270)
            {
                barraLateral.Width = 270;
                logoAnimation.ShowSync(logo);
            }
          else
          {
                logo.Visible = false;
                barraLateral.Width = 50;
            }
   
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ajustaBarra();
            if (registroOptions.Visible == false)
            {
                reporteOptions.Visible = false;
                tecnicosOptions.Visible = false;
                recursosOptions.Visible = false;
                quejasOptions.Visible = false;
                sideBarAnimation2.ShowSync(registroOptions);
            } else {
                registroOptions.Visible = false;
            }
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ajustaBarra();
            if (recursosOptions.Visible == false)
            {
                tecnicosOptions.Visible = false;
                registroOptions.Visible = false;
                quejasOptions.Visible = false;
                reporteOptions.Visible = false;
                sideBarAnimation2.ShowSync(recursosOptions);
            }
            else
            {
                recursosOptions.Visible = false;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ajustaBarra();
            if (tecnicosOptions.Visible == false)
            {
                registroOptions.Visible = false;
                recursosOptions.Visible = false;
                quejasOptions.Visible = false;
                reporteOptions.Visible = false;
                sideBarAnimation2.ShowSync(tecnicosOptions);
            }
            else
            {
                tecnicosOptions.Visible = false;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            ajustaBarra();
            if (quejasOptions.Visible == false)
            {
                registroOptions.Visible = false;
                recursosOptions.Visible = false;
                tecnicosOptions.Visible = false;
                reporteOptions.Visible = false;
                sideBarAnimation2.ShowSync(quejasOptions);
            }
            else
            {
                quejasOptions.Visible = false;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            ajustaBarra();
            if (reporteOptions.Visible == false)
            {
                registroOptions.Visible = false;
                recursosOptions.Visible = false;
                tecnicosOptions.Visible = false;
                quejasOptions.Visible = false;
                sideBarAnimation2.ShowSync(reporteOptions);
            }
            else
            {
                reporteOptions.Visible = false;
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            cambioPantalla("Formulario de Solicitud de Servicio");
            SolicitudServicio solicitud = new SolicitudServicio();
            solicitud.TopLevel = false;
            contenidoForms.Controls.Add(solicitud);
            solicitud.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            solicitud.Dock = DockStyle.Fill;
            solicitud.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            contenidoForms.Controls.Clear();
            cambioPantalla("Agendar Cita");
            AgendarCita agendar = new AgendarCita();
            agendar.TopLevel = false;
            contenidoForms.Controls.Add(agendar);
            agendar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            agendar.Dock = DockStyle.Fill;
            agendar.Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            cambioPantalla("Solicitudes de Servicio Registradas");
            ConsultaSolicitudes solicitudes = new ConsultaSolicitudes();
            solicitudes.TopLevel = false;
            contenidoForms.Controls.Add(solicitudes);
            solicitudes.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            solicitudes.Dock = DockStyle.Fill;
            solicitudes.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            cambioPantalla("Consulta de Citas");
            rd_BuscarTodo consultacitas = new rd_BuscarTodo();
            consultacitas.TopLevel = false;
            contenidoForms.Controls.Add(consultacitas);
            consultacitas.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            consultacitas.Dock = DockStyle.Fill;
            consultacitas.Show();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
            Proveedores prov = new Proveedores();
            prov.TopLevel = false;
            contenidoForms.Controls.Add(prov);
            prov.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            prov.Dock = DockStyle.Fill;
            prov.Show();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
            AsignarTrabajos asignarTrabajos = new AsignarTrabajos();
            asignarTrabajos.TopLevel = false;
            contenidoForms.Controls.Add(asignarTrabajos);
            asignarTrabajos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            asignarTrabajos.Dock = DockStyle.Fill;
            asignarTrabajos.Show();
        }

        private void btn_ConsultarCot_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
            OperacionesUsuarios gestionTecnicos = new OperacionesUsuarios();
            gestionTecnicos.TopLevel = false;
            contenidoForms.Controls.Add(gestionTecnicos);
            gestionTecnicos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gestionTecnicos.Dock = DockStyle.Fill;
            gestionTecnicos.Show();
        }


        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            Correos correo = new Correos();
            correo.TopLevel = false;
            contenidoForms.Controls.Add(correo);
            correo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            correo.Dock = DockStyle.Fill;
            correo.Show();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                //this.Size = new Size(420, 200);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
            
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
        }

        private void topHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contenidoForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ocultarInstruccion()
        {
            tituloPrincipal.Hide();
            descripcionPrincipal.Hide();
        }

        private void cambioPantalla(string texto)
        {
            contenidoForms.Controls.Clear();
            TituloOpcion.Text = texto;
        }

        private void ajustaBarra()
        {
            if (barraLateral.Width < 270)
            {
                barraLateral.Width = 270;
                logoAnimation.ShowSync(logo);
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            ocultarInstruccion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
