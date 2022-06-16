namespace GUI
{
    partial class FrmAgregarProductoDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProductoDetalle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.BtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.NumCantidad = new Guna.UI.WinForms.GunaNumeric();
            this.Buscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.dgvProductos = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.gunaPanel1.Controls.Add(this.BtnEliminar);
            this.gunaPanel1.Controls.Add(this.btnAgregar);
            this.gunaPanel1.Controls.Add(this.NumCantidad);
            this.gunaPanel1.Controls.Add(this.Buscar);
            this.gunaPanel1.Controls.Add(this.TxtBuscar);
            this.gunaPanel1.Controls.Add(this.dgvProductos);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 450);
            this.gunaPanel1.TabIndex = 0;
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
            this.BtnEliminar.Location = new System.Drawing.Point(490, 396);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEliminar.OnHoverImage = null;
            this.BtnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEliminar.Radius = 20;
            this.BtnEliminar.Size = new System.Drawing.Size(160, 42);
            this.BtnEliminar.TabIndex = 47;
            this.BtnEliminar.Text = "Cerrar";
            this.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.AnimationHoverSpeed = 0.07F;
            this.btnAgregar.AnimationSpeed = 0.03F;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregar.Location = new System.Drawing.Point(301, 396);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverImage = null;
            this.btnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregar.Radius = 20;
            this.btnAgregar.Size = new System.Drawing.Size(160, 42);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // NumCantidad
            // 
            this.NumCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumCantidad.BackColor = System.Drawing.Color.Transparent;
            this.NumCantidad.BaseColor = System.Drawing.Color.White;
            this.NumCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.NumCantidad.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.NumCantidad.ButtonForeColor = System.Drawing.Color.White;
            this.NumCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NumCantidad.ForeColor = System.Drawing.Color.Black;
            this.NumCantidad.Location = new System.Drawing.Point(659, 46);
            this.NumCantidad.Maximum = ((long)(9999999));
            this.NumCantidad.Minimum = ((long)(1));
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Radius = 10;
            this.NumCantidad.Size = new System.Drawing.Size(75, 30);
            this.NumCantidad.TabIndex = 6;
            this.NumCantidad.Value = ((long)(1));
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(76, 21);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(40, 13);
            this.Buscar.TabIndex = 5;
            this.Buscar.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.TxtBuscar.BaseColor = System.Drawing.Color.White;
            this.TxtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.TxtBuscar.BorderSize = 1;
            this.TxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.TxtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBuscar.Location = new System.Drawing.Point(65, 46);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.Radius = 10;
            this.TxtBuscar.Size = new System.Drawing.Size(466, 30);
            this.TxtBuscar.TabIndex = 4;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.ColumnHeadersHeight = 40;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvProductos.Location = new System.Drawing.Point(65, 100);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(669, 275);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProductos.ThemeStyle.ReadOnly = true;
            this.dgvProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // FrmAgregarProductoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarProductoDetalle";
            this.Text = "Agregar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAgregarProductoDetalle_FormClosed);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaDataGridView dgvProductos;
        private Guna.UI.WinForms.GunaTextBox TxtBuscar;
        private System.Windows.Forms.Label Buscar;
        private Guna.UI.WinForms.GunaNumeric NumCantidad;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private Guna.UI.WinForms.GunaButton BtnEliminar;
    }
}