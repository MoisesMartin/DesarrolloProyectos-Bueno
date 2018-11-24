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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_GenerarPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_porFecha = new System.Windows.Forms.RadioButton();
            this.buscarPContacto = new System.Windows.Forms.ComboBox();
            this.contactosInnovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosInnova = new ERP_ServicioElPendulo.contactosInnova();
            this.date_buscarPorFecha = new System.Windows.Forms.DateTimePicker();
            this.rd_buscarPorContacto = new System.Windows.Forms.RadioButton();
            this.rd_BuscarTodo = new System.Windows.Forms.RadioButton();
            this.btn_Filtrar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosInnovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosInnova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_SolicitudesR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudServicioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Solicitudes de Servicio Registradas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(546, 499);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(114, 23);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Volver";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_GenerarPDF
            // 
            this.btn_GenerarPDF.Location = new System.Drawing.Point(703, 499);
            this.btn_GenerarPDF.Name = "btn_GenerarPDF";
            this.btn_GenerarPDF.Size = new System.Drawing.Size(114, 23);
            this.btn_GenerarPDF.TabIndex = 13;
            this.btn_GenerarPDF.Text = "Generar PDF";
            this.btn_GenerarPDF.UseVisualStyleBackColor = true;
            this.btn_GenerarPDF.Click += new System.EventHandler(this.btn_GenerarPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Criterios de Filtrado:";
            // 
            // rd_porFecha
            // 
            this.rd_porFecha.AutoSize = true;
            this.rd_porFecha.Location = new System.Drawing.Point(191, 98);
            this.rd_porFecha.Name = "rd_porFecha";
            this.rd_porFecha.Size = new System.Drawing.Size(55, 17);
            this.rd_porFecha.TabIndex = 18;
            this.rd_porFecha.TabStop = true;
            this.rd_porFecha.Text = "Fecha";
            this.rd_porFecha.UseVisualStyleBackColor = true;
            this.rd_porFecha.CheckedChanged += new System.EventHandler(this.rd_porFecha_CheckedChanged);
            // 
            // buscarPContacto
            // 
            this.buscarPContacto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.buscarPContacto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.buscarPContacto.FormattingEnabled = true;
            this.buscarPContacto.Items.AddRange(new object[] {
            "Abigail Castillo",
            "Mariell Ugalde",
            "Paola Ocampo",
            "Sergio Marines"});
            this.buscarPContacto.Location = new System.Drawing.Point(27, 121);
            this.buscarPContacto.Name = "buscarPContacto";
            this.buscarPContacto.Size = new System.Drawing.Size(121, 21);
            this.buscarPContacto.Sorted = true;
            this.buscarPContacto.TabIndex = 19;
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
            // date_buscarPorFecha
            // 
            this.date_buscarPorFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_buscarPorFecha.Location = new System.Drawing.Point(191, 122);
            this.date_buscarPorFecha.Name = "date_buscarPorFecha";
            this.date_buscarPorFecha.Size = new System.Drawing.Size(137, 20);
            this.date_buscarPorFecha.TabIndex = 22;
            // 
            // rd_buscarPorContacto
            // 
            this.rd_buscarPorContacto.AutoSize = true;
            this.rd_buscarPorContacto.Checked = true;
            this.rd_buscarPorContacto.Location = new System.Drawing.Point(27, 98);
            this.rd_buscarPorContacto.Name = "rd_buscarPorContacto";
            this.rd_buscarPorContacto.Size = new System.Drawing.Size(68, 17);
            this.rd_buscarPorContacto.TabIndex = 23;
            this.rd_buscarPorContacto.TabStop = true;
            this.rd_buscarPorContacto.Text = "Contacto";
            this.rd_buscarPorContacto.UseVisualStyleBackColor = true;
            this.rd_buscarPorContacto.CheckedChanged += new System.EventHandler(this.rd_buscarPorContacto_CheckedChanged);
            // 
            // rd_BuscarTodo
            // 
            this.rd_BuscarTodo.AutoSize = true;
            this.rd_BuscarTodo.Location = new System.Drawing.Point(359, 98);
            this.rd_BuscarTodo.Name = "rd_BuscarTodo";
            this.rd_BuscarTodo.Size = new System.Drawing.Size(84, 17);
            this.rd_BuscarTodo.TabIndex = 24;
            this.rd_BuscarTodo.Text = "Mostrar todo";
            this.rd_BuscarTodo.UseVisualStyleBackColor = true;
            this.rd_BuscarTodo.CheckedChanged += new System.EventHandler(this.rd_BuscarTodo_CheckedChanged);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(703, 123);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(114, 23);
            this.btn_Filtrar.TabIndex = 25;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // ayuda_Filtrar
            // 
            this.ayuda_Filtrar.AutoSize = true;
            this.ayuda_Filtrar.Location = new System.Drawing.Point(129, 62);
            this.ayuda_Filtrar.Name = "ayuda_Filtrar";
            this.ayuda_Filtrar.Size = new System.Drawing.Size(37, 13);
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
            this.dt_SolicitudesR.AutoGenerateColumns = false;
            this.dt_SolicitudesR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_SolicitudesR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSolicitudDataGridViewTextBoxColumn,
            this.contactoSolicitanteDataGridViewTextBoxColumn,
            this.tipoServicioDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.descripcionProblemaDataGridViewTextBoxColumn,
            this.fechaCapturaDataGridViewTextBoxColumn});
            this.dt_SolicitudesR.DataSource = this.solicitudServicioBindingSource1;
            this.dt_SolicitudesR.Location = new System.Drawing.Point(27, 173);
            this.dt_SolicitudesR.Name = "dt_SolicitudesR";
            this.dt_SolicitudesR.ReadOnly = true;
            this.dt_SolicitudesR.Size = new System.Drawing.Size(790, 270);
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
            this.descripcionProblemaDataGridViewTextBoxColumn.Width = 250;
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
            this.cantColumnas.AutoSize = true;
            this.cantColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantColumnas.Location = new System.Drawing.Point(187, 455);
            this.cantColumnas.Name = "cantColumnas";
            this.cantColumnas.Size = new System.Drawing.Size(20, 24);
            this.cantColumnas.TabIndex = 45;
            this.cantColumnas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Total de Columnas:";
            // 
            // ConsultaSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(831, 534);
            this.Controls.Add(this.cantColumnas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_SolicitudesR);
            this.Controls.Add(this.ayuda_Filtrar);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.rd_BuscarTodo);
            this.Controls.Add(this.rd_buscarPorContacto);
            this.Controls.Add(this.date_buscarPorFecha);
            this.Controls.Add(this.buscarPContacto);
            this.Controls.Add(this.rd_porFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_GenerarPDF);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultaSolicitudes";
            this.Text = "ConsultaSolicitudes";
            this.Load += new System.EventHandler(this.ConsultaSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_GenerarPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_porFecha;
        private System.Windows.Forms.ComboBox buscarPContacto;
        private System.Windows.Forms.DateTimePicker date_buscarPorFecha;
        private System.Windows.Forms.RadioButton rd_buscarPorContacto;
        private System.Windows.Forms.RadioButton rd_BuscarTodo;
        private System.Windows.Forms.Button btn_Filtrar;
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
    }
}