namespace ERP_ServicioElPendulo
{
    partial class AgendarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarCita));
            this.link_Fecha = new System.Windows.Forms.LinkLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.radio_EnProceso = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio_Agendado = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_Aceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fechaAgendacion = new Bunifu.Framework.UI.BunifuDatepicker();
            this.fechaProgramada = new Bunifu.Framework.UI.BunifuDatepicker();
            this.horaCita = new Bunifu.Framework.UI.BunifuDatepicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.list_Sucursales = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_PersonaAtiende = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // link_Fecha
            // 
            resources.ApplyResources(this.link_Fecha, "link_Fecha");
            this.link_Fecha.LinkColor = System.Drawing.Color.White;
            this.link_Fecha.Name = "link_Fecha";
            this.link_Fecha.TabStop = true;
            this.link_Fecha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Fecha_LinkClicked);
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // radio_EnProceso
            // 
            resources.ApplyResources(this.radio_EnProceso, "radio_EnProceso");
            this.radio_EnProceso.Depth = 0;
            this.radio_EnProceso.ForeColor = System.Drawing.Color.White;
            this.radio_EnProceso.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_EnProceso.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_EnProceso.Name = "radio_EnProceso";
            this.radio_EnProceso.Ripple = true;
            this.radio_EnProceso.UseVisualStyleBackColor = true;
            // 
            // radio_Agendado
            // 
            resources.ApplyResources(this.radio_Agendado, "radio_Agendado");
            this.radio_Agendado.Checked = true;
            this.radio_Agendado.Depth = 0;
            this.radio_Agendado.ForeColor = System.Drawing.Color.White;
            this.radio_Agendado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio_Agendado.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio_Agendado.Name = "radio_Agendado";
            this.radio_Agendado.Ripple = true;
            this.radio_Agendado.TabStop = true;
            this.radio_Agendado.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            resources.ApplyResources(this.btn_Aceptar, "btn_Aceptar");
            this.btn_Aceptar.Depth = 0;
            this.btn_Aceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Primary = true;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // fechaAgendacion
            // 
            resources.ApplyResources(this.fechaAgendacion, "fechaAgendacion");
            this.fechaAgendacion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.fechaAgendacion.BorderRadius = 0;
            this.fechaAgendacion.ForeColor = System.Drawing.Color.White;
            this.fechaAgendacion.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaAgendacion.FormatCustom = null;
            this.fechaAgendacion.Name = "fechaAgendacion";
            this.fechaAgendacion.Value = new System.DateTime(2018, 11, 21, 2, 11, 39, 105);
            // 
            // fechaProgramada
            // 
            resources.ApplyResources(this.fechaProgramada, "fechaProgramada");
            this.fechaProgramada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.fechaProgramada.BorderRadius = 0;
            this.fechaProgramada.ForeColor = System.Drawing.Color.White;
            this.fechaProgramada.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaProgramada.FormatCustom = null;
            this.fechaProgramada.Name = "fechaProgramada";
            this.fechaProgramada.Value = new System.DateTime(2018, 11, 21, 2, 11, 39, 105);
            // 
            // horaCita
            // 
            resources.ApplyResources(this.horaCita, "horaCita");
            this.horaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.horaCita.BorderRadius = 0;
            this.horaCita.ForeColor = System.Drawing.Color.White;
            this.horaCita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaCita.FormatCustom = null;
            this.horaCita.Name = "horaCita";
            this.horaCita.Value = new System.DateTime(2018, 11, 21, 2, 11, 39, 105);
            // 
            // materialLabel7
            // 
            resources.ApplyResources(this.materialLabel7, "materialLabel7");
            this.materialLabel7.Depth = 0;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            // 
            // materialLabel8
            // 
            resources.ApplyResources(this.materialLabel8, "materialLabel8");
            this.materialLabel8.Depth = 0;
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            // 
            // list_Sucursales
            // 
            resources.ApplyResources(this.list_Sucursales, "list_Sucursales");
            this.list_Sucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.list_Sucursales.BorderRadius = 3;
            this.list_Sucursales.DisabledColor = System.Drawing.Color.Gray;
            this.list_Sucursales.ForeColor = System.Drawing.Color.White;
            this.list_Sucursales.Items = new string[] {
        "Coyoacán",
        "Polanco",
        "Zumpango",
        "Cuautitlán Izcalli",
        "Iztapalapa",
        "Azcapotzalco",
        "Nezahuacoyotl",
        "Ecatepec",
        "Tecámac",
        "Las Américas"};
            this.list_Sucursales.Name = "list_Sucursales";
            this.list_Sucursales.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.list_Sucursales.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.list_Sucursales.selectedIndex = -1;
            // 
            // txt_PersonaAtiende
            // 
            resources.ApplyResources(this.txt_PersonaAtiende, "txt_PersonaAtiende");
            this.txt_PersonaAtiende.Depth = 0;
            this.txt_PersonaAtiende.Hint = "Nombre";
            this.txt_PersonaAtiende.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_PersonaAtiende.Name = "txt_PersonaAtiende";
            this.txt_PersonaAtiende.PasswordChar = '\0';
            this.txt_PersonaAtiende.SelectedText = "";
            this.txt_PersonaAtiende.SelectionLength = 0;
            this.txt_PersonaAtiende.SelectionStart = 0;
            this.txt_PersonaAtiende.UseSystemPasswordChar = false;
            // 
            // AgendarCita
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.txt_PersonaAtiende);
            this.Controls.Add(this.list_Sucursales);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.horaCita);
            this.Controls.Add(this.fechaProgramada);
            this.Controls.Add(this.fechaAgendacion);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.radio_Agendado);
            this.Controls.Add(this.radio_EnProceso);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.link_Fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendarCita";
            this.Load += new System.EventHandler(this.AgendarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel link_Fecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton radio_EnProceso;
        private MaterialSkin.Controls.MaterialRadioButton radio_Agendado;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Aceptar;
        private Bunifu.Framework.UI.BunifuDatepicker fechaAgendacion;
        private Bunifu.Framework.UI.BunifuDatepicker fechaProgramada;
        private Bunifu.Framework.UI.BunifuDatepicker horaCita;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private Bunifu.Framework.UI.BunifuDropdown list_Sucursales;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_PersonaAtiende;
    }
}