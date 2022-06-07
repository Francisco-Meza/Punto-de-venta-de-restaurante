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
            this.PnlMenu = new Guna.UI.WinForms.GunaPanel();
            this.BtnPedidosG = new Guna.UI.WinForms.GunaButton();
            this.lblAdministrador = new Guna.UI.WinForms.GunaLabel();
            this.lblCajero = new Guna.UI.WinForms.GunaLabel();
            this.BtnPerfil = new Guna.UI.WinForms.GunaButton();
            this.BtnPuesto = new Guna.UI.WinForms.GunaButton();
            this.BtnCuentas = new Guna.UI.WinForms.GunaButton();
            this.BtnPedidosLocal = new Guna.UI.WinForms.GunaButton();
            this.lblMesero = new Guna.UI.WinForms.GunaLabel();
            this.BtnProductos = new Guna.UI.WinForms.GunaButton();
            this.BtnClasificacion = new Guna.UI.WinForms.GunaButton();
            this.BtnMesas = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.BtnPedidoDomi = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.BtnPedidos = new Guna.UI.WinForms.GunaButton();
            this.PanelBarra = new Guna.UI.WinForms.GunaPanel();
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.IconMaximizar = new FontAwesome.Sharp.IconButton();
            this.IconRestaurar = new FontAwesome.Sharp.IconButton();
            this.IconMinimizar = new FontAwesome.Sharp.IconButton();
            this.IconCerrar = new FontAwesome.Sharp.IconButton();
            this.PanelBarraInferior = new Guna.UI.WinForms.GunaPanel();
            this.PanelPadre = new Guna.UI.WinForms.GunaPanel();
            this.PanelMenu.SuspendLayout();
            this.PnlMenu.SuspendLayout();
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
            this.PanelMenu.Controls.Add(this.PnlMenu);
            this.PanelMenu.Controls.Add(this.gunaPanel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(193, 685);
            this.PanelMenu.TabIndex = 0;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.BtnPedidosG);
            this.PnlMenu.Controls.Add(this.lblAdministrador);
            this.PnlMenu.Controls.Add(this.lblCajero);
            this.PnlMenu.Controls.Add(this.BtnPerfil);
            this.PnlMenu.Controls.Add(this.BtnPuesto);
            this.PnlMenu.Controls.Add(this.BtnCuentas);
            this.PnlMenu.Controls.Add(this.BtnPedidosLocal);
            this.PnlMenu.Controls.Add(this.lblMesero);
            this.PnlMenu.Controls.Add(this.BtnProductos);
            this.PnlMenu.Controls.Add(this.BtnClasificacion);
            this.PnlMenu.Controls.Add(this.BtnMesas);
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(193, 495);
            this.PnlMenu.TabIndex = 1;
            // 
            // BtnPedidosG
            // 
            this.BtnPedidosG.AnimationHoverSpeed = 0.07F;
            this.BtnPedidosG.AnimationSpeed = 0.03F;
            this.BtnPedidosG.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidosG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidosG.BorderSize = 1;
            this.BtnPedidosG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPedidosG.Enabled = false;
            this.BtnPedidosG.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPedidosG.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnPedidosG.ForeColor = System.Drawing.Color.Black;
            this.BtnPedidosG.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidosG.Image")));
            this.BtnPedidosG.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPedidosG.Location = new System.Drawing.Point(0, 420);
            this.BtnPedidosG.Name = "BtnPedidosG";
            this.BtnPedidosG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPedidosG.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPedidosG.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPedidosG.OnHoverImage = null;
            this.BtnPedidosG.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPedidosG.Size = new System.Drawing.Size(193, 42);
            this.BtnPedidosG.TabIndex = 0;
            this.BtnPedidosG.Text = "Pedido en general";
            this.BtnPedidosG.Visible = false;
            this.BtnPedidosG.Click += new System.EventHandler(this.BtnPedidosG_Click);
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Enabled = false;
            this.lblAdministrador.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAdministrador.Location = new System.Drawing.Point(28, 9);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(120, 21);
            this.lblAdministrador.TabIndex = 6;
            this.lblAdministrador.Text = "Administrador";
            this.lblAdministrador.Visible = false;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Enabled = false;
            this.lblCajero.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCajero.Location = new System.Drawing.Point(57, 396);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(62, 21);
            this.lblCajero.TabIndex = 4;
            this.lblCajero.Text = "Cajero";
            this.lblCajero.Visible = false;
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.AnimationHoverSpeed = 0.07F;
            this.BtnPerfil.AnimationSpeed = 0.03F;
            this.BtnPerfil.BaseColor = System.Drawing.Color.Transparent;
            this.BtnPerfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPerfil.BorderSize = 1;
            this.BtnPerfil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPerfil.Enabled = false;
            this.BtnPerfil.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPerfil.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnPerfil.ForeColor = System.Drawing.Color.Black;
            this.BtnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("BtnPerfil.Image")));
            this.BtnPerfil.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPerfil.Location = new System.Drawing.Point(0, 351);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnPerfil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPerfil.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnPerfil.OnHoverImage = null;
            this.BtnPerfil.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPerfil.Size = new System.Drawing.Size(193, 42);
            this.BtnPerfil.TabIndex = 7;
            this.BtnPerfil.Text = "Perfil";
            this.BtnPerfil.Visible = false;
            this.BtnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
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
            this.BtnPuesto.Location = new System.Drawing.Point(0, 39);
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
            // BtnCuentas
            // 
            this.BtnCuentas.AnimationHoverSpeed = 0.07F;
            this.BtnCuentas.AnimationSpeed = 0.03F;
            this.BtnCuentas.BaseColor = System.Drawing.Color.Transparent;
            this.BtnCuentas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCuentas.BorderSize = 1;
            this.BtnCuentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCuentas.Enabled = false;
            this.BtnCuentas.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCuentas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnCuentas.ForeColor = System.Drawing.Color.Black;
            this.BtnCuentas.Image = ((System.Drawing.Image)(resources.GetObject("BtnCuentas.Image")));
            this.BtnCuentas.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCuentas.Location = new System.Drawing.Point(0, 87);
            this.BtnCuentas.Name = "BtnCuentas";
            this.BtnCuentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCuentas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCuentas.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnCuentas.OnHoverImage = null;
            this.BtnCuentas.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCuentas.Size = new System.Drawing.Size(193, 42);
            this.BtnCuentas.TabIndex = 6;
            this.BtnCuentas.Text = "Cuentas";
            this.BtnCuentas.Visible = false;
            this.BtnCuentas.Click += new System.EventHandler(this.BtnCuentas_Click);
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
            this.BtnPedidosLocal.Location = new System.Drawing.Point(0, 303);
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
            // lblMesero
            // 
            this.lblMesero.AutoSize = true;
            this.lblMesero.Enabled = false;
            this.lblMesero.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblMesero.Location = new System.Drawing.Point(57, 279);
            this.lblMesero.Name = "lblMesero";
            this.lblMesero.Size = new System.Drawing.Size(66, 21);
            this.lblMesero.TabIndex = 5;
            this.lblMesero.Text = "Mesero";
            this.lblMesero.Visible = false;
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
            this.BtnProductos.Location = new System.Drawing.Point(0, 135);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnProductos.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnProductos.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnProductos.OnHoverImage = null;
            this.BtnProductos.OnPressedColor = System.Drawing.Color.Black;
            this.BtnProductos.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnProductos.Size = new System.Drawing.Size(193, 42);
            this.BtnProductos.TabIndex = 5;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.Visible = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnClasificacion
            // 
            this.BtnClasificacion.AnimationHoverSpeed = 0.07F;
            this.BtnClasificacion.AnimationSpeed = 0.03F;
            this.BtnClasificacion.BaseColor = System.Drawing.Color.Transparent;
            this.BtnClasificacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnClasificacion.BorderSize = 1;
            this.BtnClasificacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnClasificacion.Enabled = false;
            this.BtnClasificacion.FocusedColor = System.Drawing.Color.Empty;
            this.BtnClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnClasificacion.ForeColor = System.Drawing.Color.Black;
            this.BtnClasificacion.Image = ((System.Drawing.Image)(resources.GetObject("BtnClasificacion.Image")));
            this.BtnClasificacion.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnClasificacion.Location = new System.Drawing.Point(0, 183);
            this.BtnClasificacion.Name = "BtnClasificacion";
            this.BtnClasificacion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnClasificacion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnClasificacion.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnClasificacion.OnHoverImage = null;
            this.BtnClasificacion.OnPressedColor = System.Drawing.Color.Black;
            this.BtnClasificacion.Size = new System.Drawing.Size(193, 42);
            this.BtnClasificacion.TabIndex = 8;
            this.BtnClasificacion.Text = "Clasificación - Prod";
            this.BtnClasificacion.Visible = false;
            this.BtnClasificacion.Click += new System.EventHandler(this.BtnClasificacion_Click);
            // 
            // BtnMesas
            // 
            this.BtnMesas.AnimationHoverSpeed = 0.07F;
            this.BtnMesas.AnimationSpeed = 0.03F;
            this.BtnMesas.BaseColor = System.Drawing.Color.Empty;
            this.BtnMesas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnMesas.BorderSize = 1;
            this.BtnMesas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnMesas.Enabled = false;
            this.BtnMesas.FocusedColor = System.Drawing.Color.Empty;
            this.BtnMesas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnMesas.ForeColor = System.Drawing.Color.Black;
            this.BtnMesas.Image = ((System.Drawing.Image)(resources.GetObject("BtnMesas.Image")));
            this.BtnMesas.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnMesas.Location = new System.Drawing.Point(0, 231);
            this.BtnMesas.Name = "BtnMesas";
            this.BtnMesas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMesas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMesas.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnMesas.OnHoverImage = null;
            this.BtnMesas.OnPressedColor = System.Drawing.Color.Black;
            this.BtnMesas.Size = new System.Drawing.Size(193, 42);
            this.BtnMesas.TabIndex = 4;
            this.BtnMesas.Text = "Mesas";
            this.BtnMesas.Visible = false;
            this.BtnMesas.Click += new System.EventHandler(this.BtnMesas_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaPanel1.BackgroundImage = global::GUI.Properties.Resources.Captura_de_pantalla__78__removebg_preview_removebg_preview;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 501);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(193, 184);
            this.gunaPanel1.TabIndex = 0;
            // 
            // BtnPedidoDomi
            // 
            this.BtnPedidoDomi.AnimationHoverSpeed = 0.07F;
            this.BtnPedidoDomi.AnimationSpeed = 0.03F;
            this.BtnPedidoDomi.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidoDomi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidoDomi.BorderSize = 1;
            this.BtnPedidoDomi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPedidoDomi.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPedidoDomi.Enabled = false;
            this.BtnPedidoDomi.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPedidoDomi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidoDomi.ForeColor = System.Drawing.Color.Black;
            this.BtnPedidoDomi.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidoDomi.Image")));
            this.BtnPedidoDomi.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPedidoDomi.Location = new System.Drawing.Point(0, 42);
            this.BtnPedidoDomi.Name = "BtnPedidoDomi";
            this.BtnPedidoDomi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPedidoDomi.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPedidoDomi.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPedidoDomi.OnHoverImage = null;
            this.BtnPedidoDomi.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPedidoDomi.Size = new System.Drawing.Size(187, 42);
            this.BtnPedidoDomi.TabIndex = 1;
            this.BtnPedidoDomi.Text = "Pedidos Domicilio";
            this.BtnPedidoDomi.Visible = false;
            this.BtnPedidoDomi.Click += new System.EventHandler(this.BtnPedidoDomi_Click);
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
            this.PanelBarraInferior.Location = new System.Drawing.Point(193, 671);
            this.PanelBarraInferior.Name = "PanelBarraInferior";
            this.PanelBarraInferior.Size = new System.Drawing.Size(757, 14);
            this.PanelBarraInferior.TabIndex = 2;
            // 
            // PanelPadre
            // 
            this.PanelPadre.BackColor = System.Drawing.Color.LightCyan;
            this.PanelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPadre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PanelPadre.Location = new System.Drawing.Point(193, 39);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(757, 646);
            this.PanelPadre.TabIndex = 3;
            this.PanelPadre.TabStop = true;
            this.PanelPadre.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPadre_Paint);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(950, 685);
            this.Controls.Add(this.PanelBarraInferior);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.PanelBarra);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.PanelMenu.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
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
        private Guna.UI.WinForms.GunaButton BtnPedidosLocal;
        private Guna.UI.WinForms.GunaButton BtnPedidoDomi;

        private Guna.UI.WinForms.GunaButton BtnPedidosG;

        private Guna.UI.WinForms.GunaButton BtnPedidos;

        private Guna.UI.WinForms.GunaButton BtnProductos;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private FontAwesome.Sharp.IconButton IconMaximizar;
        private FontAwesome.Sharp.IconButton IconRestaurar;
        private FontAwesome.Sharp.IconButton IconMinimizar;
        private FontAwesome.Sharp.IconButton IconCerrar;
        private Guna.UI.WinForms.GunaButton BtnPuesto;

        private Guna.UI.WinForms.GunaButton BtnMesas;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.Label lblNombrePersona;
        private Guna.UI.WinForms.GunaLabel lblMesero;
        private Guna.UI.WinForms.GunaLabel lblAdministrador;
        private Guna.UI.WinForms.GunaLabel lblCajero;
        private Guna.UI.WinForms.GunaButton BtnCuentas;
        private Guna.UI.WinForms.GunaButton BtnPerfil;
        private Guna.UI.WinForms.GunaButton BtnClasificacion;
        private Guna.UI.WinForms.GunaPanel PnlMenu;
    }
}