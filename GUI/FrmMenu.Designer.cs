﻿namespace GUI
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
            this.panelAdmMesero = new Guna.UI.WinForms.GunaPanel();
            this.BtnPedidosLocal = new Guna.UI.WinForms.GunaButton();
            this.BtnPerfil = new Guna.UI.WinForms.GunaButton();
            this.panelAdmi = new Guna.UI.WinForms.GunaPanel();
            this.btnPuestos = new Guna.UI.WinForms.GunaButton();
            this.BtnProductos = new Guna.UI.WinForms.GunaButton();
            this.BtnClasificacion = new Guna.UI.WinForms.GunaButton();
            this.BtnMesas = new Guna.UI.WinForms.GunaButton();
            this.BtnPersonal = new Guna.UI.WinForms.GunaButton();
            this.BtnMesa = new Guna.UI.WinForms.GunaButton();
            this.BtnPuesto = new Guna.UI.WinForms.GunaButton();
            this.btnAdmMesero = new Guna.UI.WinForms.GunaButton();
            this.panelAdmCajero = new Guna.UI.WinForms.GunaPanel();
            this.BtnPedidosG = new Guna.UI.WinForms.GunaButton();
            this.btnAdmCajero = new Guna.UI.WinForms.GunaButton();
            this.btnAdmi = new Guna.UI.WinForms.GunaButton();
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
            this.panelAdmMesero.SuspendLayout();
            this.panelAdmi.SuspendLayout();
            this.panelAdmCajero.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.PanelBarra.SuspendLayout();
            this.PanelPadre.SuspendLayout();
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
            this.PanelMenu.Controls.Add(this.panelAdmi);
            this.PanelMenu.Controls.Add(this.btnAdmi);
            this.PanelMenu.Controls.Add(this.gunaPanel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(193, 685);
            this.PanelMenu.TabIndex = 0;
            // 
            // panelAdmMesero
            // 
            this.panelAdmMesero.Controls.Add(this.BtnPedidosLocal);
            this.panelAdmMesero.Controls.Add(this.BtnPerfil);
            this.panelAdmMesero.Location = new System.Drawing.Point(173, 343);
            this.panelAdmMesero.Name = "panelAdmMesero";
            this.panelAdmMesero.Size = new System.Drawing.Size(193, 87);
            this.panelAdmMesero.TabIndex = 3;
            // 
            // BtnPedidosLocal
            // 
            this.BtnPedidosLocal.AnimationHoverSpeed = 0.07F;
            this.BtnPedidosLocal.AnimationSpeed = 0.03F;
            this.BtnPedidosLocal.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidosLocal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidosLocal.BorderSize = 1;
            this.BtnPedidosLocal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPedidosLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPedidosLocal.Enabled = false;
            this.BtnPedidosLocal.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPedidosLocal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnPedidosLocal.ForeColor = System.Drawing.Color.Black;
            this.BtnPedidosLocal.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidosLocal.Image")));
            this.BtnPedidosLocal.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPedidosLocal.Location = new System.Drawing.Point(0, 42);
            this.BtnPedidosLocal.Name = "BtnPedidosLocal";
            this.BtnPedidosLocal.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPedidosLocal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPedidosLocal.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPedidosLocal.OnHoverImage = null;
            this.BtnPedidosLocal.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPedidosLocal.Size = new System.Drawing.Size(193, 32);
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
            this.BtnPerfil.Image = null;
            this.BtnPerfil.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPerfil.Location = new System.Drawing.Point(0, 0);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPerfil.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPerfil.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPerfil.OnHoverImage = null;
            this.BtnPerfil.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPerfil.Size = new System.Drawing.Size(193, 42);
            this.BtnPerfil.TabIndex = 0;
            this.BtnPerfil.Text = "Perfil";
            this.BtnPerfil.Visible = false;
            // 
            // panelAdmi
            // 
            this.panelAdmi.Controls.Add(this.btnPuestos);
            this.panelAdmi.Controls.Add(this.BtnProductos);
            this.panelAdmi.Controls.Add(this.BtnClasificacion);
            this.panelAdmi.Controls.Add(this.BtnMesas);
            this.panelAdmi.Controls.Add(this.BtnPersonal);
            this.panelAdmi.Controls.Add(this.BtnMesa);
            this.panelAdmi.Controls.Add(this.BtnPuesto);
            this.panelAdmi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmi.Location = new System.Drawing.Point(0, 42);
            this.panelAdmi.Name = "panelAdmi";
            this.panelAdmi.Size = new System.Drawing.Size(193, 213);
            this.panelAdmi.TabIndex = 1;
            // 
            // btnPuestos
            // 
            this.btnPuestos.AnimationHoverSpeed = 0.07F;
            this.btnPuestos.AnimationSpeed = 0.03F;
            this.btnPuestos.BaseColor = System.Drawing.Color.Transparent;
            this.btnPuestos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPuestos.BorderSize = 1;
            this.btnPuestos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPuestos.FocusedColor = System.Drawing.Color.Empty;
            this.btnPuestos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPuestos.ForeColor = System.Drawing.Color.Black;
            this.btnPuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnPuestos.Image")));
            this.btnPuestos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPuestos.Location = new System.Drawing.Point(0, 168);
            this.btnPuestos.Name = "btnPuestos";
            this.btnPuestos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPuestos.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPuestos.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnPuestos.OnHoverImage = null;
            this.btnPuestos.OnPressedColor = System.Drawing.Color.Black;
            this.btnPuestos.Size = new System.Drawing.Size(193, 25);
            this.btnPuestos.TabIndex = 5;
            this.btnPuestos.Text = "Puestos";
            this.btnPuestos.Visible = false;
            // 
            // BtnProductos
            // 
            this.BtnProductos.AnimationHoverSpeed = 0.07F;
            this.BtnProductos.AnimationSpeed = 0.03F;
            this.BtnProductos.BaseColor = System.Drawing.Color.Empty;
            this.BtnProductos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnProductos.BorderSize = 1;
            this.BtnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FocusedColor = System.Drawing.Color.Empty;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnProductos.ForeColor = System.Drawing.Color.Black;
            this.BtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductos.Image")));
            this.BtnProductos.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnProductos.Location = new System.Drawing.Point(0, 126);
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
            this.BtnClasificacion.BaseColor = System.Drawing.Color.Empty;
            this.BtnClasificacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnClasificacion.BorderSize = 1;
            this.BtnClasificacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnClasificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClasificacion.FocusedColor = System.Drawing.Color.Empty;
            this.BtnClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnClasificacion.ForeColor = System.Drawing.Color.Black;
            this.BtnClasificacion.Image = null;
            this.BtnClasificacion.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnClasificacion.Location = new System.Drawing.Point(0, 84);
            this.BtnClasificacion.Name = "BtnClasificacion";
            this.BtnClasificacion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnClasificacion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnClasificacion.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnClasificacion.OnHoverImage = null;
            this.BtnClasificacion.OnPressedColor = System.Drawing.Color.Black;
            this.BtnClasificacion.Size = new System.Drawing.Size(193, 42);
            this.BtnClasificacion.TabIndex = 3;
            this.BtnClasificacion.Text = "Clasificación de Productos";
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
            this.BtnMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMesas.FocusedColor = System.Drawing.Color.Empty;
            this.BtnMesas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnMesas.ForeColor = System.Drawing.Color.Black;
            this.BtnMesas.Image = ((System.Drawing.Image)(resources.GetObject("BtnMesas.Image")));
            this.BtnMesas.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnMesas.Location = new System.Drawing.Point(0, 42);
            this.BtnMesas.Name = "BtnMesas";
            this.BtnMesas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMesas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMesas.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnMesas.OnHoverImage = null;
            this.BtnMesas.OnPressedColor = System.Drawing.Color.Black;
            this.BtnMesas.Size = new System.Drawing.Size(193, 42);
            this.BtnMesas.TabIndex = 4;
            this.BtnMesas.Text = "Mesas";
            this.BtnMesas.Click += new System.EventHandler(this.BtnMesas_Click);
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
            this.BtnPersonal.Size = new System.Drawing.Size(193, 42);
            this.BtnPersonal.TabIndex = 0;
            this.BtnPersonal.Text = "Personal";
            this.BtnPersonal.Visible = false;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
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
            this.BtnMesa.Location = new System.Drawing.Point(0, 71);
            this.BtnMesa.Name = "BtnMesa";
            this.BtnMesa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMesa.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMesa.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnMesa.OnHoverImage = null;
            this.BtnMesa.OnPressedColor = System.Drawing.Color.Black;
            this.BtnMesa.Size = new System.Drawing.Size(193, 10);
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
            this.BtnPuesto.Location = new System.Drawing.Point(0, 0);
            this.BtnPuesto.Name = "BtnPuesto";
            this.BtnPuesto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPuesto.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPuesto.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPuesto.OnHoverImage = null;
            this.BtnPuesto.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPuesto.Size = new System.Drawing.Size(193, 39);
            this.BtnPuesto.TabIndex = 2;
            this.BtnPuesto.Text = "Puestos";
            this.BtnPuesto.Visible = false;
            this.BtnPuesto.Click += new System.EventHandler(this.BtnPuesto_Click);
            // 
            // btnAdmMesero
            // 
            this.btnAdmMesero.AnimationHoverSpeed = 0.07F;
            this.btnAdmMesero.AnimationSpeed = 0.03F;
            this.btnAdmMesero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdmMesero.BaseColor = System.Drawing.Color.Empty;
            this.btnAdmMesero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdmMesero.BorderSize = 1;
            this.btnAdmMesero.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdmMesero.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdmMesero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmMesero.ForeColor = System.Drawing.Color.Black;
            this.btnAdmMesero.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmMesero.Image")));
            this.btnAdmMesero.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdmMesero.Location = new System.Drawing.Point(161, 277);
            this.btnAdmMesero.Name = "btnAdmMesero";
            this.btnAdmMesero.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdmMesero.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdmMesero.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAdmMesero.OnHoverImage = null;
            this.btnAdmMesero.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdmMesero.Size = new System.Drawing.Size(193, 42);
            this.btnAdmMesero.TabIndex = 5;
            this.btnAdmMesero.Text = "Mesero";
            this.btnAdmMesero.Click += new System.EventHandler(this.btnAdmMesero_Click);
            // 
            // panelAdmCajero
            // 
            this.panelAdmCajero.Controls.Add(this.BtnPedidosG);
            this.panelAdmCajero.Location = new System.Drawing.Point(145, 153);
            this.panelAdmCajero.Name = "panelAdmCajero";
            this.panelAdmCajero.Size = new System.Drawing.Size(193, 46);
            this.panelAdmCajero.TabIndex = 2;
            // 
            // BtnPedidosG
            // 
            this.BtnPedidosG.AnimationHoverSpeed = 0.07F;
            this.BtnPedidosG.AnimationSpeed = 0.03F;
            this.BtnPedidosG.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidosG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidosG.BorderSize = 1;
            this.BtnPedidosG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPedidosG.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPedidosG.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPedidosG.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnPedidosG.ForeColor = System.Drawing.Color.Black;
            this.BtnPedidosG.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidosG.Image")));
            this.BtnPedidosG.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPedidosG.Location = new System.Drawing.Point(0, 0);
            this.BtnPedidosG.Name = "BtnPedidosG";
            this.BtnPedidosG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPedidosG.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPedidosG.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnPedidosG.OnHoverImage = null;
            this.BtnPedidosG.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPedidosG.Size = new System.Drawing.Size(193, 43);
            this.BtnPedidosG.TabIndex = 0;
            this.BtnPedidosG.Text = "Pedido en general";
            this.BtnPedidosG.Click += new System.EventHandler(this.BtnPedidosG_Click);
            // 
            // btnAdmCajero
            // 
            this.btnAdmCajero.AnimationHoverSpeed = 0.07F;
            this.btnAdmCajero.AnimationSpeed = 0.03F;
            this.btnAdmCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdmCajero.BaseColor = System.Drawing.Color.Empty;
            this.btnAdmCajero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdmCajero.BorderSize = 1;
            this.btnAdmCajero.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdmCajero.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdmCajero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmCajero.ForeColor = System.Drawing.Color.Black;
            this.btnAdmCajero.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmCajero.Image")));
            this.btnAdmCajero.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdmCajero.Location = new System.Drawing.Point(92, 74);
            this.btnAdmCajero.Name = "btnAdmCajero";
            this.btnAdmCajero.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdmCajero.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdmCajero.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAdmCajero.OnHoverImage = null;
            this.btnAdmCajero.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdmCajero.Size = new System.Drawing.Size(193, 42);
            this.btnAdmCajero.TabIndex = 4;
            this.btnAdmCajero.Text = "Cajero";
            this.btnAdmCajero.Click += new System.EventHandler(this.btnAdmCajero_Click);
            // 
            // btnAdmi
            // 
            this.btnAdmi.AnimationHoverSpeed = 0.07F;
            this.btnAdmi.AnimationSpeed = 0.03F;
            this.btnAdmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdmi.BaseColor = System.Drawing.Color.Empty;
            this.btnAdmi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdmi.BorderSize = 1;
            this.btnAdmi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdmi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmi.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdmi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmi.ForeColor = System.Drawing.Color.Black;
            this.btnAdmi.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmi.Image")));
            this.btnAdmi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdmi.Location = new System.Drawing.Point(0, 0);
            this.btnAdmi.Name = "btnAdmi";
            this.btnAdmi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdmi.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdmi.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAdmi.OnHoverImage = null;
            this.btnAdmi.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdmi.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdmi.Size = new System.Drawing.Size(193, 42);
            this.btnAdmi.TabIndex = 5;
            this.btnAdmi.TabStop = false;
            this.btnAdmi.Text = "Administación";
            this.btnAdmi.Click += new System.EventHandler(this.btnAdmi_Click);
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
            this.BtnPedidos.Click += new System.EventHandler(this.BtnCajero_Click);
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
            this.PanelPadre.Controls.Add(this.panelAdmMesero);
            this.PanelPadre.Controls.Add(this.btnAdmCajero);
            this.PanelPadre.Controls.Add(this.panelAdmCajero);
            this.PanelPadre.Controls.Add(this.btnAdmMesero);
            this.PanelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPadre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PanelPadre.Location = new System.Drawing.Point(193, 39);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(757, 646);
            this.PanelPadre.TabIndex = 3;
            this.PanelPadre.TabStop = true;
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
            this.panelAdmMesero.ResumeLayout(false);
            this.panelAdmi.ResumeLayout(false);
            this.panelAdmCajero.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.PanelBarra.ResumeLayout(false);
            this.PanelBarra.PerformLayout();
            this.PanelPadre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel PanelPadre;
        private Guna.UI.WinForms.GunaPanel PanelBarraInferior;
        private Guna.UI.WinForms.GunaPanel PanelBarra;
        private Guna.UI.WinForms.GunaPanel PanelMenu;
        private Guna.UI.WinForms.GunaPanel panelAdmMesero;
        private Guna.UI.WinForms.GunaButton BtnPedidosLocal;
        private Guna.UI.WinForms.GunaButton BtnPerfil;
        private Guna.UI.WinForms.GunaPanel panelAdmCajero;
        private Guna.UI.WinForms.GunaButton BtnPedidoDomi;

        private Guna.UI.WinForms.GunaButton BtnPedidosG;
        private Guna.UI.WinForms.GunaPanel panelAdmi;

        private Guna.UI.WinForms.GunaButton BtnPedidos;

        private Guna.UI.WinForms.GunaButton BtnProductos;
        private Guna.UI.WinForms.GunaButton BtnPersonal;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private FontAwesome.Sharp.IconButton IconMaximizar;
        private FontAwesome.Sharp.IconButton IconRestaurar;
        private FontAwesome.Sharp.IconButton IconMinimizar;
        private FontAwesome.Sharp.IconButton IconCerrar;
        private Guna.UI.WinForms.GunaButton BtnPuesto;

        private Guna.UI.WinForms.GunaButton BtnMesas;
        private Guna.UI.WinForms.GunaButton BtnClasificacion;
        private Guna.UI.WinForms.GunaButton btnAdmi;
        private Guna.UI.WinForms.GunaButton btnAdmMesero;
        private Guna.UI.WinForms.GunaButton btnAdmCajero;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;

        private Guna.UI.WinForms.GunaButton BtnMesa;
        private System.Windows.Forms.Label lblNombrePersona;
        private Guna.UI.WinForms.GunaButton btnPuestos;
    }
}