namespace ERP_ServicioElPendulo
{
    partial class SolicitudServicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudServicio));
            this.label1 = new System.Windows.Forms.Label();
            this.list_ContactoSolicitante = new System.Windows.Forms.ComboBox();
            this.contactosInnovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ContactosSolicitud = new ERP_ServicioElPendulo.ds_ContactosSolicitud();
            this.list_TipoServicio = new System.Windows.Forms.ComboBox();
            this.list_Sucursal = new System.Windows.Forms.ComboBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.link_help = new System.Windows.Forms.LinkLabel();
            this.contactosInnovaTableAdapter = new ERP_ServicioElPendulo.ds_ContactosSolicitudTableAdapters.ContactosInnovaTableAdapter();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Cancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Aceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fecha_Solicitud = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.contactosInnovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ContactosSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // list_ContactoSolicitante
            // 
            resources.ApplyResources(this.list_ContactoSolicitante, "list_ContactoSolicitante");
            this.list_ContactoSolicitante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.list_ContactoSolicitante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.list_ContactoSolicitante.FormattingEnabled = true;
            this.list_ContactoSolicitante.Items.AddRange(new object[] {
            resources.GetString("list_ContactoSolicitante.Items"),
            resources.GetString("list_ContactoSolicitante.Items1"),
            resources.GetString("list_ContactoSolicitante.Items2"),
            resources.GetString("list_ContactoSolicitante.Items3")});
            this.list_ContactoSolicitante.Name = "list_ContactoSolicitante";
            // 
            // contactosInnovaBindingSource
            // 
            this.contactosInnovaBindingSource.DataMember = "ContactosInnova";
            this.contactosInnovaBindingSource.DataSource = this.ds_ContactosSolicitud;
            // 
            // ds_ContactosSolicitud
            // 
            this.ds_ContactosSolicitud.DataSetName = "ds_ContactosSolicitud";
            this.ds_ContactosSolicitud.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_TipoServicio
            // 
            resources.ApplyResources(this.list_TipoServicio, "list_TipoServicio");
            this.list_TipoServicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.list_TipoServicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.list_TipoServicio.FormattingEnabled = true;
            this.list_TipoServicio.Items.AddRange(new object[] {
            resources.GetString("list_TipoServicio.Items"),
            resources.GetString("list_TipoServicio.Items1")});
            this.list_TipoServicio.Name = "list_TipoServicio";
            // 
            // list_Sucursal
            // 
            resources.ApplyResources(this.list_Sucursal, "list_Sucursal");
            this.list_Sucursal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.list_Sucursal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.list_Sucursal.FormattingEnabled = true;
            this.list_Sucursal.Items.AddRange(new object[] {
            resources.GetString("list_Sucursal.Items"),
            resources.GetString("list_Sucursal.Items1"),
            resources.GetString("list_Sucursal.Items2"),
            resources.GetString("list_Sucursal.Items3"),
            resources.GetString("list_Sucursal.Items4"),
            resources.GetString("list_Sucursal.Items5"),
            resources.GetString("list_Sucursal.Items6"),
            resources.GetString("list_Sucursal.Items7"),
            resources.GetString("list_Sucursal.Items8"),
            resources.GetString("list_Sucursal.Items9")});
            this.list_Sucursal.Name = "list_Sucursal";
            // 
            // textBox_Descripcion
            // 
            resources.ApplyResources(this.textBox_Descripcion, "textBox_Descripcion");
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            // 
            // link_help
            // 
            resources.ApplyResources(this.link_help, "link_help");
            this.link_help.Name = "link_help";
            this.link_help.TabStop = true;
            this.link_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_help_LinkClicked);
            // 
            // contactosInnovaTableAdapter
            // 
            this.contactosInnovaTableAdapter.ClearBeforeFill = true;
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
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.Depth = 0;
            this.btn_Cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Primary = true;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
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
            // fecha_Solicitud
            // 
            resources.ApplyResources(this.fecha_Solicitud, "fecha_Solicitud");
            this.fecha_Solicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.fecha_Solicitud.BorderRadius = 0;
            this.fecha_Solicitud.ForeColor = System.Drawing.Color.White;
            this.fecha_Solicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_Solicitud.FormatCustom = null;
            this.fecha_Solicitud.Name = "fecha_Solicitud";
            this.fecha_Solicitud.Value = new System.DateTime(2018, 11, 19, 18, 46, 43, 655);
            // 
            // SolicitudServicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fecha_Solicitud);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.link_help);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.list_Sucursal);
            this.Controls.Add(this.list_TipoServicio);
            this.Controls.Add(this.list_ContactoSolicitante);
            this.Controls.Add(this.label1);
            this.Name = "SolicitudServicio";
            this.Load += new System.EventHandler(this.SolicitudServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactosInnovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ContactosSolicitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox list_ContactoSolicitante;
        private System.Windows.Forms.ComboBox list_TipoServicio;
        private System.Windows.Forms.ComboBox list_Sucursal;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.LinkLabel link_help;
        private ds_ContactosSolicitud ds_ContactosSolicitud;
        private System.Windows.Forms.BindingSource contactosInnovaBindingSource;
        private ds_ContactosSolicitudTableAdapters.ContactosInnovaTableAdapter contactosInnovaTableAdapter;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Cancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Aceptar;
        private Bunifu.Framework.UI.BunifuDatepicker fecha_Solicitud;
    }
}