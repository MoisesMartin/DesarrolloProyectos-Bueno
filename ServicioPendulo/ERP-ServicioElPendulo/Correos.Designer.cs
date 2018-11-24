namespace ERP_ServicioElPendulo
{
    partial class Correos
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_CuerpoMensaje = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_EmailOrigen = new System.Windows.Forms.TextBox();
            this.text_EmailDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_Asunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_CancelarCorreo = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enviar Correos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // text_CuerpoMensaje
            // 
            this.text_CuerpoMensaje.Location = new System.Drawing.Point(16, 203);
            this.text_CuerpoMensaje.Name = "text_CuerpoMensaje";
            this.text_CuerpoMensaje.Size = new System.Drawing.Size(440, 190);
            this.text_CuerpoMensaje.TabIndex = 9;
            this.text_CuerpoMensaje.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email de Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email de Destino";
            // 
            // text_EmailOrigen
            // 
            this.text_EmailOrigen.Location = new System.Drawing.Point(16, 88);
            this.text_EmailOrigen.Name = "text_EmailOrigen";
            this.text_EmailOrigen.Size = new System.Drawing.Size(185, 20);
            this.text_EmailOrigen.TabIndex = 12;
            // 
            // text_EmailDestino
            // 
            this.text_EmailDestino.Location = new System.Drawing.Point(261, 88);
            this.text_EmailDestino.Name = "text_EmailDestino";
            this.text_EmailDestino.Size = new System.Drawing.Size(191, 20);
            this.text_EmailDestino.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Asunto:";
            // 
            // text_Asunto
            // 
            this.text_Asunto.Location = new System.Drawing.Point(16, 149);
            this.text_Asunto.Multiline = true;
            this.text_Asunto.Name = "text_Asunto";
            this.text_Asunto.Size = new System.Drawing.Size(436, 20);
            this.text_Asunto.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cuerpo del Mensaje";
            // 
            // btn_CancelarCorreo
            // 
            this.btn_CancelarCorreo.Location = new System.Drawing.Point(252, 416);
            this.btn_CancelarCorreo.Name = "btn_CancelarCorreo";
            this.btn_CancelarCorreo.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelarCorreo.TabIndex = 17;
            this.btn_CancelarCorreo.Text = "Cancelar";
            this.btn_CancelarCorreo.UseVisualStyleBackColor = true;
            this.btn_CancelarCorreo.Click += new System.EventHandler(this.btn_CancelarCorreo_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(381, 416);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_Enviar.TabIndex = 18;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "->";
            // 
            // Correos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.btn_CancelarCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_Asunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_EmailDestino);
            this.Controls.Add(this.text_EmailOrigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_CuerpoMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Correos";
            this.Text = "Correos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox text_CuerpoMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_EmailOrigen;
        private System.Windows.Forms.TextBox text_EmailDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_Asunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_CancelarCorreo;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Label label6;
    }
}