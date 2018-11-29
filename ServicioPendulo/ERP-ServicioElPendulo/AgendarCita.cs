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
    public partial class AgendarCita : Form
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);

        #region Cierre Formulario

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

        public AgendarCita()
        {
            InitializeComponent();
            //MaterialSkinManager sm = MaterialSkinManager.Instance;
            //sm.AddFormToManage(this);
            //sm.Theme = MaterialSkinManager.Themes.DARK;
            //sm.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
            this.AcceptButton = btn_Aceptar;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal mainScreen = new PantallaPrincipal();
            mainScreen.Show();
            Hide();
        }
        public bool validaciones()
        {
            bool validacionCorrecta = false;
            bool fechaCorrecta = false;
            bool tiendaLlenada = false;
            bool personaAtiende = false;
            //Validar fecha Correcta
            if ((fechaAgendacion.Value.CompareTo(fechaProgramada.Value) < 1))
            {
                fechaCorrecta = true;
            }
            else
            {
                fechaCorrecta = false;
            }
            //Validar tienda
            if (String.IsNullOrEmpty(list_Sucursales.Text))
            {
                tiendaLlenada = false;
                MessageBox.Show("No se ha elegido una sucursal");
            }
            else
            {
                tiendaLlenada = true;
                
            }
            //personaAtiende
            if (String.IsNullOrEmpty(txt_PersonaAtiende.Text))
            {
                personaAtiende = false;
                MessageBox.Show("No se indico que persona atendió la solicitud");
            }
            else
            {
                personaAtiende = true;
            }
            if(fechaCorrecta== true && tiendaLlenada== true && personaAtiende==true)
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
                Hide();
                PantallaPrincipal mainScreen = new PantallaPrincipal();
                agendarCita();
                mainScreen.Show();
            }
            else
            {
                MessageBox.Show("Errores de validacion de datos", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            } 
        }
        public void agendarCita()
        {
            string sucursalCita = list_Sucursales.Text;
            string FechaAgendada = fechaAgendacion.Value.ToString("dd/MM/yyyy");
            string FechaCita = fechaProgramada.Value.ToString("dd/MM/yyyy");
            string HoraCita = horaCita.Value.ToString("hh:mm tt");
            string Atendio = txt_PersonaAtiende.Text;
            string EstatusCita = "";
            if(radio_Agendado.Checked == true)
            {
                EstatusCita = "Agendado";
            }
            if(radio_EnProceso.Checked == true)
            {
                EstatusCita = "Pendiente";
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CitasAgendadas (Sucursal,FechaAgendacion,FechaCita,HoraCita,PersonaQueAtendio,EstatusCita)"
                + "VALUES(@sucu,@fAgendacion,@fCita,@HrCita,@pAtendio,@estCita)";
            //
            cmd.Parameters.Add(new SqlParameter("@sucu", sucursalCita));
            cmd.Parameters.Add(new SqlParameter("@fAgendacion", FechaAgendada));
            cmd.Parameters.Add(new SqlParameter("@fCita", FechaCita));
            cmd.Parameters.Add(new SqlParameter("@HrCita", HoraCita));
            cmd.Parameters.Add(new SqlParameter("@pAtendio", Atendio));
            cmd.Parameters.Add(new SqlParameter("@estCita", EstatusCita));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cita registrada, puede administrarla en el apartado de CONSULTAR CITAS", "Exito!");
            con.Close();
        }
        private void link_Fecha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para colocar la hora, minuto segundo, selecciona dicho parametro en el campo, seguido de : para cambiar a minutos segundos y para cambiar de AM a PM escribe a o p","Formato de Fecha");
        }

        private void AgendarCita_Load(object sender, EventArgs e)
        {
            materialLabel1.ForeColor = System.Drawing.Color.White;
            materialLabel2.ForeColor = System.Drawing.Color.White;
            materialLabel3.ForeColor = System.Drawing.Color.White;
            materialLabel4.ForeColor = System.Drawing.Color.White;
            materialLabel5.ForeColor = System.Drawing.Color.White;
            materialLabel6.ForeColor = System.Drawing.Color.White;
            materialLabel7.ForeColor = System.Drawing.Color.White;
            materialLabel8.ForeColor = System.Drawing.Color.White;
        }

        private void list_Sucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
