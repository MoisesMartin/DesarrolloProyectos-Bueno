namespace ERP_ServicioElPendulo
{
    partial class form_UsrSistema
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
            this.lbl_Opc = new System.Windows.Forms.Label();
            this.txt_NombreUsr = new System.Windows.Forms.TextBox();
            this.txt_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txt_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_RepeatPass = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Registrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Cancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.check_isAdmin = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // lbl_Opc
            // 
            this.lbl_Opc.AutoSize = true;
            this.lbl_Opc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Opc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Opc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Opc.Location = new System.Drawing.Point(13, 13);
            this.lbl_Opc.Name = "lbl_Opc";
            this.lbl_Opc.Size = new System.Drawing.Size(0, 24);
            this.lbl_Opc.TabIndex = 6;
            // 
            // txt_NombreUsr
            // 
            this.txt_NombreUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NombreUsr.Location = new System.Drawing.Point(17, 105);
            this.txt_NombreUsr.Name = "txt_NombreUsr";
            this.txt_NombreUsr.Size = new System.Drawing.Size(177, 20);
            this.txt_NombreUsr.TabIndex = 9;
            // 
            // txt_ApellidoPaterno
            // 
            this.txt_ApellidoPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ApellidoPaterno.Location = new System.Drawing.Point(17, 167);
            this.txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            this.txt_ApellidoPaterno.Size = new System.Drawing.Size(177, 20);
            this.txt_ApellidoPaterno.TabIndex = 13;
            // 
            // txt_ApellidoMaterno
            // 
            this.txt_ApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ApellidoMaterno.Location = new System.Drawing.Point(17, 228);
            this.txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            this.txt_ApellidoMaterno.Size = new System.Drawing.Size(177, 20);
            this.txt_ApellidoMaterno.TabIndex = 14;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.Location = new System.Drawing.Point(238, 105);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(177, 20);
            this.txt_Password.TabIndex = 18;
            // 
            // txt_RepeatPass
            // 
            this.txt_RepeatPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RepeatPass.Location = new System.Drawing.Point(238, 167);
            this.txt_RepeatPass.Name = "txt_RepeatPass";
            this.txt_RepeatPass.PasswordChar = '*';
            this.txt_RepeatPass.Size = new System.Drawing.Size(177, 20);
            this.txt_RepeatPass.TabIndex = 19;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Nombre:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 145);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(124, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Apellido Paterno:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 206);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Apellido Materno:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(234, 84);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(90, 19);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "Contraseña:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(234, 145);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(161, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "Confirmar Contraseña:";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Registrar.Depth = 0;
            this.btn_Registrar.Location = new System.Drawing.Point(333, 276);
            this.btn_Registrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Primary = true;
            this.btn_Registrar.Size = new System.Drawing.Size(91, 34);
            this.btn_Registrar.TabIndex = 28;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.Depth = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(228, 276);
            this.btn_Cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Primary = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(86, 34);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_CancelarReg_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(156, 293);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(38, 19);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "Más";
            this.materialLabel6.Click += new System.EventHandler(this.label1_Click);
            // 
            // check_isAdmin
            // 
            this.check_isAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_isAdmin.AutoSize = true;
            this.check_isAdmin.Depth = 0;
            this.check_isAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.check_isAdmin.Location = new System.Drawing.Point(17, 263);
            this.check_isAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.check_isAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_isAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_isAdmin.Name = "check_isAdmin";
            this.check_isAdmin.Ripple = true;
            this.check_isAdmin.Size = new System.Drawing.Size(168, 30);
            this.check_isAdmin.TabIndex = 31;
            this.check_isAdmin.Text = "Usuario Administrador";
            this.check_isAdmin.UseVisualStyleBackColor = true;
            // 
            // form_UsrSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 330);
            this.Controls.Add(this.check_isAdmin);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_RepeatPass);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_ApellidoMaterno);
            this.Controls.Add(this.txt_ApellidoPaterno);
            this.Controls.Add(this.txt_NombreUsr);
            this.Controls.Add(this.lbl_Opc);
            this.Name = "form_UsrSistema";
            this.Text = "Registrar Usuario del Sistema";
            this.Load += new System.EventHandler(this.form_UsrSistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Opc;
        private System.Windows.Forms.TextBox txt_NombreUsr;
        private System.Windows.Forms.TextBox txt_ApellidoPaterno;
        private System.Windows.Forms.TextBox txt_ApellidoMaterno;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_RepeatPass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Registrar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Cancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCheckBox check_isAdmin;
    }
}