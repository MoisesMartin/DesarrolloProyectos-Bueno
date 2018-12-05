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
            this.btn_Registrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Cancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.check_isAdmin = new MaterialSkin.Controls.MaterialCheckBox();
            this.txt_NombreUsr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ApellidoPaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ApellidoMaterno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_RepeatPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            // btn_Registrar
            // 
            this.btn_Registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Registrar.Depth = 0;
            this.btn_Registrar.Location = new System.Drawing.Point(333, 239);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(228, 239);
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
            this.materialLabel6.Location = new System.Drawing.Point(43, 254);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(38, 19);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "Más";
            this.materialLabel6.Visible = false;
            this.materialLabel6.Click += new System.EventHandler(this.label1_Click);
            // 
            // check_isAdmin
            // 
            this.check_isAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_isAdmin.AutoSize = true;
            this.check_isAdmin.Depth = 0;
            this.check_isAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.check_isAdmin.Location = new System.Drawing.Point(17, 226);
            this.check_isAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.check_isAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_isAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_isAdmin.Name = "check_isAdmin";
            this.check_isAdmin.Ripple = true;
            this.check_isAdmin.Size = new System.Drawing.Size(168, 30);
            this.check_isAdmin.TabIndex = 31;
            this.check_isAdmin.Text = "Usuario Administrador";
            this.check_isAdmin.UseVisualStyleBackColor = true;
            this.check_isAdmin.Visible = false;
            // 
            // txt_NombreUsr
            // 
            this.txt_NombreUsr.Depth = 0;
            this.txt_NombreUsr.Hint = "Nombre";
            this.txt_NombreUsr.Location = new System.Drawing.Point(18, 106);
            this.txt_NombreUsr.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_NombreUsr.Name = "txt_NombreUsr";
            this.txt_NombreUsr.PasswordChar = '\0';
            this.txt_NombreUsr.SelectedText = "";
            this.txt_NombreUsr.SelectionLength = 0;
            this.txt_NombreUsr.SelectionStart = 0;
            this.txt_NombreUsr.Size = new System.Drawing.Size(177, 23);
            this.txt_NombreUsr.TabIndex = 32;
            this.txt_NombreUsr.UseSystemPasswordChar = false;
            // 
            // txt_ApellidoPaterno
            // 
            this.txt_ApellidoPaterno.Depth = 0;
            this.txt_ApellidoPaterno.Hint = "Apellido Paterno";
            this.txt_ApellidoPaterno.Location = new System.Drawing.Point(18, 145);
            this.txt_ApellidoPaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            this.txt_ApellidoPaterno.PasswordChar = '\0';
            this.txt_ApellidoPaterno.SelectedText = "";
            this.txt_ApellidoPaterno.SelectionLength = 0;
            this.txt_ApellidoPaterno.SelectionStart = 0;
            this.txt_ApellidoPaterno.Size = new System.Drawing.Size(177, 23);
            this.txt_ApellidoPaterno.TabIndex = 33;
            this.txt_ApellidoPaterno.UseSystemPasswordChar = false;
            // 
            // txt_ApellidoMaterno
            // 
            this.txt_ApellidoMaterno.Depth = 0;
            this.txt_ApellidoMaterno.Hint = "Apellido Materno";
            this.txt_ApellidoMaterno.Location = new System.Drawing.Point(18, 185);
            this.txt_ApellidoMaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            this.txt_ApellidoMaterno.PasswordChar = '\0';
            this.txt_ApellidoMaterno.SelectedText = "";
            this.txt_ApellidoMaterno.SelectionLength = 0;
            this.txt_ApellidoMaterno.SelectionStart = 0;
            this.txt_ApellidoMaterno.Size = new System.Drawing.Size(177, 23);
            this.txt_ApellidoMaterno.TabIndex = 34;
            this.txt_ApellidoMaterno.UseSystemPasswordChar = false;
            // 
            // txt_Password
            // 
            this.txt_Password.Depth = 0;
            this.txt_Password.Hint = "Contraseña";
            this.txt_Password.Location = new System.Drawing.Point(238, 106);
            this.txt_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.Size = new System.Drawing.Size(177, 23);
            this.txt_Password.TabIndex = 35;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_RepeatPass
            // 
            this.txt_RepeatPass.Depth = 0;
            this.txt_RepeatPass.Hint = "Confirmar Contraseña";
            this.txt_RepeatPass.Location = new System.Drawing.Point(238, 145);
            this.txt_RepeatPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_RepeatPass.Name = "txt_RepeatPass";
            this.txt_RepeatPass.PasswordChar = '\0';
            this.txt_RepeatPass.SelectedText = "";
            this.txt_RepeatPass.SelectionLength = 0;
            this.txt_RepeatPass.SelectionStart = 0;
            this.txt_RepeatPass.Size = new System.Drawing.Size(177, 23);
            this.txt_RepeatPass.TabIndex = 36;
            this.txt_RepeatPass.UseSystemPasswordChar = true;
            // 
            // form_UsrSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 293);
            this.Controls.Add(this.txt_RepeatPass);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_ApellidoMaterno);
            this.Controls.Add(this.txt_ApellidoPaterno);
            this.Controls.Add(this.txt_NombreUsr);
            this.Controls.Add(this.check_isAdmin);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.lbl_Opc);
            this.Name = "form_UsrSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario del Sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_UsrSistema_FormClosed);
            this.Load += new System.EventHandler(this.form_UsrSistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Opc;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Registrar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Cancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCheckBox check_isAdmin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_NombreUsr;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ApellidoPaterno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ApellidoMaterno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_RepeatPass;
    }
}