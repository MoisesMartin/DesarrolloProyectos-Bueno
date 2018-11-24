﻿namespace ERP_ServicioElPendulo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calendarioCitas = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.ayuda_Filtrar = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_generarPDF = new System.Windows.Forms.Button();
            this.combo_Estatus = new System.Windows.Forms.ComboBox();
            this.fechaCita = new System.Windows.Forms.DateTimePicker();
            this.porFechaAgenda = new System.Windows.Forms.DateTimePicker();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.tablaCitas = new System.Windows.Forms.DataGridView();
            this.iDCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAgendacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaQueAtendioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citasAgendadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioElPenduloDataSet3 = new ERP_ServicioElPendulo.servicioElPenduloDataSet3();
            this.citasAgendadasTableAdapter = new ERP_ServicioElPendulo.servicioElPenduloDataSet3TableAdapters.CitasAgendadasTableAdapter();
            this.rdBuscarTodo = new System.Windows.Forms.RadioButton();
            this.porFechaC = new System.Windows.Forms.RadioButton();
            this.porFechaA = new System.Windows.Forms.RadioButton();
            this.filtrarEstatus = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cantColumnas = new System.Windows.Forms.Label();
            this.operacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasAgendadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consulta de Citas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendarioCitas
            // 
            this.calendarioCitas.BackColor = System.Drawing.Color.Silver;
            this.calendarioCitas.Location = new System.Drawing.Point(784, 151);
            this.calendarioCitas.Name = "calendarioCitas";
            this.calendarioCitas.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Calendario";
            // 
            // ayuda_Filtrar
            // 
            this.ayuda_Filtrar.AutoSize = true;
            this.ayuda_Filtrar.Location = new System.Drawing.Point(117, 53);
            this.ayuda_Filtrar.Name = "ayuda_Filtrar";
            this.ayuda_Filtrar.Size = new System.Drawing.Size(37, 13);
            this.ayuda_Filtrar.TabIndex = 28;
            this.ayuda_Filtrar.TabStop = true;
            this.ayuda_Filtrar.Text = "Ayuda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Criterios de Filtrado:";
            // 
            // btn_generarPDF
            // 
            this.btn_generarPDF.Location = new System.Drawing.Point(654, 509);
            this.btn_generarPDF.Name = "btn_generarPDF";
            this.btn_generarPDF.Size = new System.Drawing.Size(113, 23);
            this.btn_generarPDF.TabIndex = 29;
            this.btn_generarPDF.Text = "Generar PDF";
            this.btn_generarPDF.UseVisualStyleBackColor = true;
            this.btn_generarPDF.Click += new System.EventHandler(this.btn_generarPDF_Click);
            // 
            // combo_Estatus
            // 
            this.combo_Estatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Estatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Estatus.FormattingEnabled = true;
            this.combo_Estatus.Items.AddRange(new object[] {
            "Pendiente",
            "Agendado"});
            this.combo_Estatus.Location = new System.Drawing.Point(26, 105);
            this.combo_Estatus.Name = "combo_Estatus";
            this.combo_Estatus.Size = new System.Drawing.Size(121, 21);
            this.combo_Estatus.TabIndex = 33;
            this.combo_Estatus.TextChanged += new System.EventHandler(this.combo_Estatus_TextChanged);
            // 
            // fechaCita
            // 
            this.fechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCita.Location = new System.Drawing.Point(173, 105);
            this.fechaCita.Name = "fechaCita";
            this.fechaCita.Size = new System.Drawing.Size(143, 20);
            this.fechaCita.TabIndex = 34;
            // 
            // porFechaAgenda
            // 
            this.porFechaAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.porFechaAgenda.Location = new System.Drawing.Point(361, 106);
            this.porFechaAgenda.Name = "porFechaAgenda";
            this.porFechaAgenda.Size = new System.Drawing.Size(143, 20);
            this.porFechaAgenda.TabIndex = 35;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(580, 103);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(113, 23);
            this.btn_Filtrar.TabIndex = 36;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // tablaCitas
            // 
            this.tablaCitas.AutoGenerateColumns = false;
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
            this.tablaCitas.Location = new System.Drawing.Point(26, 151);
            this.tablaCitas.Name = "tablaCitas";
            this.tablaCitas.Size = new System.Drawing.Size(754, 329);
            this.tablaCitas.TabIndex = 37;
            this.tablaCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCitas_CellContentClick_1);
            // 
            // iDCitaDataGridViewTextBoxColumn
            // 
            this.iDCitaDataGridViewTextBoxColumn.DataPropertyName = "ID_Cita";
            this.iDCitaDataGridViewTextBoxColumn.HeaderText = "ID_Cita";
            this.iDCitaDataGridViewTextBoxColumn.Name = "iDCitaDataGridViewTextBoxColumn";
            this.iDCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCitaDataGridViewTextBoxColumn.Width = 50;
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
            this.horaCitaDataGridViewTextBoxColumn.Width = 70;
            // 
            // personaQueAtendioDataGridViewTextBoxColumn
            // 
            this.personaQueAtendioDataGridViewTextBoxColumn.DataPropertyName = "PersonaQueAtendio";
            this.personaQueAtendioDataGridViewTextBoxColumn.HeaderText = "PersonaQueAtendio";
            this.personaQueAtendioDataGridViewTextBoxColumn.Name = "personaQueAtendioDataGridViewTextBoxColumn";
            this.personaQueAtendioDataGridViewTextBoxColumn.Width = 200;
            // 
            // estatusCitaDataGridViewTextBoxColumn
            // 
            this.estatusCitaDataGridViewTextBoxColumn.DataPropertyName = "EstatusCita";
            this.estatusCitaDataGridViewTextBoxColumn.HeaderText = "EstatusCita";
            this.estatusCitaDataGridViewTextBoxColumn.Name = "estatusCitaDataGridViewTextBoxColumn";
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
            // rdBuscarTodo
            // 
            this.rdBuscarTodo.AutoSize = true;
            this.rdBuscarTodo.Location = new System.Drawing.Point(580, 81);
            this.rdBuscarTodo.Name = "rdBuscarTodo";
            this.rdBuscarTodo.Size = new System.Drawing.Size(88, 17);
            this.rdBuscarTodo.TabIndex = 38;
            this.rdBuscarTodo.TabStop = true;
            this.rdBuscarTodo.Text = "Mostrar Todo";
            this.rdBuscarTodo.UseVisualStyleBackColor = true;
            // 
            // porFechaC
            // 
            this.porFechaC.AutoSize = true;
            this.porFechaC.Location = new System.Drawing.Point(361, 81);
            this.porFechaC.Name = "porFechaC";
            this.porFechaC.Size = new System.Drawing.Size(89, 17);
            this.porFechaC.TabIndex = 39;
            this.porFechaC.TabStop = true;
            this.porFechaC.Text = "PorFechaCita";
            this.porFechaC.UseVisualStyleBackColor = true;
            // 
            // porFechaA
            // 
            this.porFechaA.AutoSize = true;
            this.porFechaA.Location = new System.Drawing.Point(173, 81);
            this.porFechaA.Name = "porFechaA";
            this.porFechaA.Size = new System.Drawing.Size(128, 17);
            this.porFechaA.TabIndex = 40;
            this.porFechaA.TabStop = true;
            this.porFechaA.Text = "PorFechaAgendacion";
            this.porFechaA.UseVisualStyleBackColor = true;
            // 
            // filtrarEstatus
            // 
            this.filtrarEstatus.AutoSize = true;
            this.filtrarEstatus.Location = new System.Drawing.Point(26, 82);
            this.filtrarEstatus.Name = "filtrarEstatus";
            this.filtrarEstatus.Size = new System.Drawing.Size(71, 17);
            this.filtrarEstatus.TabIndex = 41;
            this.filtrarEstatus.TabStop = true;
            this.filtrarEstatus.Text = "PorStatus";
            this.filtrarEstatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(811, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Total de Columnas:";
            // 
            // cantColumnas
            // 
            this.cantColumnas.AutoSize = true;
            this.cantColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantColumnas.Location = new System.Drawing.Point(814, 391);
            this.cantColumnas.Name = "cantColumnas";
            this.cantColumnas.Size = new System.Drawing.Size(20, 24);
            this.cantColumnas.TabIndex = 43;
            this.cantColumnas.Text = "0";
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.Location = new System.Drawing.Point(723, 82);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(119, 13);
            this.operacion.TabIndex = 44;
            this.operacion.Text = "Esto es el titulo del PDF";
            this.operacion.Visible = false;
            // 
            // rd_BuscarTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1033, 535);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.cantColumnas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filtrarEstatus);
            this.Controls.Add(this.porFechaA);
            this.Controls.Add(this.porFechaC);
            this.Controls.Add(this.rdBuscarTodo);
            this.Controls.Add(this.tablaCitas);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.porFechaAgenda);
            this.Controls.Add(this.fechaCita);
            this.Controls.Add(this.combo_Estatus);
            this.Controls.Add(this.btn_generarPDF);
            this.Controls.Add(this.ayuda_Filtrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calendarioCitas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "rd_BuscarTodo";
            this.Text = "Consultar citas";
            this.Load += new System.EventHandler(this.btn_Back_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasAgendadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar calendarioCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ayuda_Filtrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_generarPDF;
        private System.Windows.Forms.ComboBox combo_Estatus;
        private System.Windows.Forms.DateTimePicker fechaCita;
        private System.Windows.Forms.DateTimePicker porFechaAgenda;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.DataGridView tablaCitas;
        private servicioElPenduloDataSet3 servicioElPenduloDataSet3;
        private System.Windows.Forms.BindingSource citasAgendadasBindingSource;
        private servicioElPenduloDataSet3TableAdapters.CitasAgendadasTableAdapter citasAgendadasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAgendacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaQueAtendioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rdBuscarTodo;
        private System.Windows.Forms.RadioButton porFechaC;
        private System.Windows.Forms.RadioButton porFechaA;
        private System.Windows.Forms.RadioButton filtrarEstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cantColumnas;
        private System.Windows.Forms.Label operacion;
    }
}