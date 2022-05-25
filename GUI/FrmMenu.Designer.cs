namespace GUI
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PanelMenu = new Guna.UI.WinForms.GunaPanel();
            this.BtnMesa = new Guna.UI.WinForms.GunaButton();
            this.BtnPuesto = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.BtnPedidosLocal = new Guna.UI.WinForms.GunaButton();
            this.BtnPerfil = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.BtnProductos = new Guna.UI.WinForms.GunaButton();
            this.BtnPersonal = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.BtnPedidoDomi = new Guna.UI.WinForms.GunaButton();
            this.BtnPedidos = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.PanelBarra = new Guna.UI.WinForms.GunaPanel();
            this.IconMaximizar = new FontAwesome.Sharp.IconButton();
            this.IconRestaurar = new FontAwesome.Sharp.IconButton();
            this.IconMinimizar = new FontAwesome.Sharp.IconButton();
            this.IconCerrar = new FontAwesome.Sharp.IconButton();
            this.PanelBarraInferior = new Guna.UI.WinForms.GunaPanel();
            this.PanelPadre = new Guna.UI.WinForms.GunaPanel();
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.PanelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.PanelMenu.Controls.Add(this.BtnMesa);
            this.PanelMenu.Controls.Add(this.BtnPuesto);
            this.PanelMenu.Controls.Add(this.gunaPanel4);
            this.PanelMenu.Controls.Add(this.gunaPanel2);
            this.PanelMenu.Controls.Add(this.gunaPanel3);
            this.PanelMenu.Controls.Add(this.gunaPanel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(193, 600);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnMesa
            // 
            this.BtnMesa.AnimationHoverSpeed = 0.07F;
            this.BtnMesa.AnimationSpeed = 0.03F;
            this.BtnMesa.BaseColor = System.Drawing.Color.Empty;
            this.BtnMesa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnMesa.BorderSize = 1;
            this.BtnMesa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnMesa.Enabled = false;
            this.BtnMesa.FocusedColor = System.Drawing.Color.Empty;
            this.BtnMesa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnMesa.ForeColor = System.Drawing.Color.Black;
            this.BtnMesa.Image = ((System.Drawing.Image)(resources.GetObject("BtnMesa.Image")));
            this.BtnMesa.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnMesa.Location = new System.Drawing.Point(0, 509);
            this.BtnMesa.Name = "BtnMesa";
            this.BtnMesa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMesa.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMesa.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnMesa.OnHoverImage = null;
            this.BtnMesa.OnPressedColor = System.Drawing.Color.Black;
            this.BtnMesa.Size = new System.Drawing.Size(193, 42);
            this.BtnMesa.TabIndex = 4;
            this.BtnMesa.Text = "Mesas";
            this.BtnMesa.Visible = false;
            this.BtnMesa.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // BtnPuesto
            // 
            this.BtnPuesto.AnimationHoverSpeed = 0.07F;
            this.BtnPuesto.AnimationSpeed = 0.03F;
            this.BtnPuesto.BaseColor = System.Drawing.Color.Empty;
            this.BtnPuesto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPuesto.BorderSize = 1;
            this.BtnPuesto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPuesto.Enabled = false;
            this.BtnPuesto.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPuesto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnPuesto.ForeColor = System.Drawing.Color.Black;
            this.BtnPuesto.Image = ((System.Drawing.Image)(resources.GetObject("BtnPuesto.Image")));
            this.BtnPuesto.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPuesto.Location = new System.Drawing.Point(0, 461);
            this.BtnPuesto.Name = "BtnPuesto";
            this.BtnPuesto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPuesto.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPuesto.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPuesto.OnHoverImage = null;
            this.BtnPuesto.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPuesto.Size = new System.Drawing.Size(193, 42);
            this.BtnPuesto.TabIndex = 2;
            this.BtnPuesto.Text = "Puestos";
            this.BtnPuesto.Visible = false;
            this.BtnPuesto.Click += new System.EventHandler(this.BtnPuesto_Click);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.BtnPedidosLocal);
            this.gunaPanel4.Controls.Add(this.BtnPerfil);
            this.gunaPanel4.Location = new System.Drawing.Point(0, 365);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(187, 100);
            this.gunaPanel4.TabIndex = 3;
            // 
            // BtnPedidosLocal
            // 
            this.BtnPedidosLocal.AnimationHoverSpeed = 0.07F;
            this.BtnPedidosLocal.AnimationSpeed = 0.03F;
            this.BtnPedidosLocal.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidosLocal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidosLocal.BorderSize = 1;
            this.BtnPedidosLocal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPedidosLocal.Enabled = false;
            this.BtnPedidosLocal.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPedidosLocal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnPedidosLocal.ForeColor = System.Drawing.Color.Black;
            this.BtnPedidosLocal.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidosLocal.Image")));
            this.BtnPedidosLocal.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPedidosLocal.Location = new System.Drawing.Point(0, 48);
            this.BtnPedidosLocal.Name = "BtnPedidosLocal";
            this.BtnPedidosLocal.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPedidosLocal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPedidosLocal.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPedidosLocal.OnHoverImage = null;
            this.BtnPedidosLocal.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPedidosLocal.Size = new System.Drawing.Size(193, 42);
            this.BtnPedidosLocal.TabIndex = 1;
            this.BtnPedidosLocal.Text = "Pedidos Local";
            this.BtnPedidosLocal.Visible = false;
            this.BtnPedidosLocal.Click += new System.EventHandler(this.BtnPedidosLocal_Click);
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.AnimationHoverSpeed = 0.07F;
            this.BtnPerfil.AnimationSpeed = 0.03F;
            this.BtnPerfil.BaseColor = System.Drawing.Color.Empty;
            this.BtnPerfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPerfil.BorderSize = 1;
            this.BtnPerfil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPerfil.Enabled = false;
            this.BtnPerfil.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPerfil.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnPerfil.ForeColor = System.Drawing.Color.Black;
            this.BtnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("BtnPerfil.Image")));
            this.BtnPerfil.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPerfil.Location = new System.Drawing.Point(0, 0);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPerfil.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPerfil.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPerfil.OnHoverImage = null;
            this.BtnPerfil.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPerfil.Size = new System.Drawing.Size(187, 42);
            this.BtnPerfil.TabIndex = 0;
            this.BtnPerfil.Text = "Perfil";
            this.BtnPerfil.Visible = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.BtnProductos);
            this.gunaPanel2.Controls.Add(this.BtnPersonal);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 173);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(190, 98);
            this.gunaPanel2.TabIndex = 1;
            // 
            // BtnProductos
            // 
            this.BtnProductos.AnimationHoverSpeed = 0.07F;
            this.BtnProductos.AnimationSpeed = 0.03F;
            this.BtnProductos.BaseColor = System.Drawing.Color.Empty;
            this.BtnProductos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnProductos.BorderSize = 1;
            this.BtnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnProductos.Enabled = false;
            this.BtnProductos.FocusedColor = System.Drawing.Color.Empty;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnProductos.ForeColor = System.Drawing.Color.Black;
            this.BtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductos.Image")));
            this.BtnProductos.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnProductos.Location = new System.Drawing.Point(0, 48);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnProductos.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnProductos.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnProductos.OnHoverImage = null;
            this.BtnProductos.OnPressedColor = System.Drawing.Color.Black;
            this.BtnProductos.Size = new System.Drawing.Size(195, 42);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.Visible = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.AnimationHoverSpeed = 0.07F;
            this.BtnPersonal.AnimationSpeed = 0.03F;
            this.BtnPersonal.BaseColor = System.Drawing.Color.Empty;
            this.BtnPersonal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPersonal.BorderSize = 1;
            this.BtnPersonal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonal.Enabled = false;
            this.BtnPersonal.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPersonal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.ForeColor = System.Drawing.Color.Black;
            this.BtnPersonal.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonal.Image")));
            this.BtnPersonal.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPersonal.Location = new System.Drawing.Point(0, 0);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPersonal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPersonal.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPersonal.OnHoverImage = null;
            this.BtnPersonal.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPersonal.Size = new System.Drawing.Size(190, 42);
            this.BtnPersonal.TabIndex = 0;
            this.BtnPersonal.Text = "Personal";
            this.BtnPersonal.Visible = false;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.BtnPedidoDomi);
            this.gunaPanel3.Controls.Add(this.BtnPedidos);
            this.gunaPanel3.Location = new System.Drawing.Point(3, 269);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(187, 98);
            this.gunaPanel3.TabIndex = 2;
            // 
            // BtnPedidoDomi
            // 
            this.BtnPedidoDomi.AnimationHoverSpeed = 0.07F;
            this.BtnPedidoDomi.AnimationSpeed = 0.03F;
            this.BtnPedidoDomi.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidoDomi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidoDomi.BorderSize = 1;
            this.BtnPedidoDomi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPedidoDomi.Enabled = false;
            this.BtnPedidoDomi.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPedidoDomi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidoDomi.ForeColor = System.Drawing.Color.Black;
            this.BtnPedidoDomi.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidoDomi.Image")));
            this.BtnPedidoDomi.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPedidoDomi.Location = new System.Drawing.Point(0, 48);
            this.BtnPedidoDomi.Name = "BtnPedidoDomi";
            this.BtnPedidoDomi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPedidoDomi.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPedidoDomi.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPedidoDomi.OnHoverImage = null;
            this.BtnPedidoDomi.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPedidoDomi.Size = new System.Drawing.Size(192, 42);
            this.BtnPedidoDomi.TabIndex = 1;
            this.BtnPedidoDomi.Text = "Pedidos Domicilio";
            this.BtnPedidoDomi.Visible = false;
            this.BtnPedidoDomi.Click += new System.EventHandler(this.BtnPedidoDomi_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.AnimationHoverSpeed = 0.07F;
            this.BtnPedidos.AnimationSpeed = 0.03F;
            this.BtnPedidos.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidos.BorderSize = 1;
            this.BtnPedidos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPedidos.Enabled = false;
            this.BtnPedidos.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPedidos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnPedidos.ForeColor = System.Drawing.Color.Black;
            this.BtnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidos.Image")));
            this.BtnPedidos.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPedidos.Location = new System.Drawing.Point(0, 0);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPedidos.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPedidos.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPedidos.OnHoverImage = null;
            this.BtnPedidos.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPedidos.Size = new System.Drawing.Size(187, 42);
            this.BtnPedidos.TabIndex = 0;
            this.BtnPedidos.Text = "Cajero";
            this.BtnPedidos.Visible = false;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnCajero_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaPanel1.BackgroundImage = global::GUI.Properties.Resources.Captura_de_pantalla__78__removebg_preview_removebg_preview;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(193, 167);
            this.gunaPanel1.TabIndex = 0;
            // 
            // PanelBarra
            // 
            this.PanelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.PanelBarra.Controls.Add(this.lblNombrePersona);
            this.PanelBarra.Controls.Add(this.IconMaximizar);
            this.PanelBarra.Controls.Add(this.IconRestaurar);
            this.PanelBarra.Controls.Add(this.IconMinimizar);
            this.PanelBarra.Controls.Add(this.IconCerrar);
            this.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarra.Location = new System.Drawing.Point(193, 0);
            this.PanelBarra.Name = "PanelBarra";
            this.PanelBarra.Size = new System.Drawing.Size(757, 39);
            this.PanelBarra.TabIndex = 1;
            this.PanelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarra_MouseDown);
            // 
            // IconMaximizar
            // 
            this.IconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMaximizar.FlatAppearance.BorderSize = 0;
            this.IconMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.IconMaximizar.IconColor = System.Drawing.Color.Black;
            this.IconMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMaximizar.IconSize = 40;
            this.IconMaximizar.Location = new System.Drawing.Point(647, -1);
            this.IconMaximizar.Name = "IconMaximizar";
            this.IconMaximizar.Size = new System.Drawing.Size(57, 40);
            this.IconMaximizar.TabIndex = 0;
            this.IconMaximizar.UseVisualStyleBackColor = true;
            this.IconMaximizar.Click += new System.EventHandler(this.IconMaximizar_Click);
            // 
            // IconRestaurar
            // 
            this.IconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconRestaurar.FlatAppearance.BorderSize = 0;
            this.IconRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.IconRestaurar.IconColor = System.Drawing.Color.Black;
            this.IconRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconRestaurar.IconSize = 40;
            this.IconRestaurar.Location = new System.Drawing.Point(647, -3);
            this.IconRestaurar.Name = "IconRestaurar";
            this.IconRestaurar.Size = new System.Drawing.Size(56, 49);
            this.IconRestaurar.TabIndex = 0;
            this.IconRestaurar.UseVisualStyleBackColor = true;
            this.IconRestaurar.Click += new System.EventHandler(this.IconRestaurar_Click);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizar.FlatAppearance.BorderSize = 0;
            this.IconMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.IconMinimizar.IconColor = System.Drawing.Color.Black;
            this.IconMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMinimizar.IconSize = 40;
            this.IconMinimizar.Location = new System.Drawing.Point(584, 1);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(56, 36);
            this.IconMinimizar.TabIndex = 0;
            this.IconMinimizar.UseVisualStyleBackColor = true;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.FlatAppearance.BorderSize = 0;
            this.IconCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.IconCerrar.IconColor = System.Drawing.Color.Black;
            this.IconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCerrar.IconSize = 40;
            this.IconCerrar.Location = new System.Drawing.Point(701, 3);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(44, 37);
            this.IconCerrar.TabIndex = 0;
            this.IconCerrar.UseVisualStyleBackColor = true;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // PanelBarraInferior
            // 
            this.PanelBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.PanelBarraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBarraInferior.Location = new System.Drawing.Point(193, 581);
            this.PanelBarraInferior.Name = "PanelBarraInferior";
            this.PanelBarraInferior.Size = new System.Drawing.Size(757, 19);
            this.PanelBarraInferior.TabIndex = 2;
            // 
            // PanelPadre
            // 
            this.PanelPadre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPadre.BackColor = System.Drawing.Color.LightCyan;
            this.PanelPadre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PanelPadre.Location = new System.Drawing.Point(193, 37);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(754, 543);
            this.PanelPadre.TabIndex = 3;
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Font = new System.Drawing.Font("Forte", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersona.Location = new System.Drawing.Point(109, 9);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(55, 19);
            this.lblNombrePersona.TabIndex = 1;
            this.lblNombrePersona.Text = "label1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.PanelBarraInferior);
            this.Controls.Add(this.PanelBarra);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.PanelMenu.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.PanelBarra.ResumeLayout(false);
            this.PanelBarra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel PanelPadre;
        private Guna.UI.WinForms.GunaPanel PanelBarraInferior;
        private Guna.UI.WinForms.GunaPanel PanelBarra;
        private Guna.UI.WinForms.GunaPanel PanelMenu;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaButton BtnPedidosLocal;
        private Guna.UI.WinForms.GunaButton BtnPerfil;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaButton BtnPedidoDomi;
        private Guna.UI.WinForms.GunaButton BtnPedidos;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton BtnProductos;
        private Guna.UI.WinForms.GunaButton BtnPersonal;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private FontAwesome.Sharp.IconButton IconMaximizar;
        private FontAwesome.Sharp.IconButton IconRestaurar;
        private FontAwesome.Sharp.IconButton IconMinimizar;
        private FontAwesome.Sharp.IconButton IconCerrar;
        private Guna.UI.WinForms.GunaButton BtnPuesto;
        private Guna.UI.WinForms.GunaButton BtnMesa;
        private System.Windows.Forms.Label lblNombrePersona;
    }
}