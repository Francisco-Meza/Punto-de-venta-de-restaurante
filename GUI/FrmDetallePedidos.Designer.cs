namespace GUI
{
    partial class FrmDetallePedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallePedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.NumCantidad = new Guna.UI.WinForms.GunaNumeric();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.dgvProductosPedido = new Guna.UI.WinForms.GunaDataGridView();
            this.columnIdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductos = new Guna.UI.WinForms.GunaComboBox();
            this.cbClasificacion = new Guna.UI.WinForms.GunaComboBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.gunaPanel1.Controls.Add(this.label4);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.btnAgregar);
            this.gunaPanel1.Controls.Add(this.btnEditar);
            this.gunaPanel1.Controls.Add(this.NumCantidad);
            this.gunaPanel1.Controls.Add(this.btnEliminar);
            this.gunaPanel1.Controls.Add(this.btnGuardar);
            this.gunaPanel1.Controls.Add(this.dgvProductosPedido);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.cbProductos);
            this.gunaPanel1.Controls.Add(this.cbClasificacion);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(757, 542);
            this.gunaPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clasificación:";
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
            this.btnAgregar.Location = new System.Drawing.Point(99, 476);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverImage = null;
            this.btnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregar.Radius = 20;
            this.btnAgregar.Size = new System.Drawing.Size(160, 42);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditar
            // 
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.btnEditar.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(139, 81);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Radius = 10;
            this.btnEditar.Size = new System.Drawing.Size(90, 28);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
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
            this.NumCantidad.Location = new System.Drawing.Point(580, 79);
            this.NumCantidad.Maximum = ((long)(9999999));
            this.NumCantidad.Minimum = ((long)(1));
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Radius = 10;
            this.NumCantidad.Size = new System.Drawing.Size(75, 30);
            this.NumCantidad.TabIndex = 5;
            this.NumCantidad.Value = ((long)(1));
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(495, 476);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 20;
            this.btnEliminar.Size = new System.Drawing.Size(160, 42);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(302, 476);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Radius = 20;
            this.btnGuardar.Size = new System.Drawing.Size(160, 42);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvProductosPedido
            // 
            this.dgvProductosPedido.AllowUserToAddRows = false;
            this.dgvProductosPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvProductosPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductosPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductosPedido.ColumnHeadersHeight = 40;
            this.dgvProductosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdDetalle,
            this.columnIdPedido,
            this.columnIdProducto,
            this.columnCantidad,
            this.columnPrecio});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosPedido.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductosPedido.EnableHeadersVisualStyles = false;
            this.dgvProductosPedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvProductosPedido.Location = new System.Drawing.Point(73, 130);
            this.dgvProductosPedido.Name = "dgvProductosPedido";
            this.dgvProductosPedido.ReadOnly = true;
            this.dgvProductosPedido.RowHeadersVisible = false;
            this.dgvProductosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosPedido.Size = new System.Drawing.Size(604, 284);
            this.dgvProductosPedido.TabIndex = 2;
            this.dgvProductosPedido.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dgvProductosPedido.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvProductosPedido.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductosPedido.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductosPedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductosPedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductosPedido.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductosPedido.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvProductosPedido.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvProductosPedido.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductosPedido.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProductosPedido.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductosPedido.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductosPedido.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProductosPedido.ThemeStyle.ReadOnly = true;
            this.dgvProductosPedido.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvProductosPedido.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductosPedido.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProductosPedido.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductosPedido.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProductosPedido.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvProductosPedido.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // columnIdDetalle
            // 
            this.columnIdDetalle.HeaderText = "No.-";
            this.columnIdDetalle.Name = "columnIdDetalle";
            this.columnIdDetalle.ReadOnly = true;
            // 
            // columnIdPedido
            // 
            this.columnIdPedido.HeaderText = "No.- Pedido";
            this.columnIdPedido.Name = "columnIdPedido";
            this.columnIdPedido.ReadOnly = true;
            // 
            // columnIdProducto
            // 
            this.columnIdProducto.HeaderText = "Clave Producto";
            this.columnIdProducto.Name = "columnIdProducto";
            this.columnIdProducto.ReadOnly = true;
            // 
            // columnCantidad
            // 
            this.columnCantidad.HeaderText = "Cantidad";
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.ReadOnly = true;
            // 
            // columnPrecio
            // 
            this.columnPrecio.HeaderText = "Precio unitario";
            this.columnPrecio.Name = "columnPrecio";
            this.columnPrecio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalles de pedido";
            // 
            // cbProductos
            // 
            this.cbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProductos.BackColor = System.Drawing.Color.Transparent;
            this.cbProductos.BaseColor = System.Drawing.Color.White;
            this.cbProductos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.cbProductos.BorderSize = 1;
            this.cbProductos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.FocusedColor = System.Drawing.Color.Empty;
            this.cbProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductos.ForeColor = System.Drawing.Color.Black;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(420, 81);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbProductos.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbProductos.Radius = 10;
            this.cbProductos.Size = new System.Drawing.Size(125, 28);
            this.cbProductos.TabIndex = 0;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.cbClasificacion.BaseColor = System.Drawing.Color.White;
            this.cbClasificacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.cbClasificacion.BorderSize = 1;
            this.cbClasificacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasificacion.FocusedColor = System.Drawing.Color.Empty;
            this.cbClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasificacion.ForeColor = System.Drawing.Color.Black;
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(254, 81);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbClasificacion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbClasificacion.Radius = 10;
            this.cbClasificacion.Size = new System.Drawing.Size(125, 28);
            this.cbClasificacion.TabIndex = 0;
 
            // 
            // FrmDetallePedidos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetallePedidos";
            this.Text = "FrmDetallePedidos";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaComboBox cbClasificacion;
        private Guna.UI.WinForms.GunaNumeric NumCantidad;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private Guna.UI.WinForms.GunaDataGridView dgvProductosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecio;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cbProductos;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}