namespace GUI
{
    partial class FrmAddProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProductos));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.ComboBoxClasi = new Guna.UI.WinForms.GunaComboBox();
            this.TxtPrecioPro = new Guna.UI.WinForms.GunaTextBox();
            this.TxtDescriPro = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNombrePro = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnGuardarPro = new Guna.UI.WinForms.GunaButton();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.gunaGroupBox1.Controls.Add(this.ComboBoxClasi);
            this.gunaGroupBox1.Controls.Add(this.TxtPrecioPro);
            this.gunaGroupBox1.Controls.Add(this.TxtDescriPro);
            this.gunaGroupBox1.Controls.Add(this.TxtNombrePro);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Empty;
            this.gunaGroupBox1.Location = new System.Drawing.Point(46, 93);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(680, 411);
            this.gunaGroupBox1.TabIndex = 2;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // ComboBoxClasi
            // 
            this.ComboBoxClasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxClasi.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxClasi.BaseColor = System.Drawing.Color.White;
            this.ComboBoxClasi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ComboBoxClasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxClasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxClasi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.ComboBoxClasi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxClasi.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxClasi.FormattingEnabled = true;
            this.ComboBoxClasi.Location = new System.Drawing.Point(219, 196);
            this.ComboBoxClasi.Name = "ComboBoxClasi";
            this.ComboBoxClasi.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.ComboBoxClasi.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxClasi.Radius = 10;
            this.ComboBoxClasi.Size = new System.Drawing.Size(306, 26);
            this.ComboBoxClasi.TabIndex = 12;
            // 
            // TxtPrecioPro
            // 
            this.TxtPrecioPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecioPro.BackColor = System.Drawing.Color.Transparent;
            this.TxtPrecioPro.BaseColor = System.Drawing.Color.White;
            this.TxtPrecioPro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtPrecioPro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrecioPro.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtPrecioPro.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtPrecioPro.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPrecioPro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioPro.Location = new System.Drawing.Point(219, 268);
            this.TxtPrecioPro.Name = "TxtPrecioPro";
            this.TxtPrecioPro.PasswordChar = '\0';
            this.TxtPrecioPro.Radius = 10;
            this.TxtPrecioPro.Size = new System.Drawing.Size(306, 30);
            this.TxtPrecioPro.TabIndex = 11;
            this.TxtPrecioPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreo_KeyPress);
            // 
            // TxtDescriPro
            // 
            this.TxtDescriPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescriPro.BackColor = System.Drawing.Color.Transparent;
            this.TxtDescriPro.BaseColor = System.Drawing.Color.White;
            this.TxtDescriPro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtDescriPro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescriPro.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtDescriPro.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtDescriPro.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDescriPro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescriPro.Location = new System.Drawing.Point(219, 129);
            this.TxtDescriPro.Name = "TxtDescriPro";
            this.TxtDescriPro.PasswordChar = '\0';
            this.TxtDescriPro.Radius = 10;
            this.TxtDescriPro.Size = new System.Drawing.Size(306, 30);
            this.TxtDescriPro.TabIndex = 8;
            this.TxtDescriPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApeM_KeyPress);
            // 
            // TxtNombrePro
            // 
            this.TxtNombrePro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombrePro.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombrePro.BaseColor = System.Drawing.Color.White;
            this.TxtNombrePro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNombrePro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombrePro.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNombrePro.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNombrePro.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNombrePro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombrePro.Location = new System.Drawing.Point(219, 70);
            this.TxtNombrePro.Name = "TxtNombrePro";
            this.TxtNombrePro.PasswordChar = '\0';
            this.TxtNombrePro.Radius = 10;
            this.TxtNombrePro.Size = new System.Drawing.Size(306, 30);
            this.TxtNombrePro.TabIndex = 7;
            this.TxtNombrePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApeM_KeyPress);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(80, 268);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(56, 20);
            this.gunaLabel6.TabIndex = 4;
            this.gunaLabel6.Text = "Precio";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(68, 197);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(103, 20);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Clasificacion";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(68, 129);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Descripcion";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(68, 70);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 20);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Nombre";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(29, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(147, 21);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Añadir productos";
            // 
            // BtnGuardarPro
            // 
            this.BtnGuardarPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarPro.AnimationHoverSpeed = 0.07F;
            this.BtnGuardarPro.AnimationSpeed = 0.03F;
            this.BtnGuardarPro.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarPro.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.BtnGuardarPro.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardarPro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGuardarPro.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGuardarPro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardarPro.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarPro.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarPro.Image")));
            this.BtnGuardarPro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardarPro.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGuardarPro.Location = new System.Drawing.Point(299, 537);
            this.BtnGuardarPro.Name = "BtnGuardarPro";
            this.BtnGuardarPro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnGuardarPro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardarPro.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardarPro.OnHoverImage = null;
            this.BtnGuardarPro.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardarPro.Radius = 20;
            this.BtnGuardarPro.Size = new System.Drawing.Size(160, 42);
            this.BtnGuardarPro.TabIndex = 8;
            this.BtnGuardarPro.Text = "Guardar";
            this.BtnGuardarPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardarPro.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCerrarHijo
            // 
            this.BtnCerrarHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarHijo.FlatAppearance.BorderSize = 0;
            this.BtnCerrarHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarHijo.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.BtnCerrarHijo.IconColor = System.Drawing.Color.Black;
            this.BtnCerrarHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrarHijo.IconSize = 40;
            this.BtnCerrarHijo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrarHijo.Location = new System.Drawing.Point(699, 6);
            this.BtnCerrarHijo.Name = "BtnCerrarHijo";
            this.BtnCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.BtnCerrarHijo.TabIndex = 7;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
            this.BtnCerrarHijo.Click += new System.EventHandler(this.BtnCerrarHijo_Click);
            // 
            // FrmAddProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 646);
            this.Controls.Add(this.BtnGuardarPro);
            this.Controls.Add(this.BtnCerrarHijo);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddProductos";
            this.Text = "FrmAddProductos";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox TxtPrecioPro;
        private Guna.UI.WinForms.GunaTextBox TxtDescriPro;
        private Guna.UI.WinForms.GunaTextBox TxtNombrePro;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaButton BtnGuardarPro;
        private Guna.UI.WinForms.GunaComboBox ComboBoxClasi;
    }
}