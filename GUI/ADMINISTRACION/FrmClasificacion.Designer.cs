namespace GUI.ADMINISTRACION
{
    partial class FrmClasificacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClasificacion));
            this.dgvClasificacion = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnElimiCla = new Guna.UI.WinForms.GunaButton();
            this.btnEditarC = new Guna.UI.WinForms.GunaButton();
            this.btnAgregarCla = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClasificacion
            // 
            this.dgvClasificacion.AllowUserToAddRows = false;
            this.dgvClasificacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvClasificacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasificacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasificacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClasificacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClasificacion.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasificacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClasificacion.EnableHeadersVisualStyles = false;
            this.dgvClasificacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvClasificacion.Location = new System.Drawing.Point(45, 48);
            this.dgvClasificacion.Name = "dgvClasificacion";
            this.dgvClasificacion.ReadOnly = true;
            this.dgvClasificacion.RowHeadersVisible = false;
            this.dgvClasificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasificacion.Size = new System.Drawing.Size(668, 291);
            this.dgvClasificacion.TabIndex = 0;
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
            this.dgvClasificacion.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvClasificacion.ThemeStyle.ReadOnly = true;
            this.dgvClasificacion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvClasificacion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClasificacion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClasificacion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClasificacion.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClasificacion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvClasificacion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btnElimiCla);
            this.gunaPanel1.Controls.Add(this.btnEditarC);
            this.gunaPanel1.Controls.Add(this.btnAgregarCla);
            this.gunaPanel1.Controls.Add(this.btnClose);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.dgvClasificacion);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(758, 543);
            this.gunaPanel1.TabIndex = 44;
            // 
            // btnElimiCla
            // 
            this.btnElimiCla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimiCla.AnimationHoverSpeed = 0.07F;
            this.btnElimiCla.AnimationSpeed = 0.03F;
            this.btnElimiCla.BackColor = System.Drawing.Color.Transparent;
            this.btnElimiCla.BaseColor = System.Drawing.Color.Red;
            this.btnElimiCla.BorderColor = System.Drawing.Color.Black;
            this.btnElimiCla.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnElimiCla.FocusedColor = System.Drawing.Color.Empty;
            this.btnElimiCla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimiCla.ForeColor = System.Drawing.Color.White;
            this.btnElimiCla.Image = ((System.Drawing.Image)(resources.GetObject("btnElimiCla.Image")));
            this.btnElimiCla.ImageSize = new System.Drawing.Size(20, 20);
            this.btnElimiCla.Location = new System.Drawing.Point(503, 428);
            this.btnElimiCla.Name = "btnElimiCla";
            this.btnElimiCla.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnElimiCla.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnElimiCla.OnHoverForeColor = System.Drawing.Color.White;
            this.btnElimiCla.OnHoverImage = null;
            this.btnElimiCla.OnPressedColor = System.Drawing.Color.Black;
            this.btnElimiCla.Radius = 20;
            this.btnElimiCla.Size = new System.Drawing.Size(144, 40);
            this.btnElimiCla.TabIndex = 15;
            this.btnElimiCla.Text = "Eliminar";
            // 
            // btnEditarC
            // 
            this.btnEditarC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarC.AnimationHoverSpeed = 0.07F;
            this.btnEditarC.AnimationSpeed = 0.03F;
            this.btnEditarC.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.btnEditarC.BorderColor = System.Drawing.Color.Black;
            this.btnEditarC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditarC.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditarC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarC.ForeColor = System.Drawing.Color.White;
            this.btnEditarC.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarC.Image")));
            this.btnEditarC.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditarC.Location = new System.Drawing.Point(277, 428);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.btnEditarC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditarC.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditarC.OnHoverImage = null;
            this.btnEditarC.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditarC.Radius = 20;
            this.btnEditarC.Size = new System.Drawing.Size(144, 40);
            this.btnEditarC.TabIndex = 15;
            this.btnEditarC.Text = "Editar";
            this.btnEditarC.Click += new System.EventHandler(this.btnEditarC_Click);
            // 
            // btnAgregarCla
            // 
            this.btnAgregarCla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarCla.AnimationHoverSpeed = 0.07F;
            this.btnAgregarCla.AnimationSpeed = 0.03F;
            this.btnAgregarCla.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCla.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.btnAgregarCla.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarCla.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarCla.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarCla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCla.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCla.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCla.Image")));
            this.btnAgregarCla.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarCla.Location = new System.Drawing.Point(45, 428);
            this.btnAgregarCla.Name = "btnAgregarCla";
            this.btnAgregarCla.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.btnAgregarCla.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarCla.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarCla.OnHoverImage = null;
            this.btnAgregarCla.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarCla.Radius = 20;
            this.btnAgregarCla.Size = new System.Drawing.Size(144, 40);
            this.btnAgregarCla.TabIndex = 15;
            this.btnAgregarCla.Text = "Agregar";
            this.btnAgregarCla.Click += new System.EventHandler(this.btnAgregarCla_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 40;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(709, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 39);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 7);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(112, 21);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = " Clasificación";
            // 
            // FrmClasificacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(758, 543);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClasificacion";
            this.Text = "FrmClasificacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvClasificacion;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnElimiCla;
        private Guna.UI.WinForms.GunaButton btnEditarC;
        private Guna.UI.WinForms.GunaButton btnAgregarCla;
        private FontAwesome.Sharp.IconButton btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}