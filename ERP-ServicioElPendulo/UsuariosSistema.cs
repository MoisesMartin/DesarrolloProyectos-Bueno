﻿using System;
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
    public partial class form_UsrSistema : MaterialForm
    {
        public static string conexionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);
        static string codigo;

        #region Validar_Cierre_Formulario

        /*protected override void OnFormClosing(FormClosingEventArgs e)
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
        }*/

        #endregion

        public form_UsrSistema()
        {
            InitializeComponent();
            MaterialSkinManager sm = MaterialSkinManager.Instance;
            sm.AddFormToManage(this);
            sm.Theme = MaterialSkinManager.Themes.DARK;
            sm.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
            this.AcceptButton = btn_Registrar;
        }

        private void btn_CancelarReg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                ConfirmarUPWADM(txtbox_usu.Text, txtbox_pw.Text);

                if (codigo == "ACEPTADO")
                {
                    if (txt_Password.Text == txt_RepeatPass.Text)
                    {
                        insertarUsr();
                        form_Login login = new form_Login();
                        MessageBox.Show("Usuario registrado con éxito.", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas ingresadas no coinciden", "Advertencia", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    }
                }
                
            }
            catch(Exception exp)
            {
                MessageBox.Show("No se tienen las credenciales requeridas", "Advertencia", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
        private void insertarUsr()
        {
            string nombreUsr = txt_NombreUsr.Text;
            string apaterno = txt_ApellidoMaterno.Text;
            string amaterno = txt_ApellidoMaterno.Text;
            string nombreAcc = txt_NombreUsr.Text + txt_ApellidoPaterno.Text;
            string contra = txt_Password.Text;
            string tipoUsr = "";
            if (check_isAdmin.Checked)
            {
                tipoUsr = "A";
            }
            else
            {
                tipoUsr = "U";
            }
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Usuario (Nombre,ApellidoPaterno,ApellidoMaterno,NombreUsuario,Password,TipoUsuario)"
                    + "VALUES(@nombre,@apaterno,@amaterno,@nombreU,@Pass,@tipoU)";
                //
                cmd.Parameters.Add(new SqlParameter("@nombre", nombreUsr));
                cmd.Parameters.Add(new SqlParameter("@apaterno", apaterno));
                cmd.Parameters.Add(new SqlParameter("@amaterno", amaterno));
                cmd.Parameters.Add(new SqlParameter("@nombreU", nombreAcc));
                cmd.Parameters.Add(new SqlParameter("@Pass", contra));
                cmd.Parameters.Add(new SqlParameter("@tipoU", tipoUsr));
                cmd.ExecuteNonQuery();
                con.Close();
                Hide();
            }catch(Exception ex)
            {
                MessageBox.Show("Error de SQL Desconocido, consulte al administrador del sistema","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }

        private void form_UsrSistema_Load(object sender, EventArgs e)
        {

        }

        #region MyRegion

        protected string ConfirmarUPWADM(string user, string pw)
        {
            if (user == "Administrador" && pw == "12345")
            {
                Close();
                codigo = "ACEPTADO";
            }
            else
            {
                MessageBox.Show("No se tienen las credenciales requeridas", "Advertencia", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                txtbox_pw.Text = string.Empty;
                txtbox_usu.Text = string.Empty;
                codigo = "NEGADO";
            }

            return codigo;
        }
           

            
       


    #endregion

    private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Si seleccionas esta opcion, el usuario tendra privilegios de administración");
        }

        private void form_UsrSistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_Login log = new form_Login();
            log.Show();
        }
    }
}
