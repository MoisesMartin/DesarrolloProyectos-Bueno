namespace ERP_ServicioElPendulo
{
    partial class ConsultaSolicitudes
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
            this.buscarPContacto = new System.Windows.Forms.ComboBox();
            this.contactosInnovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosInnova = new ERP_ServicioElPendulo.contactosInnova();
            this.ayuda_Filtrar = new System.Windows.Forms.LinkLabel();
            this.servicioElPenduloDataSet = new ERP_ServicioElPendulo.servicioElPenduloDataSet();
            this.solicitudServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudServicioTableAdapter = new ERP_ServicioElPendulo.servicioElPenduloDataSetTableAdapters.solicitudServicioTableAdapter();
            this.dt_SolicitudesR = new System.Windows.Forms.DataGridView();
            this.iDSolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoSolicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProblemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCapturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitudServicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicioElPenduloDataSet1 = new ERP_ServicioElPendulo.servicioElPenduloDataSet1();
            this.contactosInnovaTableAdapter = new ERP_ServicioElPendulo.contactosInnovaTableAdapters.ContactosInnovaTableAdapter();
            this.solicitudServicioTableAdapter1 = new ERP_ServicioElPendulo.servicioElPenduloDataSet1TableAdapters.solicitudServicioTableAdapter();
            this.cantColumnas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rd_buscarPorContacto = new MaterialSkin.Controls.MaterialRadioButton();
            this.rd_porFecha = new MaterialSkin.Controls.MaterialRadioButton();
            this.rd_BuscarTodo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_GenerarPDF = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Filtrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.date_buscarPorFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.contactosInnovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosInnova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_SolicitudesR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudServicioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarPContacto
            // 
            this.buscarPContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buscarPContacto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.buscarPContacto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.buscarPContacto.FormattingEnabled = true;
            this.buscarPContacto.Items.AddRange(new object[] {
            "Abigail Castillo",
            "Mariell Ugalde",
            "Paola Ocampo",
            "Sergio Marines"});
            this.buscarPContacto.Location = new System.Drawing.Point(136, 167);
            this.buscarPContacto.Name = "buscarPContacto";
            this.buscarPContacto.Size = new System.Drawing.Size(184, 21);
            this.buscarPContacto.Sorted = true;
            this.buscarPContacto.TabIndex = 19;
            this.buscarPContacto.Text = "Abigail Castillo";
            // 
            // contactosInnovaBindingSource
            // 
            this.contactosInnovaBindingSource.DataMember = "ContactosInnova";
            this.contactosInnovaBindingSource.DataSource = this.contactosInnova;
            // 
            // contactosInnova
            // 
            this.contactosInnova.DataSetName = "contactosInnova";
            this.contactosInnova.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ayuda_Filtrar
            // 
            this.ayuda_Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ayuda_Filtrar.AutoSize = true;
            this.ayuda_Filtrar.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.ayuda_Filtrar.Location = new System.Drawing.Point(213, 89);
            this.ayuda_Filtrar.Name = "ayuda_Filtrar";
            this.ayuda_Filtrar.Size = new System.Drawing.Size(48, 19);
            this.ayuda_Filtrar.TabIndex = 26;
            this.ayuda_Filtrar.TabStop = true;
            this.ayuda_Filtrar.Text = "Ayuda";
            this.ayuda_Filtrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ayuda_Filtrar_LinkClicked);
            // 
            // servicioElPenduloDataSet
            // 
            this.servicioElPenduloDataSet.DataSetName = "servicioElPenduloDataSet";
            this.servicioElPenduloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudServicioBindingSource
            // 
            this.solicitudServicioBindingSource.DataMember = "solicitudServicio";
            this.solicitudServicioBindingSource.DataSource = this.servicioElPenduloDataSet;
            // 
            // solicitudServicioTableAdapter
            // 
            this.solicitudServicioTableAdapter.ClearBeforeFill = true;
            // 
            // dt_SolicitudesR
            // 
            this.dt_SolicitudesR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_SolicitudesR.AutoGenerateColumns = false;
            this.dt_SolicitudesR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_SolicitudesR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_SolicitudesR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSolicitudDataGridViewTextBoxColumn,
            this.contactoSolicitanteDataGridViewTextBoxColumn,
            this.tipoServicioDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.descripcionProblemaDataGridViewTextBoxColumn,
            this.fechaCapturaDataGridViewTextBoxColumn});
            this.dt_SolicitudesR.DataSource = this.solicitudServicioBindingSource1;
            this.dt_SolicitudesR.Location = new System.Drawing.Point(29, 199);
            this.dt_SolicitudesR.Name = "dt_SolicitudesR";
            this.dt_SolicitudesR.ReadOnly = true;
            this.dt_SolicitudesR.Size = new System.Drawing.Size(693, 276);
            this.dt_SolicitudesR.TabIndex = 27;
            this.dt_SolicitudesR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_SolicitudesR_CellContentClick);
            // 
            // iDSolicitudDataGridViewTextBoxColumn
            // 
            this.iDSolicitudDataGridViewTextBoxColumn.DataPropertyName = "ID_Solicitud";
            this.iDSolicitudDataGridViewTextBoxColumn.HeaderText = "ID_Solicitud";
            this.iDSolicitudDataGridViewTextBoxColumn.Name = "iDSolicitudDataGridViewTextBoxColumn";
            this.iDSolicitudDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoSolicitanteDataGridViewTextBoxColumn
            // 
            this.contactoSolicitanteDataGridViewTextBoxColumn.DataPropertyName = "ContactoSolicitante";
            this.contactoSolicitanteDataGridViewTextBoxColumn.HeaderText = "ContactoSolicitante";
            this.contactoSolicitanteDataGridViewTextBoxColumn.Name = "contactoSolicitanteDataGridViewTextBoxColumn";
            this.contactoSolicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoServicioDataGridViewTextBoxColumn
            // 
            this.tipoServicioDataGridViewTextBoxColumn.DataPropertyName = "TipoServicio";
            this.tipoServicioDataGridViewTextBoxColumn.HeaderText = "TipoServicio";
            this.tipoServicioDataGridViewTextBoxColumn.Name = "tipoServicioDataGridViewTextBoxColumn";
            this.tipoServicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionProblemaDataGridViewTextBoxColumn
            // 
            this.descripcionProblemaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionProblema";
            this.descripcionProblemaDataGridViewTextBoxColumn.HeaderText = "DescripcionProblema";
            this.descripcionProblemaDataGridViewTextBoxColumn.Name = "descripcionProblemaDataGridViewTextBoxColumn";
            this.descripcionProblemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCapturaDataGridViewTextBoxColumn
            // 
            this.fechaCapturaDataGridViewTextBoxColumn.DataPropertyName = "FechaCaptura";
            this.fechaCapturaDataGridViewTextBoxColumn.HeaderText = "FechaCaptura";
            this.fechaCapturaDataGridViewTextBoxColumn.Name = "fechaCapturaDataGridViewTextBoxColumn";
            this.fechaCapturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solicitudServicioBindingSource1
            // 
            this.solicitudServicioBindingSource1.DataMember = "solicitudServicio";
            this.solicitudServicioBindingSource1.DataSource = this.servicioElPenduloDataSet1;
            // 
            // servicioElPenduloDataSet1
            // 
            this.servicioElPenduloDataSet1.DataSetName = "servicioElPenduloDataSet1";
            this.servicioElPenduloDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosInnovaTableAdapter
            // 
            this.contactosInnovaTableAdapter.ClearBeforeFill = true;
            // 
            // solicitudServicioTableAdapter1
            // 
            this.solicitudServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // cantColumnas
            // 
            this.cantColumnas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cantColumnas.AutoSize = true;
            this.cantColumnas.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantColumnas.Location = new System.Drawing.Point(172, 503);
            this.cantColumnas.Name = "cantColumnas";
            this.cantColumnas.Size = new System.Drawing.Size(23, 25);
            this.cantColumnas.TabIndex = 45;
            this.cantColumnas.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Total de Columnas:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 19);
            this.materialLabel1.TabIndex = 46;
            this.materialLabel1.Text = "Criterios de Filtrado:";
            // 
            // rd_buscarPorContacto
            // 
            this.rd_buscarPorContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_buscarPorContacto.AutoSize = true;
            this.rd_buscarPorContacto.Depth = 0;
            this.rd_buscarPorContacto.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_buscarPorContacto.Location = new System.Drawing.Point(29, 162);
            this.rd_buscarPorContacto.Margin = new System.Windows.Forms.Padding(0);
            this.rd_buscarPorContacto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_buscarPorContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_buscarPorContacto.Name = "rd_buscarPorContacto";
            this.rd_buscarPorContacto.Ripple = true;
            this.rd_buscarPorContacto.Size = new System.Drawing.Size(25, 30);
            this.rd_buscarPorContacto.TabIndex = 47;
            this.rd_buscarPorContacto.UseVisualStyleBackColor = true;
            // 
            // rd_porFecha
            // 
            this.rd_porFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rd_porFecha.AutoSize = true;
            this.rd_porFecha.Depth = 0;
            this.rd_porFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_porFecha.Location = new System.Drawing.Point(29, 121);
            this.rd_porFecha.Margin = new System.Windows.Forms.Padding(0);
            this.rd_porFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_porFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_porFecha.Name = "rd_porFecha";
            this.rd_porFecha.Ripple = true;
            this.rd_porFecha.Size = new System.Drawing.Size(25, 30);
            this.rd_porFecha.TabIndex = 48;
            this.rd_porFecha.UseVisualStyleBackColor = true;
            // 
            // rd_BuscarTodo
            // 
            this.rd_BuscarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rd_BuscarTodo.AutoSize = true;
            this.rd_BuscarTodo.Checked = true;
            this.rd_BuscarTodo.Depth = 0;
            this.rd_BuscarTodo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_BuscarTodo.Location = new System.Drawing.Point(615, 78);
            this.rd_BuscarTodo.Margin = new System.Windows.Forms.Padding(0);
            this.rd_BuscarTodo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_BuscarTodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_BuscarTodo.Name = "rd_BuscarTodo";
            this.rd_BuscarTodo.Ripple = true;
            this.rd_BuscarTodo.Size = new System.Drawing.Size(25, 30);
            this.rd_BuscarTodo.TabIndex = 49;
            this.rd_BuscarTodo.TabStop = true;
            this.rd_BuscarTodo.UseVisualStyleBackColor = true;
            // 
            // btn_GenerarPDF
            // 
            this.btn_GenerarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GenerarPDF.Depth = 0;
            this.btn_GenerarPDF.Location = new System.Drawing.Point(605, 489);
            this.btn_GenerarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_GenerarPDF.Name = "btn_GenerarPDF";
            this.btn_GenerarPDF.Primary = true;
            this.btn_GenerarPDF.Size = new System.Drawing.Size(117, 38);
            this.btn_GenerarPDF.TabIndex = 50;
            this.btn_GenerarPDF.Text = "Generar PDF";
            this.btn_GenerarPDF.UseVisualStyleBackColor = true;
            this.btn_GenerarPDF.Click += new System.EventHandler(this.btn_GenerarPDF_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.Depth = 0;
            this.btn_Back.Location = new System.Drawing.Point(500, 489);
            this.btn_Back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Primary = true;
            this.btn_Back.Size = new System.Drawing.Size(99, 38);
            this.btn_Back.TabIndex = 51;
            this.btn_Back.Text = "Volver";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Filtrar.Depth = 0;
            this.btn_Filtrar.Location = new System.Drawing.Point(625, 114);
            this.btn_Filtrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Primary = true;
            this.btn_Filtrar.Size = new System.Drawing.Size(99, 38);
            this.btn_Filtrar.TabIndex = 52;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(57, 127);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 55;
            this.materialLabel2.Text = "Fecha";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(57, 169);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 56;
            this.materialLabel3.Text = "Contacto";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(643, 85);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(97, 19);
            this.materialLabel4.TabIndex = 57;
            this.materialLabel4.Text = "Mostrar todo";
            // 
            // date_buscarPorFecha
            // 
            this.date_buscarPorFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_buscarPorFecha.Location = new System.Drawing.Point(136, 125);
            this.date_buscarPorFecha.Name = "date_buscarPorFecha";
            this.date_buscarPorFecha.Size = new System.Drawing.Size(184, 20);
            this.date_buscarPorFecha.TabIndex = 59;
            // 
            // ConsultaSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 536);
            this.Controls.Add(this.date_buscarPorFecha);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_GenerarPDF);
            this.Controls.Add(this.rd_BuscarTodo);
            this.Controls.Add(this.rd_porFecha);
            this.Controls.Add(this.rd_buscarPorContacto);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cantColumnas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_SolicitudesR);
            this.Controls.Add(this.ayuda_Filtrar);
            this.Controls.Add(this.buscarPContacto);
            this.Name = "ConsultaSolicitudes";
            this.Text = "Solicitudes de Servicio Registradas";
            this.Load += new System.EventHandler(this.ConsultaSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactosInnovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosInnova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_SolicitudesR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudServicioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox buscarPContacto;
        private System.Windows.Forms.LinkLabel ayuda_Filtrar;
        private servicioElPenduloDataSet servicioElPenduloDataSet;
        private System.Windows.Forms.BindingSource solicitudServicioBindingSource;
        private servicioElPenduloDataSetTableAdapters.solicitudServicioTableAdapter solicitudServicioTableAdapter;
        private System.Windows.Forms.DataGridView dt_SolicitudesR;
        private contactosInnova contactosInnova;
        private System.Windows.Forms.BindingSource contactosInnovaBindingSource;
        private contactosInnovaTableAdapters.ContactosInnovaTableAdapter contactosInnovaTableAdapter;
        private servicioElPenduloDataSet1 servicioElPenduloDataSet1;
        private System.Windows.Forms.BindingSource solicitudServicioBindingSource1;
        private servicioElPenduloDataSet1TableAdapters.solicitudServicioTableAdapter solicitudServicioTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoSolicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProblemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCapturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label cantColumnas;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rd_buscarPorContacto;
        private MaterialSkin.Controls.MaterialRadioButton rd_porFecha;
        private MaterialSkin.Controls.MaterialRadioButton rd_BuscarTodo;
        private MaterialSkin.Controls.MaterialRaisedButton btn_GenerarPDF;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Back;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Filtrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker date_buscarPorFecha;
    }
}