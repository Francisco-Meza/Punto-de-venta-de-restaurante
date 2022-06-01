namespace GUI
{
    partial class FrmAddPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPersonal));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new Guna.UI.WinForms.GunaButton();
            this.lblFechaNac = new Guna.UI.WinForms.GunaLabel();
            this.TxtCorreo = new Guna.UI.WinForms.GunaTextBox();
            this.lblCorreoP = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.TxtApelMat = new Guna.UI.WinForms.GunaTextBox();
            this.TxtContra = new Guna.UI.WinForms.GunaTextBox();
            this.lblContraP = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.TxtApelPat = new Guna.UI.WinForms.GunaTextBox();
            this.lblPuesto = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.TxtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTelefonoPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.lblTelefonoPersonal = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.DtpFecha = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtConfirContra = new Guna.UI.WinForms.GunaTextBox();
            this.cmbPuesto = new Guna.UI.WinForms.GunaComboBox();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(40, 6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(154, 21);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Datos del personal";
            // 
            // BtnCerrarHijo
            // 
            this.BtnCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarHijo.FlatAppearance.BorderSize = 0;
            this.BtnCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.BtnCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrarHijo.IconSize = 40;
            this.BtnCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrarHijo.Location = new System.Drawing.Point(699, 6);
            this.BtnCerrarHijo.Name = "BtnCerrarHijo";
            this.BtnCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.BtnCerrarHijo.TabIndex = 6;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
            this.BtnCerrarHijo.Click += new System.EventHandler(this.BtnCerrarHijo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.AnimationHoverSpeed = 0.07F;
            this.BtnGuardar.AnimationSpeed = 0.03F;
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.BtnGuardar.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGuardar.Location = new System.Drawing.Point(316, 488);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardar.OnHoverImage = null;
            this.BtnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardar.Radius = 20;
            this.BtnGuardar.Size = new System.Drawing.Size(160, 42);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(37, 154);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(165, 20);
            this.lblFechaNac.TabIndex = 3;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.TxtCorreo.BaseColor = System.Drawing.Color.White;
            this.TxtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCorreo.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(226, 245);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.PasswordChar = '\0';
            this.TxtCorreo.Radius = 10;
            this.TxtCorreo.Size = new System.Drawing.Size(309, 30);
            this.TxtCorreo.TabIndex = 11;
            // 
            // lblCorreoP
            // 
            this.lblCorreoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreoP.AutoSize = true;
            this.lblCorreoP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoP.Location = new System.Drawing.Point(95, 245);
            this.lblCorreoP.Name = "lblCorreoP";
            this.lblCorreoP.Size = new System.Drawing.Size(61, 20);
            this.lblCorreoP.TabIndex = 4;
            this.lblCorreoP.Text = "Correo";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(67, 106);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(135, 20);
            this.gunaLabel5.TabIndex = 2;
            this.gunaLabel5.Text = "Apellido materno";
            // 
            // TxtApelMat
            // 
            this.TxtApelMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApelMat.BackColor = System.Drawing.Color.Transparent;
            this.TxtApelMat.BaseColor = System.Drawing.Color.White;
            this.TxtApelMat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtApelMat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApelMat.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtApelMat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtApelMat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtApelMat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApelMat.Location = new System.Drawing.Point(226, 106);
            this.TxtApelMat.Name = "TxtApelMat";
            this.TxtApelMat.PasswordChar = '\0';
            this.TxtApelMat.Radius = 10;
            this.TxtApelMat.Size = new System.Drawing.Size(309, 30);
            this.TxtApelMat.TabIndex = 9;
            // 
            // TxtContra
            // 
            this.TxtContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtContra.BackColor = System.Drawing.Color.Transparent;
            this.TxtContra.BaseColor = System.Drawing.Color.White;
            this.TxtContra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtContra.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtContra.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtContra.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.Location = new System.Drawing.Point(226, 297);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.PasswordChar = '\0';
            this.TxtContra.Radius = 10;
            this.TxtContra.Size = new System.Drawing.Size(309, 30);
            this.TxtContra.TabIndex = 12;
            // 
            // lblContraP
            // 
            this.lblContraP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraP.AutoSize = true;
            this.lblContraP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraP.Location = new System.Drawing.Point(78, 297);
            this.lblContraP.Name = "lblContraP";
            this.lblContraP.Size = new System.Drawing.Size(95, 20);
            this.lblContraP.TabIndex = 5;
            this.lblContraP.Text = "Contraseña";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(67, 61);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(132, 20);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Apellido paterno";
            // 
            // TxtApelPat
            // 
            this.TxtApelPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApelPat.BackColor = System.Drawing.Color.Transparent;
            this.TxtApelPat.BaseColor = System.Drawing.Color.White;
            this.TxtApelPat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtApelPat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApelPat.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtApelPat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtApelPat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtApelPat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApelPat.Location = new System.Drawing.Point(226, 61);
            this.TxtApelPat.Name = "TxtApelPat";
            this.TxtApelPat.PasswordChar = '\0';
            this.TxtApelPat.Radius = 10;
            this.TxtApelPat.Size = new System.Drawing.Size(309, 30);
            this.TxtApelPat.TabIndex = 8;
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(85, 375);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(58, 20);
            this.lblPuesto.TabIndex = 6;
            this.lblPuesto.Text = "Puesto";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(95, 13);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(68, 20);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombre.BaseColor = System.Drawing.Color.White;
            this.TxtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(226, 13);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.Radius = 10;
            this.TxtNombre.Size = new System.Drawing.Size(309, 30);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtTelefonoPersonal
            // 
            this.TxtTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefonoPersonal.BackColor = System.Drawing.Color.Transparent;
            this.TxtTelefonoPersonal.BaseColor = System.Drawing.Color.White;
            this.TxtTelefonoPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtTelefonoPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTelefonoPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTelefonoPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtTelefonoPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTelefonoPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoPersonal.Location = new System.Drawing.Point(226, 200);
            this.TxtTelefonoPersonal.Name = "TxtTelefonoPersonal";
            this.TxtTelefonoPersonal.PasswordChar = '\0';
            this.TxtTelefonoPersonal.Radius = 10;
            this.TxtTelefonoPersonal.Size = new System.Drawing.Size(309, 30);
            this.TxtTelefonoPersonal.TabIndex = 14;
            // 
            // lblTelefonoPersonal
            // 
            this.lblTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoPersonal.AutoSize = true;
            this.lblTelefonoPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoPersonal.Location = new System.Drawing.Point(85, 200);
            this.lblTelefonoPersonal.Name = "lblTelefonoPersonal";
            this.lblTelefonoPersonal.Size = new System.Drawing.Size(71, 20);
            this.lblTelefonoPersonal.TabIndex = 15;
            this.lblTelefonoPersonal.Text = "Teléfono";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox2.BorderSize = 1;
            this.gunaGroupBox2.Controls.Add(this.DtpFecha);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox2.Controls.Add(this.txtConfirContra);
            this.gunaGroupBox2.Controls.Add(this.cmbPuesto);
            this.gunaGroupBox2.Controls.Add(this.lblTelefonoPersonal);
            this.gunaGroupBox2.Controls.Add(this.TxtTelefonoPersonal);
            this.gunaGroupBox2.Controls.Add(this.TxtNombre);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox2.Controls.Add(this.lblPuesto);
            this.gunaGroupBox2.Controls.Add(this.TxtApelPat);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox2.Controls.Add(this.lblContraP);
            this.gunaGroupBox2.Controls.Add(this.TxtContra);
            this.gunaGroupBox2.Controls.Add(this.TxtApelMat);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox2.Controls.Add(this.lblCorreoP);
            this.gunaGroupBox2.Controls.Add(this.TxtCorreo);
            this.gunaGroupBox2.Controls.Add(this.lblFechaNac);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Empty;
            this.gunaGroupBox2.Location = new System.Drawing.Point(90, 37);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(581, 437);
            this.gunaGroupBox2.TabIndex = 12;
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // DtpFecha
            // 
            this.DtpFecha.BaseColor = System.Drawing.Color.White;
            this.DtpFecha.BorderColor = System.Drawing.Color.Silver;
            this.DtpFecha.CustomFormat = null;
            this.DtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtpFecha.ForeColor = System.Drawing.Color.Black;
            this.DtpFecha.Location = new System.Drawing.Point(226, 154);
            this.DtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.OnHoverBaseColor = System.Drawing.Color.White;
            this.DtpFecha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.DtpFecha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.DtpFecha.OnPressedColor = System.Drawing.Color.Black;
            this.DtpFecha.Size = new System.Drawing.Size(309, 30);
            this.DtpFecha.TabIndex = 19;
            this.DtpFecha.Text = "martes, 31 de mayo de 2022";
            this.DtpFecha.Value = new System.DateTime(2022, 5, 31, 9, 42, 29, 173);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(48, 333);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(171, 20);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Confirmar Contraseña";
            // 
            // txtConfirContra
            // 
            this.txtConfirContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirContra.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirContra.BaseColor = System.Drawing.Color.White;
            this.txtConfirContra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtConfirContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirContra.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConfirContra.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtConfirContra.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirContra.Location = new System.Drawing.Point(226, 333);
            this.txtConfirContra.Name = "txtConfirContra";
            this.txtConfirContra.PasswordChar = '\0';
            this.txtConfirContra.Radius = 10;
            this.txtConfirContra.Size = new System.Drawing.Size(309, 30);
            this.txtConfirContra.TabIndex = 18;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.Color.Transparent;
            this.cmbPuesto.BaseColor = System.Drawing.Color.White;
            this.cmbPuesto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmbPuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPuesto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPuesto.ForeColor = System.Drawing.Color.Black;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(226, 375);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.cmbPuesto.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPuesto.Radius = 10;
            this.cmbPuesto.Size = new System.Drawing.Size(309, 26);
            this.cmbPuesto.TabIndex = 16;
            // 
            // FrmAddPersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.BtnCerrarHijo);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddPersonal";
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaLabel lblFechaNac;
        private Guna.UI.WinForms.GunaTextBox TxtCorreo;
        private Guna.UI.WinForms.GunaLabel lblCorreoP;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox TxtApelMat;
        private Guna.UI.WinForms.GunaTextBox TxtContra;
        private Guna.UI.WinForms.GunaLabel lblContraP;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox TxtApelPat;
        private Guna.UI.WinForms.GunaLabel lblPuesto;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox TxtNombre;
        private Guna.UI.WinForms.GunaTextBox TxtTelefonoPersonal;
        private Guna.UI.WinForms.GunaLabel lblTelefonoPersonal;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaComboBox cmbPuesto;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtConfirContra;
        private Guna.UI.WinForms.GunaDateTimePicker DtpFecha;
    }
}