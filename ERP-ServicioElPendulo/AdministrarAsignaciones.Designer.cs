namespace ERP_ServicioElPendulo
{
    partial class AdministrarAsignaciones
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
            this.tablaAsignaciones = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioElPenduloDataSet10 = new ERP_ServicioElPendulo.servicioElPenduloDataSet10();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreCitante = new System.Windows.Forms.TextBox();
            this.idTrabajoText = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIdTecnico = new System.Windows.Forms.TextBox();
            this.txt_NTecnico = new System.Windows.Forms.TextBox();
            this.txt_Sucursal = new System.Windows.Forms.TextBox();
            this.list_Estatus = new System.Windows.Forms.ComboBox();
            this.asignacionesTableAdapter = new ERP_ServicioElPendulo.servicioElPenduloDataSet10TableAdapters.AsignacionesTableAdapter();
            this.btn_Aceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.generarPDF = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.rd_BuscarTodo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.rd_FiltrarEstatus = new MaterialSkin.Controls.MaterialRadioButton();
            this.list_filtrarEstatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaAsignaciones
            // 
            this.tablaAsignaciones.AutoGenerateColumns = false;
            this.tablaAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDTrabajoDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.iDTecnicoDataGridViewTextBoxColumn,
            this.nombreTecnicoDataGridViewTextBoxColumn,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.nombreCitanteDataGridViewTextBoxColumn,
            this.estatusTrabajoDataGridViewTextBoxColumn});
            this.tablaAsignaciones.DataSource = this.asignacionesBindingSource;
            this.tablaAsignaciones.Location = new System.Drawing.Point(279, 78);
            this.tablaAsignaciones.Name = "tablaAsignaciones";
            this.tablaAsignaciones.ReadOnly = true;
            this.tablaAsignaciones.Size = new System.Drawing.Size(842, 390);
            this.tablaAsignaciones.TabIndex = 0;
            this.tablaAsignaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAsignaciones_CellClick);
            this.tablaAsignaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAsignaciones_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTrabajoDataGridViewTextBoxColumn
            // 
            this.iDTrabajoDataGridViewTextBoxColumn.DataPropertyName = "ID_Trabajo";
            this.iDTrabajoDataGridViewTextBoxColumn.HeaderText = "ID_Trabajo";
            this.iDTrabajoDataGridViewTextBoxColumn.Name = "iDTrabajoDataGridViewTextBoxColumn";
            this.iDTrabajoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTecnicoDataGridViewTextBoxColumn
            // 
            this.iDTecnicoDataGridViewTextBoxColumn.DataPropertyName = "ID_Tecnico";
            this.iDTecnicoDataGridViewTextBoxColumn.HeaderText = "ID_Tecnico";
            this.iDTecnicoDataGridViewTextBoxColumn.Name = "iDTecnicoDataGridViewTextBoxColumn";
            this.iDTecnicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreTecnicoDataGridViewTextBoxColumn
            // 
            this.nombreTecnicoDataGridViewTextBoxColumn.DataPropertyName = "NombreTecnico";
            this.nombreTecnicoDataGridViewTextBoxColumn.HeaderText = "NombreTecnico";
            this.nombreTecnicoDataGridViewTextBoxColumn.Name = "nombreTecnicoDataGridViewTextBoxColumn";
            this.nombreTecnicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            this.fechaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCitanteDataGridViewTextBoxColumn
            // 
            this.nombreCitanteDataGridViewTextBoxColumn.DataPropertyName = "NombreCitante";
            this.nombreCitanteDataGridViewTextBoxColumn.HeaderText = "NombreCitante";
            this.nombreCitanteDataGridViewTextBoxColumn.Name = "nombreCitanteDataGridViewTextBoxColumn";
            this.nombreCitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estatusTrabajoDataGridViewTextBoxColumn
            // 
            this.estatusTrabajoDataGridViewTextBoxColumn.DataPropertyName = "EstatusTrabajo";
            this.estatusTrabajoDataGridViewTextBoxColumn.HeaderText = "EstatusTrabajo";
            this.estatusTrabajoDataGridViewTextBoxColumn.Name = "estatusTrabajoDataGridViewTextBoxColumn";
            this.estatusTrabajoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asignacionesBindingSource
            // 
            this.asignacionesBindingSource.DataMember = "Asignaciones";
            this.asignacionesBindingSource.DataSource = this.servicioElPenduloDataSet10;
            // 
            // servicioElPenduloDataSet10
            // 
            this.servicioElPenduloDataSet10.DataSetName = "servicioElPenduloDataSet10";
            this.servicioElPenduloDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel3.Location = new System.Drawing.Point(12, 56);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(104, 19);
            this.materialLabel3.TabIndex = 45;
            this.materialLabel3.Text = "Clave Servicio";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel1.Location = new System.Drawing.Point(12, 117);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 46;
            this.materialLabel1.Text = "Sucursal";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel2.Location = new System.Drawing.Point(12, 175);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 47;
            this.materialLabel2.Text = "ID_Tecnico";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel4.Location = new System.Drawing.Point(12, 239);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 48;
            this.materialLabel4.Text = "Tecnico";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel5.Location = new System.Drawing.Point(12, 305);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(80, 19);
            this.materialLabel5.TabIndex = 49;
            this.materialLabel5.Text = "Fecha Cita";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel6.Location = new System.Drawing.Point(12, 369);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(115, 19);
            this.materialLabel6.TabIndex = 50;
            this.materialLabel6.Text = "Nombre Citante";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel7.Location = new System.Drawing.Point(12, 425);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(60, 19);
            this.materialLabel7.TabIndex = 51;
            this.materialLabel7.Text = "Estatus";
            // 
            // txtNombreCitante
            // 
            this.txtNombreCitante.Enabled = false;
            this.txtNombreCitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCitante.Location = new System.Drawing.Point(16, 391);
            this.txtNombreCitante.Name = "txtNombreCitante";
            this.txtNombreCitante.Size = new System.Drawing.Size(217, 26);
            this.txtNombreCitante.TabIndex = 60;
            // 
            // idTrabajoText
            // 
            this.idTrabajoText.Enabled = false;
            this.idTrabajoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTrabajoText.Location = new System.Drawing.Point(16, 78);
            this.idTrabajoText.Name = "idTrabajoText";
            this.idTrabajoText.Size = new System.Drawing.Size(217, 26);
            this.idTrabajoText.TabIndex = 58;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(16, 327);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(217, 26);
            this.txtFecha.TabIndex = 57;
            // 
            // txtIdTecnico
            // 
            this.txtIdTecnico.Enabled = false;
            this.txtIdTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTecnico.Location = new System.Drawing.Point(16, 197);
            this.txtIdTecnico.Name = "txtIdTecnico";
            this.txtIdTecnico.Size = new System.Drawing.Size(217, 26);
            this.txtIdTecnico.TabIndex = 56;
            // 
            // txt_NTecnico
            // 
            this.txt_NTecnico.Enabled = false;
            this.txt_NTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NTecnico.Location = new System.Drawing.Point(16, 261);
            this.txt_NTecnico.Name = "txt_NTecnico";
            this.txt_NTecnico.Size = new System.Drawing.Size(217, 26);
            this.txt_NTecnico.TabIndex = 55;
            // 
            // txt_Sucursal
            // 
            this.txt_Sucursal.Enabled = false;
            this.txt_Sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sucursal.Location = new System.Drawing.Point(16, 139);
            this.txt_Sucursal.Name = "txt_Sucursal";
            this.txt_Sucursal.Size = new System.Drawing.Size(217, 26);
            this.txt_Sucursal.TabIndex = 54;
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
            "Pendiente",
            "Realizado",
            "Cancelado",
            "Queja",
            "Reincidencia"});
            this.list_Estatus.Location = new System.Drawing.Point(16, 447);
            this.list_Estatus.Name = "list_Estatus";
            this.list_Estatus.Size = new System.Drawing.Size(217, 21);
            this.list_Estatus.TabIndex = 61;
            this.list_Estatus.ValueMember = "0";
            // 
            // asignacionesTableAdapter
            // 
            this.asignacionesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aceptar.Depth = 0;
            this.btn_Aceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Aceptar.Location = new System.Drawing.Point(16, 487);
            this.btn_Aceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Primary = true;
            this.btn_Aceptar.Size = new System.Drawing.Size(217, 32);
            this.btn_Aceptar.TabIndex = 62;
            this.btn_Aceptar.Text = "ACTUALIZAR ESTATUS";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // generarPDF
            // 
            this.generarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generarPDF.Depth = 0;
            this.generarPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.generarPDF.Location = new System.Drawing.Point(279, 487);
            this.generarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.generarPDF.Name = "generarPDF";
            this.generarPDF.Primary = true;
            this.generarPDF.Size = new System.Drawing.Size(217, 32);
            this.generarPDF.TabIndex = 63;
            this.generarPDF.Text = "Generar PDF";
            this.generarPDF.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(756, 17);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(97, 19);
            this.materialLabel8.TabIndex = 65;
            this.materialLabel8.Text = "Mostrar todo";
            // 
            // rd_BuscarTodo
            // 
            this.rd_BuscarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rd_BuscarTodo.AutoSize = true;
            this.rd_BuscarTodo.Checked = true;
            this.rd_BuscarTodo.Depth = 0;
            this.rd_BuscarTodo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_BuscarTodo.Location = new System.Drawing.Point(728, 12);
            this.rd_BuscarTodo.Margin = new System.Windows.Forms.Padding(0);
            this.rd_BuscarTodo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_BuscarTodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_BuscarTodo.Name = "rd_BuscarTodo";
            this.rd_BuscarTodo.Ripple = true;
            this.rd_BuscarTodo.Size = new System.Drawing.Size(25, 30);
            this.rd_BuscarTodo.TabIndex = 64;
            this.rd_BuscarTodo.TabStop = true;
            this.rd_BuscarTodo.UseVisualStyleBackColor = true;
            this.rd_BuscarTodo.CheckedChanged += new System.EventHandler(this.rd_BuscarTodo_CheckedChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(386, 17);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(130, 19);
            this.materialLabel9.TabIndex = 67;
            this.materialLabel9.Text = "Filtrar Por Estatus";
            // 
            // rd_FiltrarEstatus
            // 
            this.rd_FiltrarEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rd_FiltrarEstatus.AutoSize = true;
            this.rd_FiltrarEstatus.Depth = 0;
            this.rd_FiltrarEstatus.Font = new System.Drawing.Font("Roboto", 10F);
            this.rd_FiltrarEstatus.Location = new System.Drawing.Point(358, 12);
            this.rd_FiltrarEstatus.Margin = new System.Windows.Forms.Padding(0);
            this.rd_FiltrarEstatus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rd_FiltrarEstatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.rd_FiltrarEstatus.Name = "rd_FiltrarEstatus";
            this.rd_FiltrarEstatus.Ripple = true;
            this.rd_FiltrarEstatus.Size = new System.Drawing.Size(25, 30);
            this.rd_FiltrarEstatus.TabIndex = 66;
            this.rd_FiltrarEstatus.UseVisualStyleBackColor = true;
            // 
            // list_filtrarEstatus
            // 
            this.list_filtrarEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_filtrarEstatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.list_filtrarEstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.list_filtrarEstatus.DisplayMember = "0";
            this.list_filtrarEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_filtrarEstatus.FormattingEnabled = true;
            this.list_filtrarEstatus.Items.AddRange(new object[] {
            "Agendado",
            "Pendiente",
            "Realizado",
            "Cancelado",
            "Queja",
            "Reincidencia"});
            this.list_filtrarEstatus.Location = new System.Drawing.Point(358, 43);
            this.list_filtrarEstatus.Name = "list_filtrarEstatus";
            this.list_filtrarEstatus.Size = new System.Drawing.Size(217, 21);
            this.list_filtrarEstatus.TabIndex = 68;
            this.list_filtrarEstatus.ValueMember = "0";
            this.list_filtrarEstatus.SelectedIndexChanged += new System.EventHandler(this.list_filtrarEstatus_SelectedIndexChanged);
            // 
            // AdministrarAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1090, 531);
            this.Controls.Add(this.list_filtrarEstatus);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.rd_FiltrarEstatus);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.rd_BuscarTodo);
            this.Controls.Add(this.generarPDF);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.list_Estatus);
            this.Controls.Add(this.txtNombreCitante);
            this.Controls.Add(this.idTrabajoText);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtIdTecnico);
            this.Controls.Add(this.txt_NTecnico);
            this.Controls.Add(this.txt_Sucursal);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tablaAsignaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarAsignaciones";
            this.Text = "AdministrarAsignaciones";
            this.Load += new System.EventHandler(this.AdministrarAsignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaAsignaciones;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox txtNombreCitante;
        private System.Windows.Forms.TextBox idTrabajoText;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIdTecnico;
        private System.Windows.Forms.TextBox txt_NTecnico;
        private System.Windows.Forms.TextBox txt_Sucursal;
        private System.Windows.Forms.ComboBox list_Estatus;
        private servicioElPenduloDataSet10 servicioElPenduloDataSet10;
        private System.Windows.Forms.BindingSource asignacionesBindingSource;
        private servicioElPenduloDataSet10TableAdapters.AsignacionesTableAdapter asignacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusTrabajoDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Aceptar;
        private MaterialSkin.Controls.MaterialRaisedButton generarPDF;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialRadioButton rd_BuscarTodo;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRadioButton rd_FiltrarEstatus;
        private System.Windows.Forms.ComboBox list_filtrarEstatus;
    }
}