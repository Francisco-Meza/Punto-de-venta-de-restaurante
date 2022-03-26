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
            this.TxtDomicilioCliente = new Guna.UI.WinForms.GunaTextBox();
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
            this.gunaGroupBox1.Controls.Add(this.TxtDomicilioCliente);
            this.gunaGroupBox1.Controls.Add(this.TxtTelefonoCliente);
            this.gunaGroupBox1.Controls.Add(this.TxtNombreCliente);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Empty;
            this.gunaGroupBox1.Location = new System.Drawing.Point(95, 78);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(531, 336);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // TxtDomicilioCliente
            // 
            this.TxtDomicilioCliente.BackColor = System.Drawing.Color.Transparent;
            this.TxtDomicilioCliente.BaseColor = System.Drawing.Color.White;
            this.TxtDomicilioCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtDomicilioCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDomicilioCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtDomicilioCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtDomicilioCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDomicilioCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilioCliente.Location = new System.Drawing.Point(191, 236);
            this.TxtDomicilioCliente.Name = "TxtDomicilioCliente";
            this.TxtDomicilioCliente.PasswordChar = '\0';
            this.TxtDomicilioCliente.Radius = 10;
            this.TxtDomicilioCliente.Size = new System.Drawing.Size(300, 30);
            this.TxtDomicilioCliente.TabIndex = 5;
            // 
            // TxtTelefonoCliente
            // 
            this.TxtTelefonoCliente.BackColor = System.Drawing.Color.Transparent;
            this.TxtTelefonoCliente.BaseColor = System.Drawing.Color.White;
            this.TxtTelefonoCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtTelefonoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTelefonoCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtTelefonoCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtTelefonoCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoCliente.Location = new System.Drawing.Point(193, 137);
            this.TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            this.TxtTelefonoCliente.PasswordChar = '\0';
            this.TxtTelefonoCliente.Radius = 10;
            this.TxtTelefonoCliente.Size = new System.Drawing.Size(300, 30);
            this.TxtTelefonoCliente.TabIndex = 4;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombreCliente.BaseColor = System.Drawing.Color.White;
            this.TxtNombreCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNombreCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtNombreCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(191, 34);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.PasswordChar = '\0';
            this.TxtNombreCliente.Radius = 10;
            this.TxtNombreCliente.Size = new System.Drawing.Size(300, 30);
            this.TxtNombreCliente.TabIndex = 3;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(60, 245);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(79, 21);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Domicilio";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(63, 137);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Teléfono";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(17, 34);
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
            this.BtnAceptarDomicilio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnAceptarDomicilio.BorderColor = System.Drawing.Color.Black;
            this.BtnAceptarDomicilio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAceptarDomicilio.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAceptarDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAceptarDomicilio.ForeColor = System.Drawing.Color.White;
            this.BtnAceptarDomicilio.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptarDomicilio.Image")));
            this.BtnAceptarDomicilio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAceptarDomicilio.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAceptarDomicilio.Location = new System.Drawing.Point(288, 460);
            this.BtnAceptarDomicilio.Name = "BtnAceptarDomicilio";
            this.BtnAceptarDomicilio.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
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
            this.BtnCerrarHijo.Location = new System.Drawing.Point(699, 12);
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
            this.ClientSize = new System.Drawing.Size(757, 542);
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
        private Guna.UI.WinForms.GunaTextBox TxtDomicilioCliente;
        private Guna.UI.WinForms.GunaTextBox TxtTelefonoCliente;
        private Guna.UI.WinForms.GunaTextBox TxtNombreCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton BtnAceptarDomicilio;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
    }
}