namespace GUI.ADMINISTRACION
{
    partial class FrmCuentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.BtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.BtnEditar = new Guna.UI.WinForms.GunaButton();
            this.BtnAgregar = new Guna.UI.WinForms.GunaButton();
            this.dgvClasificacion = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
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
            this.BtnEliminar.Location = new System.Drawing.Point(651, 467);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEliminar.OnHoverImage = null;
            this.BtnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEliminar.Radius = 20;
            this.BtnEliminar.Size = new System.Drawing.Size(203, 49);
            this.BtnEliminar.TabIndex = 46;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnEditar.Location = new System.Drawing.Point(349, 467);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEditar.OnHoverImage = null;
            this.BtnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEditar.Radius = 20;
            this.BtnEditar.Size = new System.Drawing.Size(207, 49);
            this.BtnEditar.TabIndex = 45;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnAgregar.Location = new System.Drawing.Point(69, 467);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.BtnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAgregar.OnHoverImage = null;
            this.BtnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAgregar.Radius = 20;
            this.BtnAgregar.Size = new System.Drawing.Size(192, 49);
            this.BtnAgregar.TabIndex = 44;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvClasificacion
            // 
            this.dgvClasificacion.AllowUserToAddRows = false;
            this.dgvClasificacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvClasificacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasificacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasificacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClasificacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClasificacion.ColumnHeadersHeight = 21;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasificacion.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClasificacion.EnableHeadersVisualStyles = false;
            this.dgvClasificacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvClasificacion.Location = new System.Drawing.Point(48, 109);
            this.dgvClasificacion.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClasificacion.Name = "dgvClasificacion";
            this.dgvClasificacion.ReadOnly = true;
            this.dgvClasificacion.RowHeadersVisible = false;
            this.dgvClasificacion.RowHeadersWidth = 51;
            this.dgvClasificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasificacion.Size = new System.Drawing.Size(885, 318);
            this.dgvClasificacion.TabIndex = 47;
            this.dgvClasificacion.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dgvClasificacion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvClasificacion.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClasificacion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClasificacion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClasificacion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClasificacion.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClasificacion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvClasificacion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvClasificacion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClasificacion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClasificacion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClasificacion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClasificacion.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvClasificacion.ThemeStyle.ReadOnly = true;
            this.dgvClasificacion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvClasificacion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClasificacion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClasificacion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClasificacion.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClasificacion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvClasificacion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(44, 30);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(92, 23);
            this.gunaLabel1.TabIndex = 48;
            this.gunaLabel1.Text = "Cuentas";
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(991, 563);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dgvClasificacion);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCuentas";
            this.Text = "FrmCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton BtnEliminar;
        private Guna.UI.WinForms.GunaButton BtnEditar;
        private Guna.UI.WinForms.GunaButton BtnAgregar;
        private Guna.UI.WinForms.GunaDataGridView dgvClasificacion;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}