namespace GUI
{
    partial class FrmPerfilPersonal
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
            this.NomPD = new Guna.UI.WinForms.GunaLabel();
            this.LblApellidoPD = new Guna.UI.WinForms.GunaLabel();
            this.LblApellidoMD = new Guna.UI.WinForms.GunaLabel();
            this.LblTelefonoD = new Guna.UI.WinForms.GunaLabel();
            this.LblCorreoD = new Guna.UI.WinForms.GunaLabel();
            this.LblContraD = new Guna.UI.WinForms.GunaLabel();
            this.LblFechaND = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.LblPuestoD = new Guna.UI.WinForms.GunaLabel();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomPD
            // 
            this.NomPD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NomPD.AutoSize = true;
            this.NomPD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomPD.Location = new System.Drawing.Point(32, 28);
            this.NomPD.Name = "NomPD";
            this.NomPD.Size = new System.Drawing.Size(68, 20);
            this.NomPD.TabIndex = 0;
            this.NomPD.Text = "Nombre";
            // 
            // LblApellidoPD
            // 
            this.LblApellidoPD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblApellidoPD.AutoSize = true;
            this.LblApellidoPD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoPD.Location = new System.Drawing.Point(32, 72);
            this.LblApellidoPD.Name = "LblApellidoPD";
            this.LblApellidoPD.Size = new System.Drawing.Size(131, 20);
            this.LblApellidoPD.TabIndex = 1;
            this.LblApellidoPD.Text = "Apellido Paterno";
            // 
            // LblApellidoMD
            // 
            this.LblApellidoMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblApellidoMD.AutoSize = true;
            this.LblApellidoMD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoMD.Location = new System.Drawing.Point(32, 126);
            this.LblApellidoMD.Name = "LblApellidoMD";
            this.LblApellidoMD.Size = new System.Drawing.Size(137, 20);
            this.LblApellidoMD.TabIndex = 2;
            this.LblApellidoMD.Text = "Apellido Materno";
            // 
            // LblTelefonoD
            // 
            this.LblTelefonoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTelefonoD.AutoSize = true;
            this.LblTelefonoD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefonoD.Location = new System.Drawing.Point(42, 231);
            this.LblTelefonoD.Name = "LblTelefonoD";
            this.LblTelefonoD.Size = new System.Drawing.Size(71, 20);
            this.LblTelefonoD.TabIndex = 3;
            this.LblTelefonoD.Text = "Teléfono";
            // 
            // LblCorreoD
            // 
            this.LblCorreoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCorreoD.AutoSize = true;
            this.LblCorreoD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreoD.Location = new System.Drawing.Point(42, 282);
            this.LblCorreoD.Name = "LblCorreoD";
            this.LblCorreoD.Size = new System.Drawing.Size(61, 20);
            this.LblCorreoD.TabIndex = 4;
            this.LblCorreoD.Text = "Correo";
            // 
            // LblContraD
            // 
            this.LblContraD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContraD.AutoSize = true;
            this.LblContraD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraD.Location = new System.Drawing.Point(42, 329);
            this.LblContraD.Name = "LblContraD";
            this.LblContraD.Size = new System.Drawing.Size(95, 20);
            this.LblContraD.TabIndex = 5;
            this.LblContraD.Text = "Contraseña";
            // 
            // LblFechaND
            // 
            this.LblFechaND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFechaND.AutoSize = true;
            this.LblFechaND.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaND.Location = new System.Drawing.Point(32, 181);
            this.LblFechaND.Name = "LblFechaND";
            this.LblFechaND.Size = new System.Drawing.Size(167, 20);
            this.LblFechaND.TabIndex = 6;
            this.LblFechaND.Text = "Fecha de Nacimiento";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.LblPuestoD);
            this.gunaGroupBox1.Controls.Add(this.LblApellidoMD);
            this.gunaGroupBox1.Controls.Add(this.LblFechaND);
            this.gunaGroupBox1.Controls.Add(this.NomPD);
            this.gunaGroupBox1.Controls.Add(this.LblContraD);
            this.gunaGroupBox1.Controls.Add(this.LblApellidoPD);
            this.gunaGroupBox1.Controls.Add(this.LblCorreoD);
            this.gunaGroupBox1.Controls.Add(this.LblTelefonoD);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(110, 55);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(522, 428);
            this.gunaGroupBox1.TabIndex = 7;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // LblPuestoD
            // 
            this.LblPuestoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPuestoD.AutoSize = true;
            this.LblPuestoD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuestoD.Location = new System.Drawing.Point(42, 372);
            this.LblPuestoD.Name = "LblPuestoD";
            this.LblPuestoD.Size = new System.Drawing.Size(58, 20);
            this.LblPuestoD.TabIndex = 7;
            this.LblPuestoD.Text = "Puesto";
            // 
            // BtnCerrarHijo
            // 
            this.BtnCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarHijo.FlatAppearance.BorderSize = 0;
            this.BtnCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.BtnCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrarHijo.IconSize = 38;
            this.BtnCerrarHijo.Location = new System.Drawing.Point(720, 1);
            this.BtnCerrarHijo.Name = "BtnCerrarHijo";
            this.BtnCerrarHijo.Size = new System.Drawing.Size(36, 39);
            this.BtnCerrarHijo.TabIndex = 8;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
            this.BtnCerrarHijo.Click += new System.EventHandler(this.BtnCerrarHijo_Click);
            // 
            // FrmPerfilPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.BtnCerrarHijo);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPerfilPersonal";
            this.Text = "FrmPerfilPersonal";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel NomPD;
        private Guna.UI.WinForms.GunaLabel LblApellidoPD;
        private Guna.UI.WinForms.GunaLabel LblApellidoMD;
        private Guna.UI.WinForms.GunaLabel LblTelefonoD;
        private Guna.UI.WinForms.GunaLabel LblCorreoD;
        private Guna.UI.WinForms.GunaLabel LblContraD;
        private Guna.UI.WinForms.GunaLabel LblFechaND;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel LblPuestoD;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
    }
}