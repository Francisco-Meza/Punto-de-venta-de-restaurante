namespace GUI.ADMINISTRACION
{
    partial class FrmAddMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddMesas));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.TxtNumComensales = new Guna.UI.WinForms.GunaTextBox();
            this.TxtDescripcion = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNumero = new Guna.UI.WinForms.GunaTextBox();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gunaLabel1.Location = new System.Drawing.Point(28, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(127, 21);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Datos de mesa";
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
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.TxtNumComensales);
            this.gunaGroupBox1.Controls.Add(this.TxtDescripcion);
            this.gunaGroupBox1.Controls.Add(this.TxtNumero);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(75, 136);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(611, 279);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel5.Location = new System.Drawing.Point(57, 187);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(182, 20);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Número de comensales";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel4.Location = new System.Drawing.Point(76, 124);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Descripción";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(67, 55);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(134, 20);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Número de mesa";
            // 
            // TxtNumComensales
            // 
            this.TxtNumComensales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumComensales.BackColor = System.Drawing.Color.Transparent;
            this.TxtNumComensales.BaseColor = System.Drawing.Color.White;
            this.TxtNumComensales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNumComensales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNumComensales.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNumComensales.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNumComensales.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNumComensales.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNumComensales.Location = new System.Drawing.Point(267, 177);
            this.TxtNumComensales.Name = "TxtNumComensales";
            this.TxtNumComensales.PasswordChar = '\0';
            this.TxtNumComensales.Radius = 10;
            this.TxtNumComensales.Size = new System.Drawing.Size(306, 30);
            this.TxtNumComensales.TabIndex = 3;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.TxtDescripcion.BaseColor = System.Drawing.Color.White;
            this.TxtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtDescripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtDescripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtDescripcion.Location = new System.Drawing.Point(267, 114);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.Radius = 10;
            this.TxtDescripcion.Size = new System.Drawing.Size(306, 30);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumero.BackColor = System.Drawing.Color.Transparent;
            this.TxtNumero.BaseColor = System.Drawing.Color.White;
            this.TxtNumero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNumero.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNumero.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNumero.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNumero.Location = new System.Drawing.Point(267, 55);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.PasswordChar = '\0';
            this.TxtNumero.Radius = 10;
            this.TxtNumero.Size = new System.Drawing.Size(306, 30);
            this.TxtNumero.TabIndex = 1;
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
            this.BtnCerrarHijo.Location = new System.Drawing.Point(711, 11);
            this.BtnCerrarHijo.Name = "BtnCerrarHijo";
            this.BtnCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.BtnCerrarHijo.TabIndex = 12;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
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
            this.BtnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGuardar.Location = new System.Drawing.Point(306, 509);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardar.OnHoverImage = null;
            this.BtnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardar.Radius = 20;
            this.BtnGuardar.Size = new System.Drawing.Size(160, 42);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmAddMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 646);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCerrarHijo);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesas";
            this.Text = "FrmAddMesas";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox TxtNumComensales;
        private Guna.UI.WinForms.GunaTextBox TxtDescripcion;
        private Guna.UI.WinForms.GunaTextBox TxtNumero;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaButton BtnGuardar;
    }
}