namespace GUI
{
    partial class FrmPedidosDomicilio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosDomicilio));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtLocalidadCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtColoniaCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtNumCasaCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtCalleCliente = new Guna.UI.WinForms.GunaTextBox();
            this.TxtTelefonoCliente = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNombreCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.BtnAceptarDomicilio = new Guna.UI.WinForms.GunaButton();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(32, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(139, 21);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Envio a domicilio";
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
            this.gunaGroupBox1.Controls.Add(this.txtLocalidadCliente);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel7);
            this.gunaGroupBox1.Controls.Add(this.txtColoniaCliente);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.txtNumCasaCliente);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.txtCalleCliente);
            this.gunaGroupBox1.Controls.Add(this.TxtTelefonoCliente);
            this.gunaGroupBox1.Controls.Add(this.TxtNombreCliente);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Empty;
            this.gunaGroupBox1.Location = new System.Drawing.Point(98, 79);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(612, 491);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtLocalidadCliente
            // 
            this.txtLocalidadCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalidadCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtLocalidadCliente.BaseColor = System.Drawing.Color.White;
            this.txtLocalidadCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtLocalidadCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalidadCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLocalidadCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtLocalidadCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLocalidadCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidadCliente.Location = new System.Drawing.Point(247, 372);
            this.txtLocalidadCliente.Name = "txtLocalidadCliente";
            this.txtLocalidadCliente.PasswordChar = '\0';
            this.txtLocalidadCliente.Radius = 10;
            this.txtLocalidadCliente.Size = new System.Drawing.Size(336, 30);
            this.txtLocalidadCliente.TabIndex = 11;
            this.txtLocalidadCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLocalidadCliente_KeyPress);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(60, 381);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(87, 21);
            this.gunaLabel7.TabIndex = 10;
            this.gunaLabel7.Text = "Localidad";
            // 
            // txtColoniaCliente
            // 
            this.txtColoniaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColoniaCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtColoniaCliente.BaseColor = System.Drawing.Color.White;
            this.txtColoniaCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtColoniaCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColoniaCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtColoniaCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtColoniaCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtColoniaCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColoniaCliente.Location = new System.Drawing.Point(247, 312);
            this.txtColoniaCliente.Name = "txtColoniaCliente";
            this.txtColoniaCliente.PasswordChar = '\0';
            this.txtColoniaCliente.Radius = 10;
            this.txtColoniaCliente.Size = new System.Drawing.Size(336, 30);
            this.txtColoniaCliente.TabIndex = 9;
            this.txtColoniaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtColoniaCliente_KeyPress);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(71, 321);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(70, 21);
            this.gunaLabel6.TabIndex = 8;
            this.gunaLabel6.Text = "Colonia";
            // 
            // txtNumCasaCliente
            // 
            this.txtNumCasaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumCasaCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtNumCasaCliente.BaseColor = System.Drawing.Color.White;
            this.txtNumCasaCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNumCasaCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumCasaCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumCasaCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtNumCasaCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumCasaCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCasaCliente.Location = new System.Drawing.Point(247, 254);
            this.txtNumCasaCliente.Name = "txtNumCasaCliente";
            this.txtNumCasaCliente.PasswordChar = '\0';
            this.txtNumCasaCliente.Radius = 10;
            this.txtNumCasaCliente.Size = new System.Drawing.Size(336, 30);
            this.txtNumCasaCliente.TabIndex = 7;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(34, 263);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(139, 21);
            this.gunaLabel5.TabIndex = 6;
            this.gunaLabel5.Text = "Número de casa";
            // 
            // txtCalleCliente
            // 
            this.txtCalleCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalleCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtCalleCliente.BaseColor = System.Drawing.Color.White;
            this.txtCalleCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCalleCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalleCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCalleCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtCalleCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCalleCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleCliente.Location = new System.Drawing.Point(247, 194);
            this.txtCalleCliente.Name = "txtCalleCliente";
            this.txtCalleCliente.PasswordChar = '\0';
            this.txtCalleCliente.Radius = 10;
            this.txtCalleCliente.Size = new System.Drawing.Size(336, 30);
            this.txtCalleCliente.TabIndex = 5;
            this.txtCalleCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCalleCliente_KeyPress);
            // 
            // TxtTelefonoCliente
            // 
            this.TxtTelefonoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefonoCliente.BackColor = System.Drawing.Color.Transparent;
            this.TxtTelefonoCliente.BaseColor = System.Drawing.Color.White;
            this.TxtTelefonoCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtTelefonoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTelefonoCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTelefonoCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtTelefonoCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoCliente.Location = new System.Drawing.Point(247, 134);
            this.TxtTelefonoCliente.MaxLength = 10;
            this.TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            this.TxtTelefonoCliente.PasswordChar = '\0';
            this.TxtTelefonoCliente.Radius = 10;
            this.TxtTelefonoCliente.Size = new System.Drawing.Size(336, 30);
            this.TxtTelefonoCliente.TabIndex = 4;
            this.TxtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoCliente_KeyPress);
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombreCliente.BaseColor = System.Drawing.Color.White;
            this.TxtNombreCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNombreCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNombreCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(247, 77);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.PasswordChar = '\0';
            this.TxtNombreCliente.Radius = 10;
            this.TxtNombreCliente.Size = new System.Drawing.Size(336, 30);
            this.TxtNombreCliente.TabIndex = 3;
            this.TxtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreCliente_KeyPress);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(80, 203);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(50, 21);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Calle";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(71, 134);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Teléfono";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(24, 77);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(158, 21);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Nombre del cliente";
            // 
            // BtnAceptarDomicilio
            // 
            this.BtnAceptarDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAceptarDomicilio.AnimationHoverSpeed = 0.07F;
            this.BtnAceptarDomicilio.AnimationSpeed = 0.03F;
            this.BtnAceptarDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.BtnAceptarDomicilio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.BtnAceptarDomicilio.BorderColor = System.Drawing.Color.Black;
            this.BtnAceptarDomicilio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAceptarDomicilio.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAceptarDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAceptarDomicilio.ForeColor = System.Drawing.Color.White;
            this.BtnAceptarDomicilio.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptarDomicilio.Image")));
            this.BtnAceptarDomicilio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAceptarDomicilio.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAceptarDomicilio.Location = new System.Drawing.Point(331, 576);
            this.BtnAceptarDomicilio.Name = "BtnAceptarDomicilio";
            this.BtnAceptarDomicilio.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnAceptarDomicilio.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAceptarDomicilio.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAceptarDomicilio.OnHoverImage = null;
            this.BtnAceptarDomicilio.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAceptarDomicilio.Radius = 20;
            this.BtnAceptarDomicilio.Size = new System.Drawing.Size(160, 42);
            this.BtnAceptarDomicilio.TabIndex = 3;
            this.BtnAceptarDomicilio.Text = "Aceptar";
            this.BtnAceptarDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAceptarDomicilio.Click += new System.EventHandler(this.BtnAceptarDomicilio_Click);
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
            this.BtnCerrarHijo.Location = new System.Drawing.Point(780, 12);
            this.BtnCerrarHijo.Name = "BtnCerrarHijo";
            this.BtnCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.BtnCerrarHijo.TabIndex = 7;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
            this.BtnCerrarHijo.Click += new System.EventHandler(this.BtnCerrarHijo_Click);
            // 
            // FrmPedidosDomicilio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(838, 645);
            this.Controls.Add(this.BtnCerrarHijo);
            this.Controls.Add(this.BtnAceptarDomicilio);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidosDomicilio";
            this.Text = "FrmPedidosDomicilio";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtCalleCliente;
        private Guna.UI.WinForms.GunaTextBox TxtTelefonoCliente;
        private Guna.UI.WinForms.GunaTextBox TxtNombreCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton BtnAceptarDomicilio;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaTextBox txtLocalidadCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtColoniaCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtNumCasaCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}