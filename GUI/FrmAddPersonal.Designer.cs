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
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.TxtPuesto = new Guna.UI.WinForms.GunaTextBox();
            this.TxtContra = new Guna.UI.WinForms.GunaTextBox();
            this.TxtCorreo = new Guna.UI.WinForms.GunaTextBox();
            this.TxtFechaN = new Guna.UI.WinForms.GunaTextBox();
            this.TxtApeM = new Guna.UI.WinForms.GunaTextBox();
            this.TxtApeP = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNombreP = new Guna.UI.WinForms.GunaTextBox();
            this.lblPuesto = new Guna.UI.WinForms.GunaLabel();
            this.lblContraP = new Guna.UI.WinForms.GunaLabel();
            this.lblCorreoP = new Guna.UI.WinForms.GunaLabel();
            this.lblFechaNac = new Guna.UI.WinForms.GunaLabel();
            this.lblApeM = new Guna.UI.WinForms.GunaLabel();
            this.lblApeP = new Guna.UI.WinForms.GunaLabel();
            this.lblNombre = new Guna.UI.WinForms.GunaLabel();
            this.BtnGuardar = new Guna.UI.WinForms.GunaButton();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.txtTelefonoPersonal = new Guna.UI.WinForms.GunaTextBox();
            this.lblTelefonoPersonal = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(30, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(154, 21);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Datos del personal";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.lblTelefonoPersonal);
            this.gunaGroupBox1.Controls.Add(this.txtTelefonoPersonal);
            this.gunaGroupBox1.Controls.Add(this.TxtPuesto);
            this.gunaGroupBox1.Controls.Add(this.TxtContra);
            this.gunaGroupBox1.Controls.Add(this.TxtCorreo);
            this.gunaGroupBox1.Controls.Add(this.TxtFechaN);
            this.gunaGroupBox1.Controls.Add(this.TxtApeM);
            this.gunaGroupBox1.Controls.Add(this.TxtApeP);
            this.gunaGroupBox1.Controls.Add(this.TxtNombreP);
            this.gunaGroupBox1.Controls.Add(this.lblPuesto);
            this.gunaGroupBox1.Controls.Add(this.lblContraP);
            this.gunaGroupBox1.Controls.Add(this.lblCorreoP);
            this.gunaGroupBox1.Controls.Add(this.lblFechaNac);
            this.gunaGroupBox1.Controls.Add(this.lblApeM);
            this.gunaGroupBox1.Controls.Add(this.lblApeP);
            this.gunaGroupBox1.Controls.Add(this.lblNombre);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Empty;
            this.gunaGroupBox1.Location = new System.Drawing.Point(56, 48);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 423);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // TxtPuesto
            // 
            this.TxtPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPuesto.BackColor = System.Drawing.Color.Transparent;
            this.TxtPuesto.BaseColor = System.Drawing.Color.White;
            this.TxtPuesto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtPuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPuesto.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtPuesto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtPuesto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuesto.Location = new System.Drawing.Point(220, 361);
            this.TxtPuesto.Name = "TxtPuesto";
            this.TxtPuesto.PasswordChar = '\0';
            this.TxtPuesto.Radius = 10;
            this.TxtPuesto.Size = new System.Drawing.Size(306, 30);
            this.TxtPuesto.TabIndex = 13;
            this.TxtPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPuesto_KeyPress);
            // 
            // TxtContra
            // 
            this.TxtContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtContra.BackColor = System.Drawing.Color.Transparent;
            this.TxtContra.BaseColor = System.Drawing.Color.White;
            this.TxtContra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtContra.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtContra.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtContra.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.Location = new System.Drawing.Point(219, 314);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.PasswordChar = '\0';
            this.TxtContra.Radius = 10;
            this.TxtContra.Size = new System.Drawing.Size(306, 30);
            this.TxtContra.TabIndex = 12;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.TxtCorreo.BaseColor = System.Drawing.Color.White;
            this.TxtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCorreo.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(220, 262);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.PasswordChar = '\0';
            this.TxtCorreo.Radius = 10;
            this.TxtCorreo.Size = new System.Drawing.Size(306, 30);
            this.TxtCorreo.TabIndex = 11;
            // 
            // TxtFechaN
            // 
            this.TxtFechaN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFechaN.BackColor = System.Drawing.Color.Transparent;
            this.TxtFechaN.BaseColor = System.Drawing.Color.White;
            this.TxtFechaN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtFechaN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFechaN.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtFechaN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtFechaN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtFechaN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaN.Location = new System.Drawing.Point(220, 171);
            this.TxtFechaN.Name = "TxtFechaN";
            this.TxtFechaN.PasswordChar = '\0';
            this.TxtFechaN.Radius = 10;
            this.TxtFechaN.Size = new System.Drawing.Size(306, 30);
            this.TxtFechaN.TabIndex = 10;
            this.TxtFechaN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaN_KeyPress);
            // 
            // TxtApeM
            // 
            this.TxtApeM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApeM.BackColor = System.Drawing.Color.Transparent;
            this.TxtApeM.BaseColor = System.Drawing.Color.White;
            this.TxtApeM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtApeM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApeM.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtApeM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtApeM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtApeM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApeM.Location = new System.Drawing.Point(219, 123);
            this.TxtApeM.Name = "TxtApeM";
            this.TxtApeM.PasswordChar = '\0';
            this.TxtApeM.Radius = 10;
            this.TxtApeM.Size = new System.Drawing.Size(306, 30);
            this.TxtApeM.TabIndex = 9;
            this.TxtApeM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApeM_KeyPress);
            // 
            // TxtApeP
            // 
            this.TxtApeP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApeP.BackColor = System.Drawing.Color.Transparent;
            this.TxtApeP.BaseColor = System.Drawing.Color.White;
            this.TxtApeP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtApeP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApeP.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtApeP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtApeP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtApeP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApeP.Location = new System.Drawing.Point(220, 78);
            this.TxtApeP.Name = "TxtApeP";
            this.TxtApeP.PasswordChar = '\0';
            this.TxtApeP.Radius = 10;
            this.TxtApeP.Size = new System.Drawing.Size(306, 30);
            this.TxtApeP.TabIndex = 8;
            this.TxtApeP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApeM_KeyPress);
            // 
            // TxtNombreP
            // 
            this.TxtNombreP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreP.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombreP.BaseColor = System.Drawing.Color.White;
            this.TxtNombreP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNombreP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreP.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNombreP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtNombreP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNombreP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreP.Location = new System.Drawing.Point(220, 30);
            this.TxtNombreP.Name = "TxtNombreP";
            this.TxtNombreP.PasswordChar = '\0';
            this.TxtNombreP.Radius = 10;
            this.TxtNombreP.Size = new System.Drawing.Size(306, 30);
            this.TxtNombreP.TabIndex = 7;
            this.TxtNombreP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApeM_KeyPress);
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(79, 361);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(58, 20);
            this.lblPuesto.TabIndex = 6;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblContraP
            // 
            this.lblContraP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraP.AutoSize = true;
            this.lblContraP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraP.Location = new System.Drawing.Point(72, 314);
            this.lblContraP.Name = "lblContraP";
            this.lblContraP.Size = new System.Drawing.Size(95, 20);
            this.lblContraP.TabIndex = 5;
            this.lblContraP.Text = "Contraseña";
            // 
            // lblCorreoP
            // 
            this.lblCorreoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreoP.AutoSize = true;
            this.lblCorreoP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoP.Location = new System.Drawing.Point(89, 262);
            this.lblCorreoP.Name = "lblCorreoP";
            this.lblCorreoP.Size = new System.Drawing.Size(61, 20);
            this.lblCorreoP.TabIndex = 4;
            this.lblCorreoP.Text = "Correo";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(31, 171);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(165, 20);
            this.lblFechaNac.TabIndex = 3;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblApeM
            // 
            this.lblApeM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApeM.AutoSize = true;
            this.lblApeM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeM.Location = new System.Drawing.Point(61, 123);
            this.lblApeM.Name = "lblApeM";
            this.lblApeM.Size = new System.Drawing.Size(135, 20);
            this.lblApeM.TabIndex = 2;
            this.lblApeM.Text = "Apellido materno";
            // 
            // lblApeP
            // 
            this.lblApeP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApeP.AutoSize = true;
            this.lblApeP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeP.Location = new System.Drawing.Point(61, 78);
            this.lblApeP.Name = "lblApeP";
            this.lblApeP.Size = new System.Drawing.Size(132, 20);
            this.lblApeP.TabIndex = 1;
            this.lblApeP.Text = "Apellido paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(89, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.AnimationHoverSpeed = 0.07F;
            this.BtnGuardar.AnimationSpeed = 0.03F;
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnGuardar.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGuardar.Location = new System.Drawing.Point(562, 477);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardar.OnHoverImage = null;
            this.BtnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardar.Radius = 20;
            this.BtnGuardar.Size = new System.Drawing.Size(160, 42);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoPersonal.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefonoPersonal.BaseColor = System.Drawing.Color.White;
            this.txtTelefonoPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtTelefonoPersonal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoPersonal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTelefonoPersonal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTelefonoPersonal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefonoPersonal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(220, 217);
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.PasswordChar = '\0';
            this.txtTelefonoPersonal.Radius = 10;
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(306, 30);
            this.txtTelefonoPersonal.TabIndex = 14;
            // 
            // lblTelefonoPersonal
            // 
            this.lblTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoPersonal.AutoSize = true;
            this.lblTelefonoPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoPersonal.Location = new System.Drawing.Point(79, 217);
            this.lblTelefonoPersonal.Name = "lblTelefonoPersonal";
            this.lblTelefonoPersonal.Size = new System.Drawing.Size(71, 20);
            this.lblTelefonoPersonal.TabIndex = 15;
            this.lblTelefonoPersonal.Text = "Teléfono";
            // 
            // FrmAddPersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.BtnCerrarHijo);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddPersonal";
            this.Text = "Frm";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel lblNombre;
        private Guna.UI.WinForms.GunaLabel lblPuesto;
        private Guna.UI.WinForms.GunaLabel lblContraP;
        private Guna.UI.WinForms.GunaLabel lblCorreoP;
        private Guna.UI.WinForms.GunaLabel lblFechaNac;
        private Guna.UI.WinForms.GunaLabel lblApeM;
        private Guna.UI.WinForms.GunaLabel lblApeP;
        private Guna.UI.WinForms.GunaTextBox TxtPuesto;
        private Guna.UI.WinForms.GunaTextBox TxtContra;
        private Guna.UI.WinForms.GunaTextBox TxtCorreo;
        private Guna.UI.WinForms.GunaTextBox TxtFechaN;
        private Guna.UI.WinForms.GunaTextBox TxtApeM;
        private Guna.UI.WinForms.GunaTextBox TxtApeP;
        private Guna.UI.WinForms.GunaTextBox TxtNombreP;
        private Guna.UI.WinForms.GunaButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaLabel lblTelefonoPersonal;
        private Guna.UI.WinForms.GunaTextBox txtTelefonoPersonal;
    }
}