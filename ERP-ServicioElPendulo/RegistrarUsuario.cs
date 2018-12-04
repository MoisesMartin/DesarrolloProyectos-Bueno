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

namespace ERP_ServicioElPendulo
{
    public partial class OperacionesUsuarios : Form
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
        public OperacionesUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void OperacionesUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'servicioElPenduloDataSet7.Tecnicos' Puede moverla o quitarla según sea necesario.
            this.tecnicosTableAdapter.Fill(this.servicioElPenduloDataSet7.Tecnicos);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Registrar_Click_1(object sender, EventArgs e)
        {
            string clave = txt_claveT.Text;
            string nombres = txt_Nombre.Text;
            string apaterno = txt_APaterno.Text;
            string amaterno = txt_AMaterno.Text;
            string sexo = "";
            string email = txt_Email.Text;
            string Telefono = txt_Telefono.Text;
            if(rd_Masc.Checked == true)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Femenino";
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Tecnicos (ID_Tecnico,Nombres, ApellidoPaterno, ApellidoMaterno, Sexo, Email, Telefono)"
                +"VALUES(@A,@B,@C,@D,@E,@F,@G)";
            cmd.Parameters.Add(new SqlParameter("@A", clave));
            cmd.Parameters.Add(new SqlParameter("@B", nombres));
            cmd.Parameters.Add(new SqlParameter("@C", apaterno));
            cmd.Parameters.Add(new SqlParameter("@D", amaterno));
            cmd.Parameters.Add(new SqlParameter("@E", sexo));
            cmd.Parameters.Add(new SqlParameter("@F", email));
            cmd.Parameters.Add(new SqlParameter("@G", Telefono));
            cmd.ExecuteNonQuery();
            con.Close();
            txt_claveT.Text = "";
            txt_Nombre.Text = "";
            txt_APaterno.Text = "";
            txt_AMaterno.Text = "";
            txt_Email.Text = "";
            txt_Telefono.Text = "";
            MessageBox.Show("Registrado");
            //
            actualizar();
        }

        private void tablaTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            borrar();
        }
        public void borrar()
        {
            string nombreEliminar = txt_NombreTecnico.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Tecnicos WHERE Nombres=@DeleteName";
            cmd.Parameters.Add(new SqlParameter("@DeleteName", nombreEliminar));
            cmd.ExecuteNonQuery();
            
            //Quitando el datasource
            tablaTec.DataSource = null;
            tablaTec.Update();
            tablaTec.Refresh();
            //Reasignando el datasource para actualizar
            SqlCommand cmd_update = con.CreateCommand();
            cmd_update.CommandType = CommandType.Text;
            cmd_update.CommandText = "SELECT * FROM Tecnicos";
            SqlDataAdapter da = new SqlDataAdapter(cmd_update);
            DataTable tecnicos = new DataTable();
            da.Fill(tecnicos);
            tablaTec.DataSource = tecnicos;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }
        public void actualizar()
        {
            tablaTec.DataSource = null;
            tablaTec.Update();
            tablaTec.Refresh();
            con.Open();
            SqlCommand cmd_update = con.CreateCommand();
            cmd_update.CommandType = CommandType.Text;
            cmd_update.CommandText = "SELECT * FROM Tecnicos";
            SqlDataAdapter da = new SqlDataAdapter(cmd_update);
            DataTable act = new DataTable();
            da.Fill(act);
            tablaTec.DataSource = act;
            con.Close();
        }
        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaterno_Click(object sender, EventArgs e)
        {

        }



        private void ck_Edicion_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Edicion.Checked == true)
            {
                txt_showClave.Enabled = false;
                txt_NombreTecnico.Enabled = true;
                textBox1.Enabled = true;
                txt_Materno.Enabled = true;
                txt_Correo.Enabled = true;
                txt_TelefonoC.Enabled = true;
                btn_Eliminar.Enabled = false;
                btn_ActualizarI.Enabled = true;
            }
            else
            {
                txt_showClave.Enabled = false;
                txt_NombreTecnico.Enabled = false;
                textBox1.Enabled = false;
                txt_Materno.Enabled = false;
                txt_Correo.Enabled = false;
                txt_TelefonoC.Enabled = false;
                btn_Eliminar.Enabled = true;
                btn_ActualizarI.Enabled = false;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_ActualizarI_Click(object sender, EventArgs e)
        {
            string id = txt_showClave.Text;
            string nnombres = txt_NombreTecnico.Text;
            string napaterno = textBox1.Text;
            string namaterno = txt_Materno.Text;
            string nemail = txt_Correo.Text;
            string nTelefono = txt_TelefonoC.Text;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                MessageBox.Show("Actualizado","Hecho");
                 cmd.CommandText = "UPDATE Tecnicos SET Nombres = @NewNames, ApellidoPaterno = @NewAP, ApellidoMaterno = @NewAM" +
                     ", Email = @NewEmail, Telefono = @NewTelf WHERE ID_Tecnico =@ID";
                 cmd.Parameters.Add(new SqlParameter("@ID", id));
                 cmd.Parameters.Add(new SqlParameter("@NewNames", nnombres));
                 cmd.Parameters.Add(new SqlParameter("@NewAP", napaterno));
                 cmd.Parameters.Add(new SqlParameter("@NewAM", namaterno));
                 cmd.Parameters.Add(new SqlParameter("@NewEmail", nemail));
                 cmd.Parameters.Add(new SqlParameter("@NewTelf", nTelefono));
                 cmd.ExecuteNonQuery();
                con.Close();
                actualizar();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "ErrorSQL");
            }
        }

        private void tablaTec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var clave_tecnico = tablaTec.Rows[e.RowIndex].Cells[0].Value;
                txt_showClave.Text = clave_tecnico.ToString();
                //
                var nombreTecnico = tablaTec.Rows[e.RowIndex].Cells[1].Value;
                txt_NombreTecnico.Text = nombreTecnico.ToString();
                //
                var apellidoP = tablaTec.Rows[e.RowIndex].Cells[2].Value;
                textBox1.Text = apellidoP.ToString();
                //
                var apellidoM = tablaTec.Rows[e.RowIndex].Cells[3].Value;
                txt_Materno.Text = apellidoM.ToString();
                //
                var email = tablaTec.Rows[e.RowIndex].Cells[5].Value;
                txt_Correo.Text = email.ToString();
                //
                var telf = tablaTec.Rows[e.RowIndex].Cells[6].Value;
                txt_TelefonoC.Text = telf.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación inválida", "Operación Imposible " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
