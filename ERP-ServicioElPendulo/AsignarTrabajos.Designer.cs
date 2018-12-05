namespace ERP_ServicioElPendulo
{
    partial class AsignarTrabajos
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
            this.tecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListaTecnicos = new ERP_ServicioElPendulo.dataSetListaTecnicos();
            this.txt_PQAtendio = new System.Windows.Forms.TextBox();
            this.txt_Sucursal = new System.Windows.Forms.TextBox();
            this.tecnicosTableAdapter = new ERP_ServicioElPendulo.dataSetListaTecnicosTableAdapters.TecnicosTableAdapter();
            this.tablaAsignacion = new System.Windows.Forms.DataGridView();
            this.iDCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAgendacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaQueAtendioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citasAgendadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioElPenduloDataSet8 = new ERP_ServicioElPendulo.servicioElPenduloDataSet8();
            this.citasAgendadasTableAdapter = new ERP_ServicioElPendulo.servicioElPenduloDataSet8TableAdapters.CitasAgendadasTableAdapter();
            this.idTrabajoText = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.list_Tecnicos = new System.Windows.Forms.ComboBox();
            this.tecnicosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tecnicosAsignacion = new ERP_ServicioElPendulo.tecnicosAsignacion();
            this.txt_horaCita = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.servicioElPenduloDataSet9 = new ERP_ServicioElPendulo.servicioElPenduloDataSet9();
            this.tecnicosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tecnicosTableAdapter1 = new ERP_ServicioElPendulo.servicioElPenduloDataSet9TableAdapters.TecnicosTableAdapter();
            this.tecnicosTableAdapter2 = new ERP_ServicioElPendulo.tecnicosAsignacionTableAdapters.TecnicosTableAdapter();
            this.txtIdTecnico = new System.Windows.Forms.TextBox();
            this.list_Estatus = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Asignar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaTecnicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasAgendadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tecnicosBindingSource
            // 
            this.tecnicosBindingSource.DataMember = "Tecnicos";
            this.tecnicosBindingSource.DataSource = this.dataSetListaTecnicos;
            // 
            // dataSetListaTecnicos
            // 
            this.dataSetListaTecnicos.DataSetName = "dataSetListaTecnicos";
            this.dataSetListaTecnicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_PQAtendio
            // 
            this.txt_PQAtendio.Enabled = false;
            this.txt_PQAtendio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PQAtendio.Location = new System.Drawing.Point(15, 317);
            this.txt_PQAtendio.Name = "txt_PQAtendio";
            this.txt_PQAtendio.Size = new System.Drawing.Size(217, 26);
            this.txt_PQAtendio.TabIndex = 37;
            // 
            // txt_Sucursal
            // 
            this.txt_Sucursal.Enabled = false;
            this.txt_Sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sucursal.Location = new System.Drawing.Point(14, 110);
            this.txt_Sucursal.Name = "txt_Sucursal";
            this.txt_Sucursal.Size = new System.Drawing.Size(219, 26);
            this.txt_Sucursal.TabIndex = 34;
            // 
            // tecnicosTableAdapter
            // 
            this.tecnicosTableAdapter.ClearBeforeFill = true;
            // 
            // tablaAsignacion
            // 
            this.tablaAsignacion.AllowUserToAddRows = false;
            this.tablaAsignacion.AllowUserToDeleteRows = false;
            this.tablaAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaAsignacion.AutoGenerateColumns = false;
            this.tablaAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAsignacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCitaDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.fechaAgendacionDataGridViewTextBoxColumn,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.horaCitaDataGridViewTextBoxColumn,
            this.personaQueAtendioDataGridViewTextBoxColumn,
            this.estatusCitaDataGridViewTextBoxColumn});
            this.tablaAsignacion.DataSource = this.citasAgendadasBindingSource;
            this.tablaAsignacion.Location = new System.Drawing.Point(256, 50);
            this.tablaAsignacion.Name = "tablaAsignacion";
            this.tablaAsignacion.ReadOnly = true;
            this.tablaAsignacion.Size = new System.Drawing.Size(828, 404);
            this.tablaAsignacion.TabIndex = 41;
            this.tablaAsignacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAsignacion_CellClick);
            // 
            // iDCitaDataGridViewTextBoxColumn
            // 
            this.iDCitaDataGridViewTextBoxColumn.DataPropertyName = "ID_Cita";
            this.iDCitaDataGridViewTextBoxColumn.HeaderText = "ID_Cita";
            this.iDCitaDataGridViewTextBoxColumn.Name = "iDCitaDataGridViewTextBoxColumn";
            this.iDCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAgendacionDataGridViewTextBoxColumn
            // 
            this.fechaAgendacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAgendacion";
            this.fechaAgendacionDataGridViewTextBoxColumn.HeaderText = "FechaAgendacion";
            this.fechaAgendacionDataGridViewTextBoxColumn.Name = "fechaAgendacionDataGridViewTextBoxColumn";
            this.fechaAgendacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            this.fechaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaCitaDataGridViewTextBoxColumn
            // 
            this.horaCitaDataGridViewTextBoxColumn.DataPropertyName = "HoraCita";
            this.horaCitaDataGridViewTextBoxColumn.HeaderText = "HoraCita";
            this.horaCitaDataGridViewTextBoxColumn.Name = "horaCitaDataGridViewTextBoxColumn";
            this.horaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personaQueAtendioDataGridViewTextBoxColumn
            // 
            this.personaQueAtendioDataGridViewTextBoxColumn.DataPropertyName = "PersonaQueAtendio";
            this.personaQueAtendioDataGridViewTextBoxColumn.HeaderText = "PersonaQueAtendio";
            this.personaQueAtendioDataGridViewTextBoxColumn.Name = "personaQueAtendioDataGridViewTextBoxColumn";
            this.personaQueAtendioDataGridViewTextBoxColumn.ReadOnly = true;
            this.personaQueAtendioDataGridViewTextBoxColumn.Width = 200;
            // 
            // estatusCitaDataGridViewTextBoxColumn
            // 
            this.estatusCitaDataGridViewTextBoxColumn.DataPropertyName = "EstatusCita";
            this.estatusCitaDataGridViewTextBoxColumn.HeaderText = "EstatusCita";
            this.estatusCitaDataGridViewTextBoxColumn.Name = "estatusCitaDataGridViewTextBoxColumn";
            this.estatusCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citasAgendadasBindingSource
            // 
            this.citasAgendadasBindingSource.DataMember = "CitasAgendadas";
            this.citasAgendadasBindingSource.DataSource = this.servicioElPenduloDataSet8;
            // 
            // servicioElPenduloDataSet8
            // 
            this.servicioElPenduloDataSet8.DataSetName = "servicioElPenduloDataSet8";
            this.servicioElPenduloDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasAgendadasTableAdapter
            // 
            this.citasAgendadasTableAdapter.ClearBeforeFill = true;
            // 
            // idTrabajoText
            // 
            this.idTrabajoText.Enabled = false;
            this.idTrabajoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTrabajoText.Location = new System.Drawing.Point(13, 50);
            this.idTrabajoText.Name = "idTrabajoText";
            this.idTrabajoText.Size = new System.Drawing.Size(220, 26);
            this.idTrabajoText.TabIndex = 42;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel3.Location = new System.Drawing.Point(9, 28);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(103, 19);
            this.materialLabel3.TabIndex = 44;
            this.materialLabel3.Text = "Clave Servicio";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel1.Location = new System.Drawing.Point(9, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Sucursal";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel2.Location = new System.Drawing.Point(9, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(99, 19);
            this.materialLabel2.TabIndex = 46;
            this.materialLabel2.Text = "Fecha de Cita";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel4.Location = new System.Drawing.Point(9, 227);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(92, 19);
            this.materialLabel4.TabIndex = 47;
            this.materialLabel4.Text = "Hora de Cita";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel5.Location = new System.Drawing.Point(9, 289);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(174, 19);
            this.materialLabel5.TabIndex = 48;
            this.materialLabel5.Text = "Persona que Realizo cita";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel6.Location = new System.Drawing.Point(7, 347);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(129, 19);
            this.materialLabel6.TabIndex = 49;
            this.materialLabel6.Text = "Técnico Asignado";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel7.Location = new System.Drawing.Point(11, 437);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(140, 19);
            this.materialLabel7.TabIndex = 50;
            this.materialLabel7.Text = "Estatus del servicio";
            // 
            // list_Tecnicos
            // 
            this.list_Tecnicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Tecnicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.list_Tecnicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.list_Tecnicos.DataSource = this.tecnicosBindingSource2;
            this.list_Tecnicos.DisplayMember = "Nombres";
            this.list_Tecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_Tecnicos.FormattingEnabled = true;
            this.list_Tecnicos.Location = new System.Drawing.Point(13, 401);
            this.list_Tecnicos.Name = "list_Tecnicos";
            this.list_Tecnicos.Size = new System.Drawing.Size(220, 21);
            this.list_Tecnicos.TabIndex = 51;
            this.list_Tecnicos.ValueMember = "ID_Tecnico";
            this.list_Tecnicos.SelectedIndexChanged += new System.EventHandler(this.list_Tecnicos_SelectedIndexChanged);
            // 
            // tecnicosBindingSource2
            // 
            this.tecnicosBindingSource2.DataMember = "Tecnicos";
            this.tecnicosBindingSource2.DataSource = this.tecnicosAsignacion;
            // 
            // tecnicosAsignacion
            // 
            this.tecnicosAsignacion.DataSetName = "tecnicosAsignacion";
            this.tecnicosAsignacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_horaCita
            // 
            this.txt_horaCita.Enabled = false;
            this.txt_horaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horaCita.Location = new System.Drawing.Point(16, 259);
            this.txt_horaCita.Name = "txt_horaCita";
            this.txt_horaCita.Size = new System.Drawing.Size(217, 26);
            this.txt_horaCita.TabIndex = 35;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(16, 188);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(217, 26);
            this.txtFecha.TabIndex = 36;
            // 
            // servicioElPenduloDataSet9
            // 
            this.servicioElPenduloDataSet9.DataSetName = "servicioElPenduloDataSet9";
            this.servicioElPenduloDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tecnicosBindingSource1
            // 
            this.tecnicosBindingSource1.DataMember = "Tecnicos";
            this.tecnicosBindingSource1.DataSource = this.servicioElPenduloDataSet9;
            // 
            // tecnicosTableAdapter1
            // 
            this.tecnicosTableAdapter1.ClearBeforeFill = true;
            // 
            // tecnicosTableAdapter2
            // 
            this.tecnicosTableAdapter2.ClearBeforeFill = true;
            // 
            // txtIdTecnico
            // 
            this.txtIdTecnico.Enabled = false;
            this.txtIdTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTecnico.Location = new System.Drawing.Point(13, 369);
            this.txtIdTecnico.Name = "txtIdTecnico";
            this.txtIdTecnico.Size = new System.Drawing.Size(220, 26);
            this.txtIdTecnico.TabIndex = 53;
            // 
            // list_Estatus
            // 
            this.list_Estatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Estatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.list_Estatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.list_Estatus.DisplayMember = "0";
            this.list_Estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_Estatus.FormattingEnabled = true;
            this.list_Estatus.Items.AddRange(new object[] {
            "Agendado",
            "Pendiente"});
            this.list_Estatus.Location = new System.Drawing.Point(15, 459);
            this.list_Estatus.Name = "list_Estatus";
            this.list_Estatus.Size = new System.Drawing.Size(218, 21);
            this.list_Estatus.TabIndex = 52;
            this.list_Estatus.ValueMember = "0";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.Depth = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(855, 478);
            this.btn_Cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Primary = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 33);
            this.btn_Cancelar.TabIndex = 54;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Asignar.Depth = 0;
            this.btn_Asignar.Location = new System.Drawing.Point(985, 478);
            this.btn_Asignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Primary = true;
            this.btn_Asignar.Size = new System.Drawing.Size(99, 33);
            this.btn_Asignar.TabIndex = 55;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = true;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // AsignarTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1106, 523);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txtIdTecnico);
            this.Controls.Add(this.list_Estatus);
            this.Controls.Add(this.list_Tecnicos);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.idTrabajoText);
            this.Controls.Add(this.tablaAsignacion);
            this.Controls.Add(this.txt_PQAtendio);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txt_horaCita);
            this.Controls.Add(this.txt_Sucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignarTrabajos";
            this.Text = "AsignarTrabajos";
            this.Load += new System.EventHandler(this.AsignarTrabajos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaTecnicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasAgendadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_PQAtendio;
        private System.Windows.Forms.TextBox txt_Sucursal;
        private dataSetListaTecnicos dataSetListaTecnicos;
        private System.Windows.Forms.BindingSource tecnicosBindingSource;
        private dataSetListaTecnicosTableAdapters.TecnicosTableAdapter tecnicosTableAdapter;
        private System.Windows.Forms.DataGridView tablaAsignacion;
        private servicioElPenduloDataSet8 servicioElPenduloDataSet8;
        private System.Windows.Forms.BindingSource citasAgendadasBindingSource;
        private servicioElPenduloDataSet8TableAdapters.CitasAgendadasTableAdapter citasAgendadasTableAdapter;
        private System.Windows.Forms.TextBox idTrabajoText;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox list_Tecnicos;
        private System.Windows.Forms.TextBox txt_horaCita;
        private System.Windows.Forms.TextBox txtFecha;
        private servicioElPenduloDataSet9 servicioElPenduloDataSet9;
        private System.Windows.Forms.BindingSource tecnicosBindingSource1;
        private servicioElPenduloDataSet9TableAdapters.TecnicosTableAdapter tecnicosTableAdapter1;
        private tecnicosAsignacion tecnicosAsignacion;
        private System.Windows.Forms.BindingSource tecnicosBindingSource2;
        private tecnicosAsignacionTableAdapters.TecnicosTableAdapter tecnicosTableAdapter2;
        private System.Windows.Forms.TextBox txtIdTecnico;
        private System.Windows.Forms.ComboBox list_Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAgendacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaQueAtendioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusCitaDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Cancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Asignar;
    }
}