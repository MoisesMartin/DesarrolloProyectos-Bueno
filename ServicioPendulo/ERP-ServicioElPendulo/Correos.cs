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
    public partial class Correos : Form
    {
        public Correos()
        {
            InitializeComponent();
        }

        private void btn_CancelarCorreo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estas seguro de cancelar el correo?","Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            Hide();
        }
    }
}
