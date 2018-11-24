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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Asignar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.list_Estatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.list_Tecnicos = new System.Windows.Forms.ComboBox();
            this.txt_PQAtendio = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txt_horaCita = new System.Windows.Forms.TextBox();
            this.txt_Sucursal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetListaTecnicos = new ERP_ServicioElPendulo.dataSetListaTecnicos();
            this.tecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecnicosTableAdapter = new ERP_ServicioElPendulo.dataSetListaTecnicosTableAdapters.TecnicosTableAdapter();
            this.tablaAsignacion = new System.Windows.Forms.DataGridView();
            this.servicioElPenduloDataSet8 = new ERP_ServicioElPendulo.servicioElPenduloDataSet8();
            this.citasAgendadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasAgendadasTableAdapter = new ERP_ServicioElPendulo.servicioElPenduloDataSet8TableAdapters.CitasAgendadasTableAdapter();
            this.iDCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAgendacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaQueAtendioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IDTecnico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaTecnicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasAgendadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(202, 25);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Asignar Actividades";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1299, 45);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.Location = new System.Drawing.Point(990, 488);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(75, 23);
            this.btn_Asignar.TabIndex = 9;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = true;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(849, 488);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // list_Estatus
            // 
            this.list_Estatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Estatus.FormattingEnabled = true;
            this.list_Estatus.Items.AddRange(new object[] {
            "Pendiente",
            "Cancelado",
            "Realizado",
            "Queja",
            "Reincidencia"});
            this.list_Estatus.Location = new System.Drawing.Point(17, 390);
            this.list_Estatus.Name = "list_Estatus";
            this.list_Estatus.Size = new System.Drawing.Size(217, 28);
            this.list_Estatus.TabIndex = 40;
            this.list_Estatus.Text = "Pendiente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Estatus Servicio";
            // 
            // list_Tecnicos
            // 
            this.list_Tecnicos.DataSource = this.tecnicosBindingSource;
            this.list_Tecnicos.DisplayMember = "Nombres";
            this.list_Tecnicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Tecnicos.FormattingEnabled = true;
            this.list_Tecnicos.Location = new System.Drawing.Point(359, 488);
            this.list_Tecnicos.Name = "list_Tecnicos";
            this.list_Tecnicos.Size = new System.Drawing.Size(217, 28);
            this.list_Tecnicos.TabIndex = 38;
            this.list_Tecnicos.ValueMember = "Nombres";
            // 
            // txt_PQAtendio
            // 
            this.txt_PQAtendio.Enabled = false;
            this.txt_PQAtendio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PQAtendio.Location = new System.Drawing.Point(17, 314);
            this.txt_PQAtendio.Name = "txt_PQAtendio";
            this.txt_PQAtendio.Size = new System.Drawing.Size(217, 26);
            this.txt_PQAtendio.TabIndex = 37;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(17, 161);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(217, 26);
            this.txtFecha.TabIndex = 36;
            // 
            // txt_horaCita
            // 
            this.txt_horaCita.Enabled = false;
            this.txt_horaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horaCita.Location = new System.Drawing.Point(17, 232);
            this.txt_horaCita.Name = "txt_horaCita";
            this.txt_horaCita.Size = new System.Drawing.Size(217, 26);
            this.txt_horaCita.TabIndex = 35;
            // 
            // txt_Sucursal
            // 
            this.txt_Sucursal.Enabled = false;
            this.txt_Sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sucursal.Location = new System.Drawing.Point(17, 75);
            this.txt_Sucursal.Name = "txt_Sucursal";
            this.txt_Sucursal.Size = new System.Drawing.Size(217, 26);
            this.txt_Sucursal.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha de Cita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Persona que realizo la cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Hora de Cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Técnico a Asignar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sucursal";
            // 
            // dataSetListaTecnicos
            // 
            this.dataSetListaTecnicos.DataSetName = "dataSetListaTecnicos";
            this.dataSetListaTecnicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tecnicosBindingSource
            // 
            this.tecnicosBindingSource.DataMember = "Tecnicos";
            this.tecnicosBindingSource.DataSource = this.dataSetListaTecnicos;
            // 
            // tecnicosTableAdapter
            // 
            this.tecnicosTableAdapter.ClearBeforeFill = true;
            // 
            // tablaAsignacion
            // 
            this.tablaAsignacion.AllowUserToAddRows = false;
            this.tablaAsignacion.AllowUserToDeleteRows = false;
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
            this.tablaAsignacion.Location = new System.Drawing.Point(359, 50);
            this.tablaAsignacion.Name = "tablaAsignacion";
            this.tablaAsignacion.ReadOnly = true;
            this.tablaAsignacion.Size = new System.Drawing.Size(706, 404);
            this.tablaAsignacion.TabIndex = 41;
            this.tablaAsignacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAsignacion_CellClick);
            // 
            // servicioElPenduloDataSet8
            // 
            this.servicioElPenduloDataSet8.DataSetName = "servicioElPenduloDataSet8";
            this.servicioElPenduloDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasAgendadasBindingSource
            // 
            this.citasAgendadasBindingSource.DataMember = "CitasAgendadas";
            this.citasAgendadasBindingSource.DataSource = this.servicioElPenduloDataSet8;
            // 
            // citasAgendadasTableAdapter
            // 
            this.citasAgendadasTableAdapter.ClearBeforeFill = true;
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
            // 
            // estatusCitaDataGridViewTextBoxColumn
            // 
            this.estatusCitaDataGridViewTextBoxColumn.DataPropertyName = "EstatusCita";
            this.estatusCitaDataGridViewTextBoxColumn.HeaderText = "EstatusCita";
            this.estatusCitaDataGridViewTextBoxColumn.Name = "estatusCitaDataGridViewTextBoxColumn";
            this.estatusCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "ID Tecnico";
            // 
            // txt_IDTecnico
            // 
            this.txt_IDTecnico.Enabled = false;
            this.txt_IDTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDTecnico.Location = new System.Drawing.Point(17, 462);
            this.txt_IDTecnico.Name = "txt_IDTecnico";
            this.txt_IDTecnico.Size = new System.Drawing.Size(217, 26);
            this.txt_IDTecnico.TabIndex = 43;
            // 
            // AsignarTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 523);
            this.Controls.Add(this.txt_IDTecnico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tablaAsignacion);
            this.Controls.Add(this.list_Estatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_Tecnicos);
            this.Controls.Add(this.txt_PQAtendio);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txt_horaCita);
            this.Controls.Add(this.txt_Sucursal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AsignarTrabajos";
            this.Text = "AsignarTrabajos";
            this.Load += new System.EventHandler(this.AsignarTrabajos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaTecnicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasAgendadasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Asignar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox list_Estatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox list_Tecnicos;
        private System.Windows.Forms.TextBox txt_PQAtendio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txt_horaCita;
        private System.Windows.Forms.TextBox txt_Sucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dataSetListaTecnicos dataSetListaTecnicos;
        private System.Windows.Forms.BindingSource tecnicosBindingSource;
        private dataSetListaTecnicosTableAdapters.TecnicosTableAdapter tecnicosTableAdapter;
        private System.Windows.Forms.DataGridView tablaAsignacion;
        private servicioElPenduloDataSet8 servicioElPenduloDataSet8;
        private System.Windows.Forms.BindingSource citasAgendadasBindingSource;
        private servicioElPenduloDataSet8TableAdapters.CitasAgendadasTableAdapter citasAgendadasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAgendacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaQueAtendioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_IDTecnico;
    }
}