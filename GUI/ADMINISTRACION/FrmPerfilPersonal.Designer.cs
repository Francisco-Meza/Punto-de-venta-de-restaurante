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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilPersonal));
            this.NomPD = new Guna.UI.WinForms.GunaLabel();
            this.LblApellidoPD = new Guna.UI.WinForms.GunaLabel();
            this.LblApellidoMD = new Guna.UI.WinForms.GunaLabel();
            this.LblTelefonoD = new Guna.UI.WinForms.GunaLabel();
            this.LblCorreoD = new Guna.UI.WinForms.GunaLabel();
            this.LblContraD = new Guna.UI.WinForms.GunaLabel();
            this.LblFechaND = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtPuestoPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.txtContrasenaPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.txtCorreoPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.txtTelefonoPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.txtFechaNacPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.txtApMaternoPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.TxtApPaternoPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNombrePersonal = new Guna.UI.WinForms.GunaTextBox();
            this.LblPuestoD = new Guna.UI.WinForms.GunaLabel();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.BtnAgregar = new Guna.UI.WinForms.GunaButton();
            this.BtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.BtnEditar = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomPD
            // 
            this.NomPD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NomPD.AutoSize = true;
            this.NomPD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomPD.Location = new System.Drawing.Point(32, 70);
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
            this.LblApellidoPD.Location = new System.Drawing.Point(32, 114);
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
            this.LblApellidoMD.Location = new System.Drawing.Point(32, 168);
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
            this.LblTelefonoD.Location = new System.Drawing.Point(42, 273);
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
            this.LblCorreoD.Location = new System.Drawing.Point(42, 324);
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
            this.LblContraD.Location = new System.Drawing.Point(42, 371);
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
            this.LblFechaND.Location = new System.Drawing.Point(32, 223);
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
            this.gunaGroupBox1.Controls.Add(this.txtPuestoPersonal);
            this.gunaGroupBox1.Controls.Add(this.txtContrasenaPersonal);
            this.gunaGroupBox1.Controls.Add(this.txtCorreoPersonal);
            this.gunaGroupBox1.Controls.Add(this.txtTelefonoPersonal);
            this.gunaGroupBox1.Controls.Add(this.txtFechaNacPersonal);
            this.gunaGroupBox1.Controls.Add(this.txtApMaternoPersonal);
            this.gunaGroupBox1.Controls.Add(this.TxtApPaternoPersonal);
            this.gunaGroupBox1.Controls.Add(this.TxtNombrePersonal);
            this.gunaGroupBox1.Controls.Add(this.LblPuestoD);
            this.gunaGroupBox1.Controls.Add(this.LblApellidoMD);
            this.gunaGroupBox1.Controls.Add(this.LblFechaND);
            this.gunaGroupBox1.Controls.Add(this.NomPD);
            this.gunaGroupBox1.Controls.Add(this.LblContraD);
            this.gunaGroupBox1.Controls.Add(this.LblApellidoPD);
            this.gunaGroupBox1.Controls.Add(this.LblCorreoD);
            this.gunaGroupBox1.Controls.Add(this.LblTelefonoD);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(107, 26);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(522, 513);
            this.gunaGroupBox1.TabIndex = 7;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtPuestoPersonal
            // 
            this.txtPuestoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPuestoPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtPuestoPersonal.BaseColor = System.Drawing.Color.White;
            this.txtPuestoPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPuestoPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPuestoPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPuestoPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtPuestoPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPuestoPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuestoPersonal.Location = new System.Drawing.Point(205, 414);
            this.txtPuestoPersonal.Name = "txtPuestoPersonal";
            this.txtPuestoPersonal.PasswordChar = '\0';
            this.txtPuestoPersonal.Radius = 10;
            this.txtPuestoPersonal.Size = new System.Drawing.Size(300, 30);
            this.txtPuestoPersonal.TabIndex = 19;
            // 
            // txtContrasenaPersonal
            // 
            this.txtContrasenaPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasenaPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtContrasenaPersonal.BaseColor = System.Drawing.Color.White;
            this.txtContrasenaPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtContrasenaPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenaPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtContrasenaPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtContrasenaPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContrasenaPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaPersonal.Location = new System.Drawing.Point(205, 371);
            this.txtContrasenaPersonal.Name = "txtContrasenaPersonal";
            this.txtContrasenaPersonal.PasswordChar = '\0';
            this.txtContrasenaPersonal.Radius = 10;
            this.txtContrasenaPersonal.Size = new System.Drawing.Size(300, 30);
            this.txtContrasenaPersonal.TabIndex = 18;
            // 
            // txtCorreoPersonal
            // 
            this.txtCorreoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreoPersonal.BaseColor = System.Drawing.Color.White;
            this.txtCorreoPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCorreoPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCorreoPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtCorreoPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCorreoPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoPersonal.Location = new System.Drawing.Point(205, 324);
            this.txtCorreoPersonal.Name = "txtCorreoPersonal";
            this.txtCorreoPersonal.PasswordChar = '\0';
            this.txtCorreoPersonal.Radius = 10;
            this.txtCorreoPersonal.Size = new System.Drawing.Size(300, 30);
            this.txtCorreoPersonal.TabIndex = 17;
            // 
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefonoPersonal.BaseColor = System.Drawing.Color.White;
            this.txtTelefonoPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtTelefonoPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTelefonoPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtTelefonoPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefonoPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(205, 273);
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.PasswordChar = '\0';
            this.txtTelefonoPersonal.Radius = 10;
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(300, 30);
            this.txtTelefonoPersonal.TabIndex = 16;
            // 
            // txtFechaNacPersonal
            // 
            this.txtFechaNacPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaNacPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtFechaNacPersonal.BaseColor = System.Drawing.Color.White;
            this.txtFechaNacPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtFechaNacPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaNacPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFechaNacPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtFechaNacPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFechaNacPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacPersonal.Location = new System.Drawing.Point(205, 223);
            this.txtFechaNacPersonal.Name = "txtFechaNacPersonal";
            this.txtFechaNacPersonal.PasswordChar = '\0';
            this.txtFechaNacPersonal.Radius = 10;
            this.txtFechaNacPersonal.Size = new System.Drawing.Size(300, 30);
            this.txtFechaNacPersonal.TabIndex = 15;
            // 
            // txtApMaternoPersonal
            // 
            this.txtApMaternoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApMaternoPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtApMaternoPersonal.BaseColor = System.Drawing.Color.White;
            this.txtApMaternoPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtApMaternoPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApMaternoPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApMaternoPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtApMaternoPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApMaternoPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApMaternoPersonal.Location = new System.Drawing.Point(205, 168);
            this.txtApMaternoPersonal.Name = "txtApMaternoPersonal";
            this.txtApMaternoPersonal.PasswordChar = '\0';
            this.txtApMaternoPersonal.Radius = 10;
            this.txtApMaternoPersonal.Size = new System.Drawing.Size(300, 30);
            this.txtApMaternoPersonal.TabIndex = 14;
            // 
            // TxtApPaternoPersonal
            // 
            this.TxtApPaternoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApPaternoPersonal.BackColor = System.Drawing.Color.Transparent;
            this.TxtApPaternoPersonal.BaseColor = System.Drawing.Color.White;
            this.TxtApPaternoPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtApPaternoPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApPaternoPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtApPaternoPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtApPaternoPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtApPaternoPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPaternoPersonal.Location = new System.Drawing.Point(205, 114);
            this.TxtApPaternoPersonal.MaxLength = 10;
            this.TxtApPaternoPersonal.Name = "TxtApPaternoPersonal";
            this.TxtApPaternoPersonal.PasswordChar = '\0';
            this.TxtApPaternoPersonal.Radius = 10;
            this.TxtApPaternoPersonal.Size = new System.Drawing.Size(300, 30);
            this.TxtApPaternoPersonal.TabIndex = 13;
            // 
            // TxtNombrePersonal
            // 
            this.TxtNombrePersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombrePersonal.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombrePersonal.BaseColor = System.Drawing.Color.White;
            this.TxtNombrePersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNombrePersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombrePersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNombrePersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNombrePersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNombrePersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombrePersonal.Location = new System.Drawing.Point(205, 70);
            this.TxtNombrePersonal.Name = "TxtNombrePersonal";
            this.TxtNombrePersonal.PasswordChar = '\0';
            this.TxtNombrePersonal.Radius = 10;
            this.TxtNombrePersonal.Size = new System.Drawing.Size(300, 30);
            this.TxtNombrePersonal.TabIndex = 12;
            // 
            // LblPuestoD
            // 
            this.LblPuestoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPuestoD.AutoSize = true;
            this.LblPuestoD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuestoD.Location = new System.Drawing.Point(42, 414);
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
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregar.AnimationHoverSpeed = 1F;
            this.BtnAgregar.AnimationSpeed = 1F;
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.BtnAgregar.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAgregar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAgregar.Location = new System.Drawing.Point(68, 567);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAgregar.OnHoverImage = null;
            this.BtnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAgregar.Radius = 20;
            this.BtnAgregar.Size = new System.Drawing.Size(144, 40);
            this.BtnAgregar.TabIndex = 39;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.AnimationHoverSpeed = 1F;
            this.BtnEliminar.AnimationSpeed = 1F;
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BaseColor = System.Drawing.Color.Red;
            this.BtnEliminar.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEliminar.Location = new System.Drawing.Point(526, 567);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEliminar.OnHoverImage = null;
            this.BtnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEliminar.Radius = 20;
            this.BtnEliminar.Size = new System.Drawing.Size(152, 40);
            this.BtnEliminar.TabIndex = 40;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditar.AnimationHoverSpeed = 1F;
            this.BtnEditar.AnimationSpeed = 1F;
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.BtnEditar.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEditar.Location = new System.Drawing.Point(287, 567);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEditar.OnHoverImage = null;
            this.BtnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEditar.Radius = 20;
            this.BtnEditar.Size = new System.Drawing.Size(167, 40);
            this.BtnEditar.TabIndex = 41;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPerfilPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 646);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
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
        private Guna.UI.WinForms.GunaTextBox txtPuestoPersonal;
        private Guna.UI.WinForms.GunaTextBox txtContrasenaPersonal;
        private Guna.UI.WinForms.GunaTextBox txtCorreoPersonal;
        private Guna.UI.WinForms.GunaTextBox txtTelefonoPersonal;
        private Guna.UI.WinForms.GunaTextBox txtFechaNacPersonal;
        private Guna.UI.WinForms.GunaTextBox txtApMaternoPersonal;
        private Guna.UI.WinForms.GunaTextBox TxtApPaternoPersonal;
        private Guna.UI.WinForms.GunaTextBox TxtNombrePersonal;
        private Guna.UI.WinForms.GunaButton BtnAgregar;
        private Guna.UI.WinForms.GunaButton BtnEliminar;
        private Guna.UI.WinForms.GunaButton BtnEditar;
    }
}