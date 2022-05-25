namespace GUI.ADMINISTRACION
{
    partial class FrmAddClasificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddClasificacion));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnGuardarCla = new Guna.UI.WinForms.GunaButton();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.GrupClasificacion = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TxtDescripcionClas = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNombreClasificacion = new Guna.UI.WinForms.GunaTextBox();
            this.GrupClasificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(178, 21);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Agregar Clasificación";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // BtnGuardarCla
            // 
            this.BtnGuardarCla.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnGuardarCla.AnimationHoverSpeed = 0.07F;
            this.BtnGuardarCla.AnimationSpeed = 0.03F;
            this.BtnGuardarCla.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCla.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.BtnGuardarCla.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardarCla.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGuardarCla.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGuardarCla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardarCla.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCla.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarCla.Image")));
            this.BtnGuardarCla.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardarCla.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGuardarCla.Location = new System.Drawing.Point(281, 442);
            this.BtnGuardarCla.Name = "BtnGuardarCla";
            this.BtnGuardarCla.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnGuardarCla.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardarCla.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardarCla.OnHoverImage = null;
            this.BtnGuardarCla.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardarCla.Radius = 20;
            this.BtnGuardarCla.Size = new System.Drawing.Size(170, 46);
            this.BtnGuardarCla.TabIndex = 9;
            this.BtnGuardarCla.Text = "Guardar";
            this.BtnGuardarCla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnCerrarHijo.TabIndex = 8;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // GrupClasificacion
            // 
            this.GrupClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.GrupClasificacion.BaseColor = System.Drawing.Color.LightCyan;
            this.GrupClasificacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GrupClasificacion.BorderSize = 1;
            this.GrupClasificacion.Controls.Add(this.gunaLabel3);
            this.GrupClasificacion.Controls.Add(this.gunaLabel2);
            this.GrupClasificacion.Controls.Add(this.TxtDescripcionClas);
            this.GrupClasificacion.Controls.Add(this.TxtNombreClasificacion);
            this.GrupClasificacion.LineColor = System.Drawing.Color.Empty;
            this.GrupClasificacion.Location = new System.Drawing.Point(33, 109);
            this.GrupClasificacion.Name = "GrupClasificacion";
            this.GrupClasificacion.Size = new System.Drawing.Size(653, 217);
            this.GrupClasificacion.TabIndex = 10;
            this.GrupClasificacion.TextLocation = new System.Drawing.Point(10, 8);
            this.GrupClasificacion.Click += new System.EventHandler(this.GrupClasificacion_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(68, 111);
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
            this.gunaLabel2.Location = new System.Drawing.Point(68, 36);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 20);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Nombre";
            // 
            // TxtDescripcionClas
            // 
            this.TxtDescripcionClas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescripcionClas.BackColor = System.Drawing.Color.Transparent;
            this.TxtDescripcionClas.BaseColor = System.Drawing.Color.White;
            this.TxtDescripcionClas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtDescripcionClas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescripcionClas.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtDescripcionClas.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtDescripcionClas.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDescripcionClas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionClas.Location = new System.Drawing.Point(219, 111);
            this.TxtDescripcionClas.Name = "TxtDescripcionClas";
            this.TxtDescripcionClas.PasswordChar = '\0';
            this.TxtDescripcionClas.Radius = 10;
            this.TxtDescripcionClas.Size = new System.Drawing.Size(391, 30);
            this.TxtDescripcionClas.TabIndex = 8;
            // 
            // TxtNombreClasificacion
            // 
            this.TxtNombreClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombreClasificacion.BaseColor = System.Drawing.Color.White;
            this.TxtNombreClasificacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNombreClasificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreClasificacion.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNombreClasificacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNombreClasificacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNombreClasificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreClasificacion.Location = new System.Drawing.Point(219, 36);
            this.TxtNombreClasificacion.Name = "TxtNombreClasificacion";
            this.TxtNombreClasificacion.PasswordChar = '\0';
            this.TxtNombreClasificacion.Radius = 10;
            this.TxtNombreClasificacion.Size = new System.Drawing.Size(391, 30);
            this.TxtNombreClasificacion.TabIndex = 7;
            // 
            // FrmAddClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.BtnGuardarCla);
            this.Controls.Add(this.GrupClasificacion);
            this.Controls.Add(this.BtnCerrarHijo);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddClasificacion";
            this.Text = "FrmAddClasificacion";
            this.GrupClasificacion.ResumeLayout(false);
            this.GrupClasificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaButton BtnGuardarCla;
        private Guna.UI.WinForms.GunaGroupBox GrupClasificacion;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox TxtDescripcionClas;
        private Guna.UI.WinForms.GunaTextBox TxtNombreClasificacion;
    }
}