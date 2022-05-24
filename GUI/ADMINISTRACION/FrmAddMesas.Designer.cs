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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.TxtNumCom = new Guna.UI.WinForms.GunaTextBox();
            this.TxtNumeroMesa = new Guna.UI.WinForms.GunaTextBox();
            this.TxtID = new Guna.UI.WinForms.GunaTextBox();
            this.lblApeM = new Guna.UI.WinForms.GunaLabel();
            this.lblNumeroMesa = new Guna.UI.WinForms.GunaLabel();
            this.lblNombre = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.BtnGuardar = new Guna.UI.WinForms.GunaButton();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.gunaPanel1.Controls.Add(this.BtnCerrarHijo);
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.BtnGuardar);
            this.gunaPanel1.Location = new System.Drawing.Point(-1, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 0;
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
            this.gunaGroupBox1.Controls.Add(this.txtDesc);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.TxtNumCom);
            this.gunaGroupBox1.Controls.Add(this.TxtNumeroMesa);
            this.gunaGroupBox1.Controls.Add(this.TxtID);
            this.gunaGroupBox1.Controls.Add(this.lblApeM);
            this.gunaGroupBox1.Controls.Add(this.lblNumeroMesa);
            this.gunaGroupBox1.Controls.Add(this.lblNombre);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Empty;
            this.gunaGroupBox1.Location = new System.Drawing.Point(91, 166);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(578, 234);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // TxtNumCom
            // 
            this.TxtNumCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumCom.BackColor = System.Drawing.Color.Transparent;
            this.TxtNumCom.BaseColor = System.Drawing.Color.White;
            this.TxtNumCom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNumCom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNumCom.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNumCom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNumCom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNumCom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumCom.Location = new System.Drawing.Point(239, 118);
            this.TxtNumCom.Name = "TxtNumCom";
            this.TxtNumCom.PasswordChar = '\0';
            this.TxtNumCom.Radius = 10;
            this.TxtNumCom.Size = new System.Drawing.Size(306, 30);
            this.TxtNumCom.TabIndex = 9;
            // 
            // TxtNumeroMesa
            // 
            this.TxtNumeroMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumeroMesa.BackColor = System.Drawing.Color.Transparent;
            this.TxtNumeroMesa.BaseColor = System.Drawing.Color.White;
            this.TxtNumeroMesa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtNumeroMesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNumeroMesa.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNumeroMesa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtNumeroMesa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNumeroMesa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroMesa.Location = new System.Drawing.Point(239, 64);
            this.TxtNumeroMesa.Name = "TxtNumeroMesa";
            this.TxtNumeroMesa.PasswordChar = '\0';
            this.TxtNumeroMesa.Radius = 10;
            this.TxtNumeroMesa.Size = new System.Drawing.Size(306, 30);
            this.TxtNumeroMesa.TabIndex = 8;
            this.TxtNumeroMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroMesa_KeyPress);
            // 
            // TxtID
            // 
            this.TxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtID.BackColor = System.Drawing.Color.Transparent;
            this.TxtID.BaseColor = System.Drawing.Color.White;
            this.TxtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtID.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(239, 9);
            this.TxtID.Name = "TxtID";
            this.TxtID.PasswordChar = '\0';
            this.TxtID.Radius = 10;
            this.TxtID.Size = new System.Drawing.Size(306, 30);
            this.TxtID.TabIndex = 7;
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // lblApeM
            // 
            this.lblApeM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApeM.AutoSize = true;
            this.lblApeM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeM.Location = new System.Drawing.Point(45, 119);
            this.lblApeM.Name = "lblApeM";
            this.lblApeM.Size = new System.Drawing.Size(184, 20);
            this.lblApeM.TabIndex = 2;
            this.lblApeM.Text = "Numero de Comensales";
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMesa.Location = new System.Drawing.Point(45, 65);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(136, 20);
            this.lblNumeroMesa.TabIndex = 1;
            this.lblNumeroMesa.Text = "Numero de Mesa";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(25, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "ID";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(87, 122);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(145, 21);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "Datos de la Mesa";
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
            this.BtnGuardar.Location = new System.Drawing.Point(310, 441);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardar.OnHoverImage = null;
            this.BtnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardar.Radius = 20;
            this.BtnGuardar.Size = new System.Drawing.Size(160, 42);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
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
            this.BtnCerrarHijo.Location = new System.Drawing.Point(711, 3);
            this.BtnCerrarHijo.Name = "BtnCerrarHijo";
            this.BtnCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.BtnCerrarHijo.TabIndex = 15;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(45, 173);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 20);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Descripcion";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtDesc.BaseColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDesc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.txtDesc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(239, 173);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.Radius = 10;
            this.txtDesc.Size = new System.Drawing.Size(306, 30);
            this.txtDesc.TabIndex = 11;
            // 
            // FrmAddMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMesas";
            this.Text = "FrmAddMesas";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox TxtNumCom;
        private Guna.UI.WinForms.GunaTextBox TxtNumeroMesa;
        private Guna.UI.WinForms.GunaTextBox TxtID;
        private Guna.UI.WinForms.GunaLabel lblApeM;
        private Guna.UI.WinForms.GunaLabel lblNumeroMesa;
        private Guna.UI.WinForms.GunaLabel lblNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaTextBox txtDesc;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}