namespace GUI
{
    partial class FrmMesas
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnCerrarHijo = new FontAwesome.Sharp.IconButton();
            this.dgvMesas = new Guna.UI.WinForms.GunaDataGridView();
            this.id_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumComensales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(127, 21);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Mesas del local";
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
            this.BtnCerrarHijo.Location = new System.Drawing.Point(710, 3);
            this.BtnCerrarHijo.Name = "BtnCerrarHijo";
            this.BtnCerrarHijo.Size = new System.Drawing.Size(46, 39);
            this.BtnCerrarHijo.TabIndex = 6;
            this.BtnCerrarHijo.UseVisualStyleBackColor = true;
            this.BtnCerrarHijo.Click += new System.EventHandler(this.BtnCerrarHijo_Click);
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvMesas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesas.ColumnHeadersHeight = 40;
            this.dgvMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mesa,
            this.NumMesa,
            this.Descrip,
            this.NumComensales});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMesas.EnableHeadersVisualStyles = false;
            this.dgvMesas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvMesas.Location = new System.Drawing.Point(12, 71);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesas.Size = new System.Drawing.Size(733, 383);
            this.dgvMesas.TabIndex = 0;
            this.dgvMesas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dgvMesas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvMesas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMesas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMesas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMesas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMesas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMesas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvMesas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvMesas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMesas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMesas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMesas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMesas.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMesas.ThemeStyle.ReadOnly = true;
            this.dgvMesas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvMesas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMesas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMesas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMesas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMesas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvMesas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // id_mesa
            // 
            this.id_mesa.HeaderText = "ID";
            this.id_mesa.Name = "id_mesa";
            this.id_mesa.ReadOnly = true;
            // 
            // NumMesa
            // 
            this.NumMesa.HeaderText = "Número de mesa";
            this.NumMesa.Name = "NumMesa";
            this.NumMesa.ReadOnly = true;
            // 
            // Descrip
            // 
            this.Descrip.HeaderText = "Descripción";
            this.Descrip.Name = "Descrip";
            this.Descrip.ReadOnly = true;
            // 
            // NumComensales
            // 
            this.NumComensales.HeaderText = "Número de comensales";
            this.NumComensales.Name = "NumComensales";
            this.NumComensales.ReadOnly = true;
            // 
            // FrmMesas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.BtnCerrarHijo);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMesas";
            this.Text = "FrmMesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private FontAwesome.Sharp.IconButton BtnCerrarHijo;
        private Guna.UI.WinForms.GunaDataGridView dgvMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumComensales;
    }
}