namespace GUI
{
    partial class FrmPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnAgregar = new Guna.UI.WinForms.GunaButton();
            this.BtnEditar = new Guna.UI.WinForms.GunaButton();
            this.BtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.dgvListaPersonal = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(33, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(142, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Lista del personal";
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
            this.BtnAgregar.Location = new System.Drawing.Point(92, 454);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAgregar.OnHoverImage = null;
            this.BtnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAgregar.Radius = 20;
            this.BtnAgregar.Size = new System.Drawing.Size(144, 40);
            this.BtnAgregar.TabIndex = 38;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            this.BtnEditar.Location = new System.Drawing.Point(311, 454);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEditar.OnHoverImage = null;
            this.BtnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEditar.Radius = 20;
            this.BtnEditar.Size = new System.Drawing.Size(167, 40);
            this.BtnEditar.TabIndex = 38;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.BtnEliminar.Location = new System.Drawing.Point(550, 454);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEliminar.OnHoverImage = null;
            this.BtnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEliminar.Radius = 20;
            this.BtnEliminar.Size = new System.Drawing.Size(152, 40);
            this.BtnEliminar.TabIndex = 38;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnCerrarHijo.Location = new System.Drawing.Point(719, 0);
            this.BtnCerrarHijo.Name = "BtnCerrarHijo";
            this.BtnCerrarHijo.Size = new System.Drawing.Size(36, 39);
            this.BtnCerrarHijo.TabIndex = 5;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.Controls.Add(this.dgvListaPersonal);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.BtnCerrarHijo);
            this.gunaPanel1.Controls.Add(this.BtnAgregar);
            this.gunaPanel1.Controls.Add(this.BtnEliminar);
            this.gunaPanel1.Controls.Add(this.BtnEditar);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(758, 543);
            this.gunaPanel1.TabIndex = 6;
            // 
            // dgvListaPersonal
            // 
            this.dgvListaPersonal.AllowUserToAddRows = false;
            this.dgvListaPersonal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvListaPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPersonal.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaPersonal.ColumnHeadersHeight = 40;
            this.dgvListaPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNomPersonal,
            this.ColumnApeP,
            this.ColumnApeM,
            this.ColumnFechaN,
            this.ColumnaTelefono,
            this.ColumnCorreo,
            this.ColumnContra,
            this.ColumnPuesto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPersonal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaPersonal.EnableHeadersVisualStyles = false;
            this.dgvListaPersonal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvListaPersonal.Location = new System.Drawing.Point(10, 64);
            this.dgvListaPersonal.Name = "dgvListaPersonal";
            this.dgvListaPersonal.ReadOnly = true;
            this.dgvListaPersonal.RowHeadersVisible = false;
            this.dgvListaPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPersonal.Size = new System.Drawing.Size(734, 320);
            this.dgvListaPersonal.TabIndex = 0;
            this.dgvListaPersonal.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dgvListaPersonal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvListaPersonal.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaPersonal.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaPersonal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaPersonal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaPersonal.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaPersonal.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvListaPersonal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvListaPersonal.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaPersonal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListaPersonal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaPersonal.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaPersonal.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvListaPersonal.ThemeStyle.ReadOnly = true;
            this.dgvListaPersonal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvListaPersonal.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaPersonal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListaPersonal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListaPersonal.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListaPersonal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvListaPersonal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNomPersonal
            // 
            this.ColumnNomPersonal.HeaderText = "Nombre";
            this.ColumnNomPersonal.Name = "ColumnNomPersonal";
            this.ColumnNomPersonal.ReadOnly = true;
            // 
            // ColumnApeP
            // 
            this.ColumnApeP.HeaderText = "Apellido paterno";
            this.ColumnApeP.Name = "ColumnApeP";
            this.ColumnApeP.ReadOnly = true;
            // 
            // ColumnApeM
            // 
            this.ColumnApeM.HeaderText = "Apellido materno";
            this.ColumnApeM.Name = "ColumnApeM";
            this.ColumnApeM.ReadOnly = true;
            // 
            // ColumnFechaN
            // 
            this.ColumnFechaN.HeaderText = "Fecha de nacimiento";
            this.ColumnFechaN.Name = "ColumnFechaN";
            this.ColumnFechaN.ReadOnly = true;
            // 
            // ColumnaTelefono
            // 
            this.ColumnaTelefono.HeaderText = "Teléfono";
            this.ColumnaTelefono.Name = "ColumnaTelefono";
            this.ColumnaTelefono.ReadOnly = true;
            // 
            // ColumnCorreo
            // 
            this.ColumnCorreo.HeaderText = "Correo";
            this.ColumnCorreo.Name = "ColumnCorreo";
            this.ColumnCorreo.ReadOnly = true;
            // 
            // ColumnContra
            // 
            this.ColumnContra.HeaderText = "Contraseña";
            this.ColumnContra.Name = "ColumnContra";
            this.ColumnContra.ReadOnly = true;
            // 
            // ColumnPuesto
            // 
            this.ColumnPuesto.HeaderText = "Puesto";
            this.ColumnPuesto.Name = "ColumnPuesto";
            this.ColumnPuesto.ReadOnly = true;
            // 
            // FrmPersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonal";
            this.Text = "FrmPersonal";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton BtnAgregar;
        private Guna.UI.WinForms.GunaButton BtnEditar;
        private Guna.UI.WinForms.GunaButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;

        private Guna.UI.WinForms.GunaDataGridView dgvListaPersonal;

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuesto;
    }
}