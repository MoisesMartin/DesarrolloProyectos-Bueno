namespace ERP_ServicioElPendulo
{
    partial class Proveedores
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
            this.tab_Proveedores = new System.Windows.Forms.TabControl();
            this.fechaCotizacion = new System.Windows.Forms.TabPage();
            this.cantidadItems = new System.Windows.Forms.NumericUpDown();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.fecha_Cotizacion = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.precioItem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_gest_Ballena = new System.Windows.Forms.Button();
            this.totalProv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameP = new System.Windows.Forms.Label();
            this.tablaLaBallena = new System.Windows.Forms.DataGridView();
            this.claveArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laBallenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioElPenduloDataSet4 = new ERP_ServicioElPendulo.servicioElPenduloDataSet4();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tab_canfra = new System.Windows.Forms.TabPage();
            this.tab_Artur = new System.Windows.Forms.TabPage();
            this.tab_ElGuero = new System.Windows.Forms.TabPage();
            this.tab_Gil = new System.Windows.Forms.TabPage();
            this.tab_Aguila = new System.Windows.Forms.TabPage();
            this.tab_COMEX = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.laBallenaTableAdapter = new ERP_ServicioElPendulo.servicioElPenduloDataSet4TableAdapters.LaBallenaTableAdapter();
            this.costoTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tablaCotizaciones = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioElPenduloDataSet5 = new ERP_ServicioElPendulo.servicioElPenduloDataSet5();
            this.cotizacionesTableAdapter = new ERP_ServicioElPendulo.servicioElPenduloDataSet5TableAdapters.CotizacionesTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.sumaArticulos = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Volver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_PDF = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tab_Proveedores.SuspendLayout();
            this.fechaCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLaBallena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laBallenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Proveedores
            // 
            this.tab_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tab_Proveedores.Controls.Add(this.fechaCotizacion);
            this.tab_Proveedores.Controls.Add(this.tab_canfra);
            this.tab_Proveedores.Controls.Add(this.tab_Artur);
            this.tab_Proveedores.Controls.Add(this.tab_ElGuero);
            this.tab_Proveedores.Controls.Add(this.tab_Gil);
            this.tab_Proveedores.Controls.Add(this.tab_Aguila);
            this.tab_Proveedores.Controls.Add(this.tab_COMEX);
            this.tab_Proveedores.Controls.Add(this.tabPage1);
            this.tab_Proveedores.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Proveedores.Location = new System.Drawing.Point(24, 86);
            this.tab_Proveedores.Name = "tab_Proveedores";
            this.tab_Proveedores.SelectedIndex = 0;
            this.tab_Proveedores.Size = new System.Drawing.Size(493, 391);
            this.tab_Proveedores.TabIndex = 4;
            // 
            // fechaCotizacion
            // 
            this.fechaCotizacion.BackColor = System.Drawing.Color.Silver;
            this.fechaCotizacion.Controls.Add(this.cantidadItems);
            this.fechaCotizacion.Controls.Add(this.lbl_Producto);
            this.fechaCotizacion.Controls.Add(this.fecha_Cotizacion);
            this.fechaCotizacion.Controls.Add(this.btn_Add);
            this.fechaCotizacion.Controls.Add(this.precioItem);
            this.fechaCotizacion.Controls.Add(this.label8);
            this.fechaCotizacion.Controls.Add(this.label7);
            this.fechaCotizacion.Controls.Add(this.btn_gest_Ballena);
            this.fechaCotizacion.Controls.Add(this.totalProv);
            this.fechaCotizacion.Controls.Add(this.label6);
            this.fechaCotizacion.Controls.Add(this.label5);
            this.fechaCotizacion.Controls.Add(this.label4);
            this.fechaCotizacion.Controls.Add(this.label3);
            this.fechaCotizacion.Controls.Add(this.nameP);
            this.fechaCotizacion.Controls.Add(this.tablaLaBallena);
            this.fechaCotizacion.Controls.Add(this.pictureBox2);
            this.fechaCotizacion.Location = new System.Drawing.Point(4, 26);
            this.fechaCotizacion.Name = "fechaCotizacion";
            this.fechaCotizacion.Padding = new System.Windows.Forms.Padding(3);
            this.fechaCotizacion.Size = new System.Drawing.Size(485, 361);
            this.fechaCotizacion.TabIndex = 0;
            this.fechaCotizacion.Text = "LaBallena";
            // 
            // cantidadItems
            // 
            this.cantidadItems.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadItems.Location = new System.Drawing.Point(17, 289);
            this.cantidadItems.Name = "cantidadItems";
            this.cantidadItems.Size = new System.Drawing.Size(93, 22);
            this.cantidadItems.TabIndex = 16;
            this.cantidadItems.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(14, 231);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(85, 17);
            this.lbl_Producto.TabIndex = 15;
            this.lbl_Producto.Text = "ValorProducto";
            // 
            // fecha_Cotizacion
            // 
            this.fecha_Cotizacion.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.fecha_Cotizacion.Enabled = false;
            this.fecha_Cotizacion.Location = new System.Drawing.Point(279, 6);
            this.fecha_Cotizacion.Name = "fecha_Cotizacion";
            this.fecha_Cotizacion.Size = new System.Drawing.Size(197, 25);
            this.fecha_Cotizacion.TabIndex = 14;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(363, 208);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(113, 41);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Agregar a Tabla";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // precioItem
            // 
            this.precioItem.AutoSize = true;
            this.precioItem.Location = new System.Drawing.Point(70, 340);
            this.precioItem.Name = "precioItem";
            this.precioItem.Size = new System.Drawing.Size(15, 17);
            this.precioItem.TabIndex = 12;
            this.precioItem.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "MXN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(8, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Costo del Item";
            // 
            // btn_gest_Ballena
            // 
            this.btn_gest_Ballena.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gest_Ballena.Location = new System.Drawing.Point(363, 255);
            this.btn_gest_Ballena.Name = "btn_gest_Ballena";
            this.btn_gest_Ballena.Size = new System.Drawing.Size(113, 41);
            this.btn_gest_Ballena.TabIndex = 9;
            this.btn_gest_Ballena.Text = "Gestionar Proveedor";
            this.btn_gest_Ballena.UseVisualStyleBackColor = true;
            this.btn_gest_Ballena.Visible = false;
            // 
            // totalProv
            // 
            this.totalProv.AutoSize = true;
            this.totalProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.totalProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProv.Location = new System.Drawing.Point(225, 332);
            this.totalProv.Name = "totalProv";
            this.totalProv.Size = new System.Drawing.Size(14, 13);
            this.totalProv.TabIndex = 6;
            this.totalProv.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(167, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "MXN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total de este Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(14, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccion";
            // 
            // nameP
            // 
            this.nameP.AutoSize = true;
            this.nameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameP.Location = new System.Drawing.Point(8, 12);
            this.nameP.Name = "nameP";
            this.nameP.Size = new System.Drawing.Size(82, 16);
            this.nameP.TabIndex = 1;
            this.nameP.Text = "La Ballena";
            // 
            // tablaLaBallena
            // 
            this.tablaLaBallena.AllowUserToAddRows = false;
            this.tablaLaBallena.AllowUserToDeleteRows = false;
            this.tablaLaBallena.AllowUserToOrderColumns = true;
            this.tablaLaBallena.AutoGenerateColumns = false;
            this.tablaLaBallena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLaBallena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveArticuloDataGridViewTextBoxColumn,
            this.nombreItemDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.tablaLaBallena.DataSource = this.laBallenaBindingSource;
            this.tablaLaBallena.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tablaLaBallena.Location = new System.Drawing.Point(5, 34);
            this.tablaLaBallena.MultiSelect = false;
            this.tablaLaBallena.Name = "tablaLaBallena";
            this.tablaLaBallena.ReadOnly = true;
            this.tablaLaBallena.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tablaLaBallena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaLaBallena.Size = new System.Drawing.Size(471, 168);
            this.tablaLaBallena.TabIndex = 0;
            this.tablaLaBallena.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaLaBallena_CellContentClick);
            // 
            // claveArticuloDataGridViewTextBoxColumn
            // 
            this.claveArticuloDataGridViewTextBoxColumn.DataPropertyName = "ClaveArticulo";
            this.claveArticuloDataGridViewTextBoxColumn.HeaderText = "ClaveArticulo";
            this.claveArticuloDataGridViewTextBoxColumn.Name = "claveArticuloDataGridViewTextBoxColumn";
            this.claveArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreItemDataGridViewTextBoxColumn
            // 
            this.nombreItemDataGridViewTextBoxColumn.DataPropertyName = "NombreItem";
            this.nombreItemDataGridViewTextBoxColumn.HeaderText = "NombreItem";
            this.nombreItemDataGridViewTextBoxColumn.Name = "nombreItemDataGridViewTextBoxColumn";
            this.nombreItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreItemDataGridViewTextBoxColumn.Width = 250;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laBallenaBindingSource
            // 
            this.laBallenaBindingSource.DataMember = "LaBallena";
            this.laBallenaBindingSource.DataSource = this.servicioElPenduloDataSet4;
            // 
            // servicioElPenduloDataSet4
            // 
            this.servicioElPenduloDataSet4.DataSetName = "servicioElPenduloDataSet4";
            this.servicioElPenduloDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox2.Location = new System.Drawing.Point(160, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 64);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // tab_canfra
            // 
            this.tab_canfra.BackColor = System.Drawing.Color.Silver;
            this.tab_canfra.Location = new System.Drawing.Point(4, 26);
            this.tab_canfra.Name = "tab_canfra";
            this.tab_canfra.Padding = new System.Windows.Forms.Padding(3);
            this.tab_canfra.Size = new System.Drawing.Size(485, 361);
            this.tab_canfra.TabIndex = 1;
            this.tab_canfra.Text = "Canfra Electro Central";
            // 
            // tab_Artur
            // 
            this.tab_Artur.BackColor = System.Drawing.Color.Silver;
            this.tab_Artur.Location = new System.Drawing.Point(4, 26);
            this.tab_Artur.Name = "tab_Artur";
            this.tab_Artur.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Artur.Size = new System.Drawing.Size(485, 361);
            this.tab_Artur.TabIndex = 2;
            this.tab_Artur.Text = "Refrigeración Artur";
            // 
            // tab_ElGuero
            // 
            this.tab_ElGuero.BackColor = System.Drawing.Color.Silver;
            this.tab_ElGuero.Location = new System.Drawing.Point(4, 26);
            this.tab_ElGuero.Name = "tab_ElGuero";
            this.tab_ElGuero.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ElGuero.Size = new System.Drawing.Size(485, 361);
            this.tab_ElGuero.TabIndex = 3;
            this.tab_ElGuero.Text = "Materiales El Guero";
            // 
            // tab_Gil
            // 
            this.tab_Gil.BackColor = System.Drawing.Color.Silver;
            this.tab_Gil.Location = new System.Drawing.Point(4, 26);
            this.tab_Gil.Name = "tab_Gil";
            this.tab_Gil.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Gil.Size = new System.Drawing.Size(485, 361);
            this.tab_Gil.TabIndex = 4;
            this.tab_Gil.Text = "Tapicería Gilberto Cruz Mora";
            // 
            // tab_Aguila
            // 
            this.tab_Aguila.BackColor = System.Drawing.Color.Silver;
            this.tab_Aguila.Location = new System.Drawing.Point(4, 26);
            this.tab_Aguila.Name = "tab_Aguila";
            this.tab_Aguila.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Aguila.Size = new System.Drawing.Size(485, 361);
            this.tab_Aguila.TabIndex = 5;
            this.tab_Aguila.Text = "Ferreteria y Tlapalería El Aguila";
            // 
            // tab_COMEX
            // 
            this.tab_COMEX.Location = new System.Drawing.Point(4, 26);
            this.tab_COMEX.Name = "tab_COMEX";
            this.tab_COMEX.Padding = new System.Windows.Forms.Padding(3);
            this.tab_COMEX.Size = new System.Drawing.Size(485, 361);
            this.tab_COMEX.TabIndex = 6;
            this.tab_COMEX.Text = "COMEX";
            this.tab_COMEX.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 361);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Bodega de Pisos Division del Norte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // laBallenaTableAdapter
            // 
            this.laBallenaTableAdapter.ClearBeforeFill = true;
            // 
            // costoTotal
            // 
            this.costoTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.costoTotal.AutoSize = true;
            this.costoTotal.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoTotal.Location = new System.Drawing.Point(753, 425);
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.Size = new System.Drawing.Size(22, 25);
            this.costoTotal.TabIndex = 17;
            this.costoTotal.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(630, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total: MXN";
            // 
            // tablaCotizaciones
            // 
            this.tablaCotizaciones.AllowUserToAddRows = false;
            this.tablaCotizaciones.AllowUserToDeleteRows = false;
            this.tablaCotizaciones.AllowUserToOrderColumns = true;
            this.tablaCotizaciones.AllowUserToResizeRows = false;
            this.tablaCotizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaCotizaciones.AutoGenerateColumns = false;
            this.tablaCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCotizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.articuloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.costoUnitarioDataGridViewTextBoxColumn,
            this.costoTotalDataGridViewTextBoxColumn});
            this.tablaCotizaciones.DataSource = this.cotizacionesBindingSource;
            this.tablaCotizaciones.Location = new System.Drawing.Point(580, 113);
            this.tablaCotizaciones.Name = "tablaCotizaciones";
            this.tablaCotizaciones.ReadOnly = true;
            this.tablaCotizaciones.Size = new System.Drawing.Size(591, 299);
            this.tablaCotizaciones.TabIndex = 19;
            this.tablaCotizaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCotizaciones_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articuloDataGridViewTextBoxColumn
            // 
            this.articuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo";
            this.articuloDataGridViewTextBoxColumn.HeaderText = "Articulo";
            this.articuloDataGridViewTextBoxColumn.Name = "articuloDataGridViewTextBoxColumn";
            this.articuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoUnitarioDataGridViewTextBoxColumn
            // 
            this.costoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "CostoUnitario";
            this.costoUnitarioDataGridViewTextBoxColumn.HeaderText = "CostoUnitario";
            this.costoUnitarioDataGridViewTextBoxColumn.Name = "costoUnitarioDataGridViewTextBoxColumn";
            this.costoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoTotalDataGridViewTextBoxColumn
            // 
            this.costoTotalDataGridViewTextBoxColumn.DataPropertyName = "CostoTotal";
            this.costoTotalDataGridViewTextBoxColumn.HeaderText = "CostoTotal";
            this.costoTotalDataGridViewTextBoxColumn.Name = "costoTotalDataGridViewTextBoxColumn";
            this.costoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cotizacionesBindingSource
            // 
            this.cotizacionesBindingSource.DataMember = "Cotizaciones";
            this.cotizacionesBindingSource.DataSource = this.servicioElPenduloDataSet5;
            // 
            // servicioElPenduloDataSet5
            // 
            this.servicioElPenduloDataSet5.DataSetName = "servicioElPenduloDataSet5";
            this.servicioElPenduloDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cotizacionesTableAdapter
            // 
            this.cotizacionesTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(630, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "de";
            // 
            // sumaArticulos
            // 
            this.sumaArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sumaArticulos.AutoSize = true;
            this.sumaArticulos.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumaArticulos.Location = new System.Drawing.Point(668, 466);
            this.sumaArticulos.Name = "sumaArticulos";
            this.sumaArticulos.Size = new System.Drawing.Size(22, 25);
            this.sumaArticulos.TabIndex = 22;
            this.sumaArticulos.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(691, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Articulos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(576, 86);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tabla de Cotizaciones";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Volver.Depth = 0;
            this.btn_Volver.Location = new System.Drawing.Point(887, 452);
            this.btn_Volver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Primary = true;
            this.btn_Volver.Size = new System.Drawing.Size(99, 39);
            this.btn_Volver.TabIndex = 25;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_PDF
            // 
            this.btn_PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PDF.Depth = 0;
            this.btn_PDF.Location = new System.Drawing.Point(1007, 452);
            this.btn_PDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Primary = true;
            this.btn_PDF.Size = new System.Drawing.Size(164, 39);
            this.btn_PDF.TabIndex = 26;
            this.btn_PDF.Text = "Guardar y Generar PDF";
            this.btn_PDF.UseVisualStyleBackColor = true;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 515);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sumaArticulos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tablaCotizaciones);
            this.Controls.Add(this.costoTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tab_Proveedores);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.tab_Proveedores.ResumeLayout(false);
            this.fechaCotizacion.ResumeLayout(false);
            this.fechaCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLaBallena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laBallenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioElPenduloDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tab_Proveedores;
        private System.Windows.Forms.TabPage fechaCotizacion;
        private System.Windows.Forms.TabPage tab_canfra;
        private System.Windows.Forms.TabPage tab_Artur;
        private System.Windows.Forms.TabPage tab_ElGuero;
        private System.Windows.Forms.TabPage tab_Gil;
        private System.Windows.Forms.TabPage tab_Aguila;
        private System.Windows.Forms.TabPage tab_COMEX;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tablaLaBallena;
        private servicioElPenduloDataSet4 servicioElPenduloDataSet4;
        private System.Windows.Forms.BindingSource laBallenaBindingSource;
        private servicioElPenduloDataSet4TableAdapters.LaBallenaTableAdapter laBallenaTableAdapter;
        private System.Windows.Forms.Label totalProv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameP;
        private System.Windows.Forms.Label precioItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_gest_Ballena;
        private System.Windows.Forms.DateTimePicker fecha_Cotizacion;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label costoTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.NumericUpDown cantidadItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView tablaCotizaciones;
        private servicioElPenduloDataSet5 servicioElPenduloDataSet5;
        private System.Windows.Forms.BindingSource cotizacionesBindingSource;
        private servicioElPenduloDataSet5TableAdapters.CotizacionesTableAdapter cotizacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sumaArticulos;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Volver;
        private MaterialSkin.Controls.MaterialRaisedButton btn_PDF;
    }
}