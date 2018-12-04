namespace ERP_ServicioElPendulo
{
    partial class QuejasReincidencias
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartQuejas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SerieTotal = new MaterialSkin.Controls.MaterialLabel();
            this.SerieQuejas = new MaterialSkin.Controls.MaterialLabel();
            this.SerieReincidencias = new MaterialSkin.Controls.MaterialLabel();
            this.nQuejas = new MaterialSkin.Controls.MaterialLabel();
            this.nTotalServicios = new MaterialSkin.Controls.MaterialLabel();
            this.nReincidencias = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.nExitosos = new MaterialSkin.Controls.MaterialLabel();
            this.n_NoExitosos = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.nPorcentaje = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuejas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartQuejas
            // 
            this.chartQuejas.BackColor = System.Drawing.Color.DimGray;
            this.chartQuejas.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chartQuejas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQuejas.Legends.Add(legend1);
            this.chartQuejas.Location = new System.Drawing.Point(272, 64);
            this.chartQuejas.Name = "chartQuejas";
            this.chartQuejas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartQuejas.Size = new System.Drawing.Size(744, 359);
            this.chartQuejas.TabIndex = 0;
            this.chartQuejas.Text = "Grafica de Quejas";
            // 
            // SerieTotal
            // 
            this.SerieTotal.AutoSize = true;
            this.SerieTotal.Depth = 0;
            this.SerieTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.SerieTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SerieTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SerieTotal.Location = new System.Drawing.Point(34, 46);
            this.SerieTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.SerieTotal.Name = "SerieTotal";
            this.SerieTotal.Size = new System.Drawing.Size(130, 19);
            this.SerieTotal.TabIndex = 47;
            this.SerieTotal.Text = "Total de Servicios";
            // 
            // SerieQuejas
            // 
            this.SerieQuejas.AutoSize = true;
            this.SerieQuejas.Depth = 0;
            this.SerieQuejas.Font = new System.Drawing.Font("Roboto", 11F);
            this.SerieQuejas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SerieQuejas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SerieQuejas.Location = new System.Drawing.Point(34, 132);
            this.SerieQuejas.MouseState = MaterialSkin.MouseState.HOVER;
            this.SerieQuejas.Name = "SerieQuejas";
            this.SerieQuejas.Size = new System.Drawing.Size(138, 19);
            this.SerieQuejas.TabIndex = 48;
            this.SerieQuejas.Text = "Quejas Registradas";
            // 
            // SerieReincidencias
            // 
            this.SerieReincidencias.AutoSize = true;
            this.SerieReincidencias.Depth = 0;
            this.SerieReincidencias.Font = new System.Drawing.Font("Roboto", 11F);
            this.SerieReincidencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SerieReincidencias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SerieReincidencias.Location = new System.Drawing.Point(34, 227);
            this.SerieReincidencias.MouseState = MaterialSkin.MouseState.HOVER;
            this.SerieReincidencias.Name = "SerieReincidencias";
            this.SerieReincidencias.Size = new System.Drawing.Size(102, 19);
            this.SerieReincidencias.TabIndex = 49;
            this.SerieReincidencias.Text = "Reincidencias";
            // 
            // nQuejas
            // 
            this.nQuejas.AutoSize = true;
            this.nQuejas.Depth = 0;
            this.nQuejas.Font = new System.Drawing.Font("Roboto", 11F);
            this.nQuejas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nQuejas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nQuejas.Location = new System.Drawing.Point(34, 180);
            this.nQuejas.MouseState = MaterialSkin.MouseState.HOVER;
            this.nQuejas.Name = "nQuejas";
            this.nQuejas.Size = new System.Drawing.Size(25, 19);
            this.nQuejas.TabIndex = 50;
            this.nQuejas.Text = "15";
            // 
            // nTotalServicios
            // 
            this.nTotalServicios.AutoSize = true;
            this.nTotalServicios.Depth = 0;
            this.nTotalServicios.Font = new System.Drawing.Font("Roboto", 11F);
            this.nTotalServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nTotalServicios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nTotalServicios.Location = new System.Drawing.Point(34, 88);
            this.nTotalServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.nTotalServicios.Name = "nTotalServicios";
            this.nTotalServicios.Size = new System.Drawing.Size(33, 19);
            this.nTotalServicios.TabIndex = 51;
            this.nTotalServicios.Text = "100";
            // 
            // nReincidencias
            // 
            this.nReincidencias.AutoSize = true;
            this.nReincidencias.Depth = 0;
            this.nReincidencias.Font = new System.Drawing.Font("Roboto", 11F);
            this.nReincidencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nReincidencias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nReincidencias.Location = new System.Drawing.Point(34, 268);
            this.nReincidencias.MouseState = MaterialSkin.MouseState.HOVER;
            this.nReincidencias.Name = "nReincidencias";
            this.nReincidencias.Size = new System.Drawing.Size(17, 19);
            this.nReincidencias.TabIndex = 52;
            this.nReincidencias.Text = "2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel1.Location = new System.Drawing.Point(268, 435);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(193, 19);
            this.materialLabel1.TabIndex = 53;
            this.materialLabel1.Text = "Total de Servicios Exitosos";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel2.Location = new System.Drawing.Point(512, 435);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(149, 19);
            this.materialLabel2.TabIndex = 54;
            this.materialLabel2.Text = "Servicios Pendientes";
            // 
            // nExitosos
            // 
            this.nExitosos.AutoSize = true;
            this.nExitosos.Depth = 0;
            this.nExitosos.Font = new System.Drawing.Font("Roboto", 11F);
            this.nExitosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nExitosos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nExitosos.Location = new System.Drawing.Point(268, 470);
            this.nExitosos.MouseState = MaterialSkin.MouseState.HOVER;
            this.nExitosos.Name = "nExitosos";
            this.nExitosos.Size = new System.Drawing.Size(17, 19);
            this.nExitosos.TabIndex = 55;
            this.nExitosos.Text = "0";
            // 
            // n_NoExitosos
            // 
            this.n_NoExitosos.AutoSize = true;
            this.n_NoExitosos.Depth = 0;
            this.n_NoExitosos.Font = new System.Drawing.Font("Roboto", 11F);
            this.n_NoExitosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.n_NoExitosos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.n_NoExitosos.Location = new System.Drawing.Point(512, 470);
            this.n_NoExitosos.MouseState = MaterialSkin.MouseState.HOVER;
            this.n_NoExitosos.Name = "n_NoExitosos";
            this.n_NoExitosos.Size = new System.Drawing.Size(17, 19);
            this.n_NoExitosos.TabIndex = 56;
            this.n_NoExitosos.Text = "0";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel3.Location = new System.Drawing.Point(268, 510);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(284, 19);
            this.materialLabel3.TabIndex = 57;
            this.materialLabel3.Text = "El Porcentaje de inefectividad ha sido del";
            // 
            // nPorcentaje
            // 
            this.nPorcentaje.AutoSize = true;
            this.nPorcentaje.Depth = 0;
            this.nPorcentaje.Font = new System.Drawing.Font("Roboto", 11F);
            this.nPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nPorcentaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nPorcentaje.Location = new System.Drawing.Point(578, 510);
            this.nPorcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.nPorcentaje.Name = "nPorcentaje";
            this.nPorcentaje.Size = new System.Drawing.Size(17, 19);
            this.nPorcentaje.TabIndex = 58;
            this.nPorcentaje.Text = "0";
            // 
            // QuejasReincidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1060, 554);
            this.Controls.Add(this.nPorcentaje);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.n_NoExitosos);
            this.Controls.Add(this.nExitosos);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nReincidencias);
            this.Controls.Add(this.nTotalServicios);
            this.Controls.Add(this.nQuejas);
            this.Controls.Add(this.SerieReincidencias);
            this.Controls.Add(this.SerieQuejas);
            this.Controls.Add(this.SerieTotal);
            this.Controls.Add(this.chartQuejas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuejasReincidencias";
            this.Text = "QuejasReincidencias";
            this.Load += new System.EventHandler(this.QuejasReincidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuejas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuejas;
        private MaterialSkin.Controls.MaterialLabel SerieTotal;
        private MaterialSkin.Controls.MaterialLabel SerieQuejas;
        private MaterialSkin.Controls.MaterialLabel SerieReincidencias;
        private MaterialSkin.Controls.MaterialLabel nQuejas;
        private MaterialSkin.Controls.MaterialLabel nTotalServicios;
        private MaterialSkin.Controls.MaterialLabel nReincidencias;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel nExitosos;
        private MaterialSkin.Controls.MaterialLabel n_NoExitosos;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel nPorcentaje;
    }
}