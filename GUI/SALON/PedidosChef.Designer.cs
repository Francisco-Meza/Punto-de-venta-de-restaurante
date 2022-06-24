namespace GUI.SALON
{
    partial class PedidosChef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosChef));
            this.BtnPreparacion = new Guna.UI.WinForms.GunaButton();
            this.BtnDespacho = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.btncargar = new Guna.UI.WinForms.GunaButton();
            this.hora = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gunaGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPreparacion
            // 
            this.BtnPreparacion.AnimationHoverSpeed = 0.07F;
            this.BtnPreparacion.AnimationSpeed = 0.03F;
            this.BtnPreparacion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.BtnPreparacion.BorderColor = System.Drawing.Color.Black;
            this.BtnPreparacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPreparacion.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPreparacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreparacion.ForeColor = System.Drawing.Color.Black;
            this.BtnPreparacion.Image = ((System.Drawing.Image)(resources.GetObject("BtnPreparacion.Image")));
            this.BtnPreparacion.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPreparacion.Location = new System.Drawing.Point(16, 109);
            this.BtnPreparacion.Name = "BtnPreparacion";
            this.BtnPreparacion.OnHoverBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnPreparacion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPreparacion.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnPreparacion.OnHoverImage = null;
            this.BtnPreparacion.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPreparacion.Size = new System.Drawing.Size(160, 42);
            this.BtnPreparacion.TabIndex = 12;
            this.BtnPreparacion.Text = "En preparación";
            this.BtnPreparacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPreparacion.Click += new System.EventHandler(this.BtnPreparacion_Click);
            // 
            // BtnDespacho
            // 
            this.BtnDespacho.AnimationHoverSpeed = 0.07F;
            this.BtnDespacho.AnimationSpeed = 0.03F;
            this.BtnDespacho.BaseColor = System.Drawing.Color.Crimson;
            this.BtnDespacho.BorderColor = System.Drawing.Color.Black;
            this.BtnDespacho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDespacho.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDespacho.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDespacho.ForeColor = System.Drawing.Color.Black;
            this.BtnDespacho.Image = ((System.Drawing.Image)(resources.GetObject("BtnDespacho.Image")));
            this.BtnDespacho.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDespacho.Location = new System.Drawing.Point(16, 173);
            this.BtnDespacho.Name = "BtnDespacho";
            this.BtnDespacho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnDespacho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDespacho.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDespacho.OnHoverImage = null;
            this.BtnDespacho.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDespacho.Size = new System.Drawing.Size(160, 42);
            this.BtnDespacho.TabIndex = 13;
            this.BtnDespacho.Text = "Despachado";
            this.BtnDespacho.Click += new System.EventHandler(this.BtnDespacho_Click);
            // 
            // gunaGroupBox4
            // 
            this.gunaGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGroupBox4.BorderSize = 1;
            this.gunaGroupBox4.Controls.Add(this.btncargar);
            this.gunaGroupBox4.Controls.Add(this.hora);
            this.gunaGroupBox4.Controls.Add(this.BtnPreparacion);
            this.gunaGroupBox4.Controls.Add(this.BtnDespacho);
            this.gunaGroupBox4.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.Location = new System.Drawing.Point(569, 60);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Size = new System.Drawing.Size(186, 347);
            this.gunaGroupBox4.TabIndex = 14;
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btncargar
            // 
            this.btncargar.AnimationHoverSpeed = 0.07F;
            this.btncargar.AnimationSpeed = 0.03F;
            this.btncargar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncargar.BorderColor = System.Drawing.Color.Black;
            this.btncargar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncargar.FocusedColor = System.Drawing.Color.Empty;
            this.btncargar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargar.ForeColor = System.Drawing.Color.Black;
            this.btncargar.Image = ((System.Drawing.Image)(resources.GetObject("btncargar.Image")));
            this.btncargar.ImageSize = new System.Drawing.Size(20, 20);
            this.btncargar.Location = new System.Drawing.Point(16, 234);
            this.btncargar.Name = "btncargar";
            this.btncargar.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.btncargar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncargar.OnHoverForeColor = System.Drawing.Color.White;
            this.btncargar.OnHoverImage = null;
            this.btncargar.OnPressedColor = System.Drawing.Color.Black;
            this.btncargar.Size = new System.Drawing.Size(160, 42);
            this.btncargar.TabIndex = 15;
            this.btncargar.Text = "Actualizar";
            this.btncargar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(55, 15);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(51, 21);
            this.hora.TabIndex = 14;
            this.hora.Text = "Hora:";
            // 
            // panel1
            // 
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 309);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(289, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 309);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(8, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 312);
            this.panel3.TabIndex = 17;
            this.panel3.Visible = false;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel4
            // 
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(289, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 312);
            this.panel4.TabIndex = 18;
            this.panel4.Visible = false;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // PedidosChef
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 646);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaGroupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidosChef";
            this.Text = "PedidosChef";
            this.gunaGroupBox4.ResumeLayout(false);
            this.gunaGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton BtnPreparacion;
        private Guna.UI.WinForms.GunaButton BtnDespacho;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        private Guna.UI.WinForms.GunaButton btncargar;
        private Guna.UI.WinForms.GunaLabel hora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}