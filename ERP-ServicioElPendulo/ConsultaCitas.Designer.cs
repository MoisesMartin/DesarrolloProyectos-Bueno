namespace ERP_ServicioElPendulo
{
    partial class rd_BuscarTodo
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
            this.citasAgendadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioElPenduloDataSet3 = new ERP_ServicioElPendulo.servicioElPenduloDataSet3();
            this.citasAgendadasTableAdapter = new ERP_ServicioElPendulo.servicioElPenduloDataSet3TableAdapters.CitasAgendadasTableAdapter();
            this.btn_generarPDF = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Filtrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.rdBuscarTodo = new MaterialSkin.Controls.MaterialRadioButton();
            this.porFechaC = new MaterialSkin.Controls.MaterialRadioButton();
            this.porFechaA = new MaterialSkin.Controls.MaterialRadioButton();
            this.filtrarEstatus = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.operacion = new System.Windows.Forms.Label();
            this.cantColumnas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaCitas = new System.Windows.Forms.DataGridView();
            this.iDCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAgendacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaQueAtendioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porFechaAgenda = new System.Windows.Forms.DateTimePicker();
            this.fechaCita = new System.Windows.Forms.DateTimePicker();
            this.combo_Estatus = new System.Windows.Forms.ComboBox();
            this.ayuda_Filtrar = new System.Windows.Forms.LinkLabel();
            this.calendarioCitas = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.citasAgendadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // citasAgendadasBindingSource
            // 
            this.citasAgendadasBindingSource.DataMember = "CitasAgendadas";
            this.citasAgendadasBindingSource.DataSource = this.servicioElPenduloDataSet3;
            // 
            // servicioElPenduloDataSet3
            // 
            this.servicioElPenduloDataSet3.DataSetName = "servicioElPenduloDataSet3";
            this.servicioElPenduloDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasAgendadasTableAdapter
            // 
            this.citasAgendadasTableAdapter.ClearBeforeFill = true;
            // 
            // btn_generarPDF
            // 
            this.btn_generarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generarPDF.Depth = 0;
            this.btn_generarPDF.Location = new System.Drawing.Point(878, 546);
            this.btn_generarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_generarPDF.Name = "btn_generarPDF";
            this.btn_generarPDF.Primary = true;
            this.btn_generarPDF.Size = new System.Drawing.Size(120, 38);
            this.btn_generarPDF.TabIndex = 75;
            this.btn_generarPDF.Text = "Generar PDF";
            this.btn_generarPDF.UseVisualStyleBackColor = true;
            this.btn_generarPDF.Click += new System.EventHandler(this.btn_generarPDF_Click);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Filtrar.Depth = 0;
            this.btn_Filtrar.Location = new System.Drawing.Point(878, 150);
            this.btn_Filtrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Primary = true;
            this.btn_Filtrar.Size = new System.Drawing.Size(91, 35);
            this.btn_Filtrar.TabIndex = 73;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(717, 195);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(81, 19);
            this.materialLabel2.TabIndex = 72;
            this.materialLabel2.Text = "Calendario";
            // 
            // rdBuscarTodo
            // 
            this.rdBuscarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdBuscarTodo.AutoSize = true;
            this.rdBuscarTodo.Checked = true;
            this.rdBuscarTodo.Depth = 0;
            this.rdBuscarTodo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdBuscarTodo.Location = new System.Drawing.Point(860, 117);
            this.rdBuscarTodo.Margin = new System.Windows.Forms.Padding(0);
            this.rdBuscarTodo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdBuscarTodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdBuscarTodo.Name = "rdBuscarTodo";
            this.rdBuscarTodo.Ripple = true;
            this.rdBuscarTodo.Size = new System.Drawing.Size(109, 30);
            this.rdBuscarTodo.TabIndex = 71;
            this.rdBuscarTodo.TabStop = true;
            this.rdBuscarTodo.Text = "Mostrar todo";
            this.rdBuscarTodo.UseVisualStyleBackColor = true;
            // 
            // porFechaC
            // 
            this.porFechaC.AutoSize = true;
            this.porFechaC.Depth = 0;
            this.porFechaC.Font = new System.Drawing.Font("Roboto", 10F);
            this.porFechaC.Location = new System.Drawing.Point(373, 116);
            this.porFechaC.Margin = new System.Windows.Forms.Padding(0);
            this.porFechaC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.porFechaC.MouseState = MaterialSkin.MouseState.HOVER;
            this.porFechaC.Name = "porFechaC";
            this.porFechaC.Ripple = true;
            this.porFechaC.Size = new System.Drawing.Size(119, 30);
            this.porFechaC.TabIndex = 70;
            this.porFechaC.Text = "Por Fecha Cita";
            this.porFechaC.UseVisualStyleBackColor = true;
            // 
            // porFechaA
            // 
            this.porFechaA.AutoSize = true;
            this.porFechaA.Depth = 0;
            this.porFechaA.Font = new System.Drawing.Font("Roboto", 10F);
            this.porFechaA.Location = new System.Drawing.Point(185, 116);
            this.porFechaA.Margin = new System.Windows.Forms.Padding(0);
            this.porFechaA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.porFechaA.MouseState = MaterialSkin.MouseState.HOVER;
            this.porFechaA.Name = "porFechaA";
            this.porFechaA.Ripple = true;
            this.porFechaA.Size = new System.Drawing.Size(168, 30);
            this.porFechaA.TabIndex = 69;
            this.porFechaA.Text = "Por Fecha Agendación";
            this.porFechaA.UseVisualStyleBackColor = true;
            // 
            // filtrarEstatus
            // 
            this.filtrarEstatus.AutoSize = true;
            this.filtrarEstatus.Depth = 0;
            this.filtrarEstatus.Font = new System.Drawing.Font("Roboto", 10F);
            this.filtrarEstatus.Location = new System.Drawing.Point(38, 116);
            this.filtrarEstatus.Margin = new System.Windows.Forms.Padding(0);
            this.filtrarEstatus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.filtrarEstatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.filtrarEstatus.Name = "filtrarEstatus";
            this.filtrarEstatus.Ripple = true;
            this.filtrarEstatus.Size = new System.Drawing.Size(100, 30);
            this.filtrarEstatus.TabIndex = 68;
            this.filtrarEstatus.Text = "Por estatus";
            this.filtrarEstatus.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(34, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 19);
            this.materialLabel1.TabIndex = 67;
            this.materialLabel1.Text = "Criterios de Filtrado:";
            // 
            // operacion
            // 
            this.operacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.operacion.AutoSize = true;
            this.operacion.Location = new System.Drawing.Point(666, 99);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(167, 13);
            this.operacion.TabIndex = 66;
            this.operacion.Text = "Esto es el titulo del PDF, no borrar";
            this.operacion.Visible = false;
            // 
            // cantColumnas
            // 
            this.cantColumnas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cantColumnas.AutoSize = true;
            this.cantColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantColumnas.Location = new System.Drawing.Point(720, 467);
            this.cantColumnas.Name = "cantColumnas";
            this.cantColumnas.Size = new System.Drawing.Size(20, 24);
            this.cantColumnas.TabIndex = 65;
            this.cantColumnas.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(717, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Total de Columnas:";
            // 
            // tablaCitas
            // 
            this.tablaCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaCitas.AutoGenerateColumns = false;
            this.tablaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCitaDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.fechaAgendacionDataGridViewTextBoxColumn,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.horaCitaDataGridViewTextBoxColumn,
            this.personaQueAtendioDataGridViewTextBoxColumn,
            this.estatusCitaDataGridViewTextBoxColumn});
            this.tablaCitas.DataSource = this.citasAgendadasBindingSource;
            this.tablaCitas.Location = new System.Drawing.Point(38, 195);
            this.tablaCitas.MinimumSize = new System.Drawing.Size(478, 316);
            this.tablaCitas.Name = "tablaCitas";
            this.tablaCitas.Size = new System.Drawing.Size(621, 337);
            this.tablaCitas.TabIndex = 63;
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
            // 
            // fechaAgendacionDataGridViewTextBoxColumn
            // 
            this.fechaAgendacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAgendacion";
            this.fechaAgendacionDataGridViewTextBoxColumn.HeaderText = "FechaAgendacion";
            this.fechaAgendacionDataGridViewTextBoxColumn.Name = "fechaAgendacionDataGridViewTextBoxColumn";
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "FechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            // 
            // horaCitaDataGridViewTextBoxColumn
            // 
            this.horaCitaDataGridViewTextBoxColumn.DataPropertyName = "HoraCita";
            this.horaCitaDataGridViewTextBoxColumn.HeaderText = "HoraCita";
            this.horaCitaDataGridViewTextBoxColumn.Name = "horaCitaDataGridViewTextBoxColumn";
            // 
            // personaQueAtendioDataGridViewTextBoxColumn
            // 
            this.personaQueAtendioDataGridViewTextBoxColumn.DataPropertyName = "PersonaQueAtendio";
            this.personaQueAtendioDataGridViewTextBoxColumn.HeaderText = "PersonaQueAtendio";
            this.personaQueAtendioDataGridViewTextBoxColumn.Name = "personaQueAtendioDataGridViewTextBoxColumn";
            // 
            // estatusCitaDataGridViewTextBoxColumn
            // 
            this.estatusCitaDataGridViewTextBoxColumn.DataPropertyName = "EstatusCita";
            this.estatusCitaDataGridViewTextBoxColumn.HeaderText = "EstatusCita";
            this.estatusCitaDataGridViewTextBoxColumn.Name = "estatusCitaDataGridViewTextBoxColumn";
            // 
            // porFechaAgenda
            // 
            this.porFechaAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.porFechaAgenda.Location = new System.Drawing.Point(373, 150);
            this.porFechaAgenda.Name = "porFechaAgenda";
            this.porFechaAgenda.Size = new System.Drawing.Size(143, 20);
            this.porFechaAgenda.TabIndex = 62;
            // 
            // fechaCita
            // 
            this.fechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCita.Location = new System.Drawing.Point(185, 149);
            this.fechaCita.Name = "fechaCita";
            this.fechaCita.Size = new System.Drawing.Size(143, 20);
            this.fechaCita.TabIndex = 61;
            // 
            // combo_Estatus
            // 
            this.combo_Estatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Estatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Estatus.FormattingEnabled = true;
            this.combo_Estatus.Items.AddRange(new object[] {
            "Pendiente",
            "Agendado"});
            this.combo_Estatus.Location = new System.Drawing.Point(38, 149);
            this.combo_Estatus.Name = "combo_Estatus";
            this.combo_Estatus.Size = new System.Drawing.Size(121, 21);
            this.combo_Estatus.TabIndex = 60;
            this.combo_Estatus.Text = "Pendiente";
            // 
            // ayuda_Filtrar
            // 
            this.ayuda_Filtrar.AutoSize = true;
            this.ayuda_Filtrar.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayuda_Filtrar.Location = new System.Drawing.Point(186, 91);
            this.ayuda_Filtrar.Name = "ayuda_Filtrar";
            this.ayuda_Filtrar.Size = new System.Drawing.Size(43, 17);
            this.ayuda_Filtrar.TabIndex = 59;
            this.ayuda_Filtrar.TabStop = true;
            this.ayuda_Filtrar.Text = "Ayuda";
            // 
            // calendarioCitas
            // 
            this.calendarioCitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarioCitas.BackColor = System.Drawing.Color.Silver;
            this.calendarioCitas.Location = new System.Drawing.Point(721, 244);
            this.calendarioCitas.Name = "calendarioCitas";
            this.calendarioCitas.TabIndex = 58;
            // 
            // rd_BuscarTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1013, 596);
            this.Controls.Add(this.btn_generarPDF);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.rdBuscarTodo);
            this.Controls.Add(this.porFechaC);
            this.Controls.Add(this.porFechaA);
            this.Controls.Add(this.filtrarEstatus);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.cantColumnas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablaCitas);
            this.Controls.Add(this.porFechaAgenda);
            this.Controls.Add(this.fechaCita);
            this.Controls.Add(this.combo_Estatus);
            this.Controls.Add(this.ayuda_Filtrar);
            this.Controls.Add(this.calendarioCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rd_BuscarTodo";
            this.Text = "Consulta de Citas";
            this.Load += new System.EventHandler(this.btn_Back_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citasAgendadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private servicioElPenduloDataSet3 servicioElPenduloDataSet3;
        private System.Windows.Forms.BindingSource citasAgendadasBindingSource;
        private servicioElPenduloDataSet3TableAdapters.CitasAgendadasTableAdapter citasAgendadasTableAdapter;
        private MaterialSkin.Controls.MaterialRaisedButton btn_generarPDF;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Filtrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton rdBuscarTodo;
        private MaterialSkin.Controls.MaterialRadioButton porFechaC;
        private MaterialSkin.Controls.MaterialRadioButton porFechaA;
        private MaterialSkin.Controls.MaterialRadioButton filtrarEstatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.Label cantColumnas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAgendacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaQueAtendioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker porFechaAgenda;
        private System.Windows.Forms.DateTimePicker fechaCita;
        private System.Windows.Forms.ComboBox combo_Estatus;
        private System.Windows.Forms.LinkLabel ayuda_Filtrar;
        private System.Windows.Forms.MonthCalendar calendarioCitas;
    }
}