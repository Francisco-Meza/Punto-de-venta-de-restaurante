namespace GUI.ADMINISTRACION
{
    partial class FrmAddMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddMesa));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtNumCom = new Guna.UI.WinForms.GunaTextBox();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.txtNumMesa = new Guna.UI.WinForms.GunaTextBox();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.txtNumCom);
            this.gunaGroupBox1.Controls.Add(this.txtDesc);
            this.gunaGroupBox1.Controls.Add(this.txtNumMesa);
            this.gunaGroupBox1.Controls.Add(this.txtId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtNumCom
            // 
            this.txtNumCom.BaseColor = System.Drawing.Color.White;
            this.txtNumCom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNumCom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumCom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumCom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtNumCom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumCom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumCom.Location = new System.Drawing.Point(262, 145);
            this.txtNumCom.Name = "txtNumCom";
            this.txtNumCom.PasswordChar = '\0';
            this.txtNumCom.Radius = 10;
            this.txtNumCom.Size = new System.Drawing.Size(306, 30);
            this.txtNumCom.TabIndex = 8;
            // 
            // txtDesc
            // 
            this.txtDesc.BaseColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDesc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtDesc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDesc.Location = new System.Drawing.Point(262, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.Radius = 10;
            this.txtDesc.Size = new System.Drawing.Size(306, 30);
            this.txtDesc.TabIndex = 7;
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.BaseColor = System.Drawing.Color.White;
            this.txtNumMesa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNumMesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMesa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumMesa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtNumMesa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumMesa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumMesa.Location = new System.Drawing.Point(262, 58);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.PasswordChar = '\0';
            this.txtNumMesa.Radius = 10;
            this.txtNumMesa.Size = new System.Drawing.Size(306, 30);
            this.txtNumMesa.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.Location = new System.Drawing.Point(262, 16);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.Radius = 10;
            this.txtId.Size = new System.Drawing.Size(306, 30);
            this.txtId.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrarHijo
            // 
            this.bntCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrarHijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.bntCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrarHijo.IconSize = 40;
            this.bntCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrarHijo.Location = new System.Drawing.Point(702, 9);
            this.bntCerrarHijo.Name = "bntCerrarHijo";
            this.bntCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.bntCerrarHijo.TabIndex = 11;
            this.bntCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtNumCom = new Guna.UI.WinForms.GunaTextBox();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.txtNumMesa = new Guna.UI.WinForms.GunaTextBox();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.txtNumCom);
            this.gunaGroupBox1.Controls.Add(this.txtDesc);
            this.gunaGroupBox1.Controls.Add(this.txtNumMesa);
            this.gunaGroupBox1.Controls.Add(this.txtId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtNumCom
            // 
            this.txtNumCom.BaseColor = System.Drawing.Color.White;
            this.txtNumCom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNumCom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumCom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumCom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtNumCom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumCom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumCom.Location = new System.Drawing.Point(262, 145);
            this.txtNumCom.Name = "txtNumCom";
            this.txtNumCom.PasswordChar = '\0';
            this.txtNumCom.Radius = 10;
            this.txtNumCom.Size = new System.Drawing.Size(306, 30);
            this.txtNumCom.TabIndex = 8;
            // 
            // txtDesc
            // 
            this.txtDesc.BaseColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDesc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtDesc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDesc.Location = new System.Drawing.Point(262, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.Radius = 10;
            this.txtDesc.Size = new System.Drawing.Size(306, 30);
            this.txtDesc.TabIndex = 7;
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.BaseColor = System.Drawing.Color.White;
            this.txtNumMesa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNumMesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMesa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumMesa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtNumMesa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumMesa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumMesa.Location = new System.Drawing.Point(262, 58);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.PasswordChar = '\0';
            this.txtNumMesa.Radius = 10;
            this.txtNumMesa.Size = new System.Drawing.Size(306, 30);
            this.txtNumMesa.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.Location = new System.Drawing.Point(262, 16);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.Radius = 10;
            this.txtId.Size = new System.Drawing.Size(306, 30);
            this.txtId.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrarHijo
            // 
            this.bntCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrarHijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.bntCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrarHijo.IconSize = 40;
            this.bntCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrarHijo.Location = new System.Drawing.Point(702, 9);
            this.bntCerrarHijo.Name = "bntCerrarHijo";
            this.bntCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.bntCerrarHijo.TabIndex = 11;
            this.bntCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.txtNumMesa = new Guna.UI.WinForms.GunaTextBox();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.txtDesc);
            this.gunaGroupBox1.Controls.Add(this.txtNumMesa);
            this.gunaGroupBox1.Controls.Add(this.txtId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // txtDesc
            // 
            this.txtDesc.BaseColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDesc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtDesc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDesc.Location = new System.Drawing.Point(262, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.Radius = 10;
            this.txtDesc.Size = new System.Drawing.Size(306, 30);
            this.txtDesc.TabIndex = 7;
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.BaseColor = System.Drawing.Color.White;
            this.txtNumMesa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNumMesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMesa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumMesa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtNumMesa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumMesa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumMesa.Location = new System.Drawing.Point(262, 58);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.PasswordChar = '\0';
            this.txtNumMesa.Radius = 10;
            this.txtNumMesa.Size = new System.Drawing.Size(306, 30);
            this.txtNumMesa.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.Location = new System.Drawing.Point(262, 16);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.Radius = 10;
            this.txtId.Size = new System.Drawing.Size(306, 30);
            this.txtId.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrarHijo
            // 
            this.bntCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrarHijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.bntCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrarHijo.IconSize = 40;
            this.bntCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrarHijo.Location = new System.Drawing.Point(702, 9);
            this.bntCerrarHijo.Name = "bntCerrarHijo";
            this.bntCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.bntCerrarHijo.TabIndex = 11;
            this.bntCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.txtNumMesa = new Guna.UI.WinForms.GunaTextBox();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.txtNumMesa);
            this.gunaGroupBox1.Controls.Add(this.txtId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.BaseColor = System.Drawing.Color.White;
            this.txtNumMesa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNumMesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMesa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumMesa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtNumMesa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumMesa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumMesa.Location = new System.Drawing.Point(262, 58);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.PasswordChar = '\0';
            this.txtNumMesa.Radius = 10;
            this.txtNumMesa.Size = new System.Drawing.Size(306, 30);
            this.txtNumMesa.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.Location = new System.Drawing.Point(262, 16);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.Radius = 10;
            this.txtId.Size = new System.Drawing.Size(306, 30);
            this.txtId.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrarHijo
            // 
            this.bntCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrarHijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.bntCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrarHijo.IconSize = 40;
            this.bntCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrarHijo.Location = new System.Drawing.Point(702, 9);
            this.bntCerrarHijo.Name = "bntCerrarHijo";
            this.bntCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.bntCerrarHijo.TabIndex = 11;
            this.bntCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.txtId);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.Location = new System.Drawing.Point(262, 16);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.Radius = 10;
            this.txtId.Size = new System.Drawing.Size(306, 30);
            this.txtId.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrarHijo
            // 
            this.bntCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrarHijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.bntCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrarHijo.IconSize = 40;
            this.bntCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrarHijo.Location = new System.Drawing.Point(702, 9);
            this.bntCerrarHijo.Name = "bntCerrarHijo";
            this.bntCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.bntCerrarHijo.TabIndex = 11;
            this.bntCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrarHijo
            // 
            this.bntCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrarHijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.bntCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrarHijo.IconSize = 40;
            this.bntCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrarHijo.Location = new System.Drawing.Point(702, 9);
            this.bntCerrarHijo.Name = "bntCerrarHijo";
            this.bntCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.bntCerrarHijo.TabIndex = 11;
            this.bntCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrarHijo
            // 
            this.bntCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrarHijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.bntCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrarHijo.IconSize = 40;
            this.bntCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrarHijo.Location = new System.Drawing.Point(702, 9);
            this.bntCerrarHijo.Name = "bntCerrarHijo";
            this.bntCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.bntCerrarHijo.TabIndex = 11;
            this.bntCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrarHijo
            // 
            this.bntCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrarHijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.bntCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrarHijo.IconSize = 40;
            this.bntCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrarHijo.Location = new System.Drawing.Point(702, 9);
            this.bntCerrarHijo.Name = "bntCerrarHijo";
            this.bntCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.bntCerrarHijo.TabIndex = 11;
            this.bntCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(702, 9);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 11;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Guardar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(702, 9);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 17;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(702, 9);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 17;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(702, 9);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 17;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(302, 445);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(702, 9);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 17;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(289, 447);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(84, 120);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(88, 164);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(702, 9);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 17;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(289, 447);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(67, 107);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(71, 151);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(702, 9);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 17;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(289, 447);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(67, 73);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(71, 117);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(702, 9);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 17;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bntCerrar = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.bntCerrar);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(748, 367);
            this.gunaPanel1.TabIndex = 14;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(279, 317);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(67, 8);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(71, 52);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(351, 186);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 17;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(85, 147);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(297, 456);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 13;
            this.gunaButton1.Text = "gunaButton1";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(85, 147);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Datos de la mesa";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(85, 147);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "gunaLabel5";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(86, 142);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "gunaLabel5";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(86, 130);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "gunaLabel5";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(262, 58);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 102);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 111);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            this.gunaTextBox1.Text = "gunaTextBox1";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(263, 59);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            this.gunaTextBox2.Text = "gunaTextBox2";
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 104);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            this.gunaTextBox3.Text = "gunaTextBox3";
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 147);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            this.gunaTextBox4.Text = "gunaTextBox4";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 111);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            this.gunaTextBox1.Text = "gunaTextBox1";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(263, 59);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            this.gunaTextBox2.Text = "gunaTextBox2";
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 104);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            this.gunaTextBox3.Text = "gunaTextBox3";
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 147);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            this.gunaTextBox4.Text = "gunaTextBox4";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 111);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            this.gunaTextBox1.Text = "gunaTextBox1";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox2.Location = new System.Drawing.Point(263, 59);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            this.gunaTextBox2.Text = "gunaTextBox2";
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 104);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            this.gunaTextBox3.Text = "gunaTextBox3";
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 147);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            this.gunaTextBox4.Text = "gunaTextBox4";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 111);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(262, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox1.TabIndex = 5;
            this.gunaTextBox1.Text = "gunaTextBox1";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(263, 59);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox2.TabIndex = 6;
            this.gunaTextBox2.Text = "gunaTextBox2";
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.Location = new System.Drawing.Point(262, 104);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox3.TabIndex = 7;
            this.gunaTextBox3.Text = "gunaTextBox3";
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox4.Location = new System.Drawing.Point(262, 147);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Size = new System.Drawing.Size(306, 30);
            this.gunaTextBox4.TabIndex = 8;
            this.gunaTextBox4.Text = "gunaTextBox4";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox5 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox5);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox2);
            this.gunaGroupBox1.Controls.Add(this.gunaTextBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 111);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(271, 30);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(160, 30);
            this.gunaTextBox1.TabIndex = 5;
            this.gunaTextBox1.Text = "gunaTextBox1";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(283, 83);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Size = new System.Drawing.Size(137, 26);
            this.gunaTextBox2.TabIndex = 6;
            this.gunaTextBox2.Text = "gunaTextBox2";
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.Location = new System.Drawing.Point(352, 118);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Size = new System.Drawing.Size(160, 30);
            this.gunaTextBox3.TabIndex = 7;
            this.gunaTextBox3.Text = "gunaTextBox3";
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox4.Location = new System.Drawing.Point(301, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Size = new System.Drawing.Size(8, 26);
            this.gunaTextBox4.TabIndex = 8;
            this.gunaTextBox4.Text = "gunaTextBox4";
            // 
            // gunaTextBox5
            // 
            this.gunaTextBox5.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox5.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox5.Location = new System.Drawing.Point(400, 166);
            this.gunaTextBox5.Name = "gunaTextBox5";
            this.gunaTextBox5.PasswordChar = '\0';
            this.gunaTextBox5.Size = new System.Drawing.Size(160, 30);
            this.gunaTextBox5.TabIndex = 9;
            this.gunaTextBox5.Text = "gunaTextBox5";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 199);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(57, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Numero de Mesa";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(57, 111);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Descripcion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(57, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(57, 151);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Numero de Comensales";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 161);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(109, 60);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(95, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "gunaLabel1";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(109, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(95, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "gunaLabel2";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(109, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "ID";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(109, 131);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(95, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "gunaLabel4";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 161);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(109, 60);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "gunaLabel1";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(109, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "gunaLabel2";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(109, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "gunaLabel3";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(109, 131);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "gunaLabel4";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 161);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(109, 60);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "gunaLabel1";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(109, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "gunaLabel2";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(109, 26);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "gunaLabel3";
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 161);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 161);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "gunaGroupBox1";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(260, 240);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "gunaGroupBox1";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(260, 240);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "gunaGroupBox1";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(260, 240);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "gunaGroupBox1";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(260, 240);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "gunaGroupBox1";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(89, 191);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(260, 240);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "gunaGroupBox1";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(151, 125);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(260, 240);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "gunaGroupBox1";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(46, 39);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 10;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.Location = new System.Drawing.Point(708, 3);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 0;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.Location = new System.Drawing.Point(702, 26);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 0;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.Location = new System.Drawing.Point(702, 26);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 0;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.bntCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bntCerrar.IconColor = System.Drawing.Color.Black;
            this.bntCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCerrar.IconSize = 40;
            this.bntCerrar.Location = new System.Drawing.Point(702, 26);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(43, 42);
            this.bntCerrar.TabIndex = 0;
            this.bntCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.bntCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(702, 26);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 42);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(702, 26);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 42);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(702, 26);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 42);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FrmAddMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(741, 503);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 503);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 503);
            this.Name = "FrmAddMesa";
            this.Text = "FrmAddMesa";
            this.ResumeLayout(false);

        }

        #endregion
    }
}