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
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace ERP_ServicioElPendulo
{
    public partial class form_Login : MaterialForm
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);

        #region Validar_Cierre_Formulario

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Cerrar() == false)
            {
                e.Cancel = true;
            } else
            {
                e.Cancel = false;
            }
        }
        public static bool Cerrar()
        {
            const string mensaje = "¿Seguro que deseas salir?";
            const string cabecera = "Confirmacion de cierre";

            var resultado = MessageBox.Show(mensaje, cabecera, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //Application.Exit();
                return true;
            }
            else
            {
                return false;
            }
        }
        
        #endregion 
        
        public form_Login()
        {
            InitializeComponent();
            MaterialSkinManager sm = MaterialSkinManager.Instance;
            sm.AddFormToManage(this);
            sm.Theme = MaterialSkinManager.Themes.DARK;
            sm.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
            this.AcceptButton = btn_Login;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("SELECT * FROM Usuario WHERE Nombre = '{0}' AND Password = '{1}'", input_Usuario.Text.Trim(),
                input_Password.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);
                string cuenta = ds.Tables[0].Rows[0]["Nombre"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["Password"].ToString().Trim();
                //string tipoU = ds.Tables[0].Rows[0]["TipoUsuario"].ToString().Trim();
                /*
                if (input_Usuario.Text == cuenta)
                {
                    MessageBox.Show("Ese Usuario ya existe, seleccione otro nombre de usuario...", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                */
                if(cuenta == input_Usuario.Text.Trim())
                {
                    if(contra == input_Password.Text.Trim())
                    {
                        PantallaPrincipal mainScreen = new PantallaPrincipal();
                        MessageBox.Show("Bienvenido "+cuenta,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        mainScreen.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto", "Error",MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión, puede que la contraseña o el usuario no esten correctos, o el usuario no exista", "Atencion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void form_Login_Load(object sender, EventArgs e)
        {
 
        }

        private void link_Registrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_UsrSistema registrar = new form_UsrSistema();
            registrar.Show();
            Hide();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
