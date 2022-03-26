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
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.PanelBarra = new Guna.UI.WinForms.GunaPanel();
            this.PanelBarraInferior = new Guna.UI.WinForms.GunaPanel();
            this.PanelPadre = new Guna.UI.WinForms.GunaPanel();
            this.IconMaximizar = new FontAwesome.Sharp.IconButton();
            this.IconRestaurar = new FontAwesome.Sharp.IconButton();
            this.IconMinimizar = new FontAwesome.Sharp.IconButton();
            this.IconCerrar = new FontAwesome.Sharp.IconButton();
            this.BtnPedidosLocal = new Guna.UI.WinForms.GunaButton();
            this.BtnPerfil = new Guna.UI.WinForms.GunaButton();
            this.BtnPedidoDomi = new Guna.UI.WinForms.GunaButton();
            this.BtnCajero = new Guna.UI.WinForms.GunaButton();
            this.BtnProductos = new Guna.UI.WinForms.GunaButton();
            this.BtnPersonal = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.PanelMenu.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
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
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.PanelMenu.Controls.Add(this.gunaPanel4);
            this.PanelMenu.Controls.Add(this.gunaPanel2);
            this.PanelMenu.Controls.Add(this.gunaPanel3);
            this.PanelMenu.Controls.Add(this.gunaPanel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(173, 557);
            this.PanelMenu.TabIndex = 0;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.BtnPedidosLocal);
            this.gunaPanel4.Controls.Add(this.BtnPerfil);
            this.gunaPanel4.Location = new System.Drawing.Point(0, 365);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(173, 100);
            this.gunaPanel4.TabIndex = 3;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.BtnPedidoDomi);
            this.gunaPanel3.Controls.Add(this.BtnCajero);
            this.gunaPanel3.Location = new System.Drawing.Point(3, 269);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(173, 98);
            this.gunaPanel3.TabIndex = 2;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.BtnProductos);
            this.gunaPanel2.Controls.Add(this.BtnPersonal);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 173);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(173, 98);
            this.gunaPanel2.TabIndex = 1;
            // 
            // PanelBarra
            // 
            this.PanelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.PanelBarra.Controls.Add(this.IconMaximizar);
            this.PanelBarra.Controls.Add(this.IconRestaurar);
            this.PanelBarra.Controls.Add(this.IconMinimizar);
            this.PanelBarra.Controls.Add(this.IconCerrar);
            this.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarra.Location = new System.Drawing.Point(173, 0);
            this.PanelBarra.Name = "PanelBarra";
            this.PanelBarra.Size = new System.Drawing.Size(753, 39);
            this.PanelBarra.TabIndex = 1;
            this.PanelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarra_MouseDown);
            // 
            // PanelBarraInferior
            // 
            this.PanelBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.PanelBarraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBarraInferior.Location = new System.Drawing.Point(173, 538);
            this.PanelBarraInferior.Name = "PanelBarraInferior";
            this.PanelBarraInferior.Size = new System.Drawing.Size(753, 19);
            this.PanelBarraInferior.TabIndex = 2;
            // 
            // PanelPadre
            // 
            this.PanelPadre.BackColor = System.Drawing.Color.LightCyan;
            this.PanelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPadre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PanelPadre.Location = new System.Drawing.Point(173, 39);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(753, 499);
            this.PanelPadre.TabIndex = 3;
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
            this.IconMaximizar.Location = new System.Drawing.Point(642, 0);
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
            this.IconRestaurar.Location = new System.Drawing.Point(642, -6);
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
            this.IconMinimizar.Location = new System.Drawing.Point(580, 1);
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
            this.IconCerrar.Location = new System.Drawing.Point(697, 3);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(44, 37);
            this.IconCerrar.TabIndex = 0;
            this.IconCerrar.UseVisualStyleBackColor = true;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // BtnPedidosLocal
            // 
            this.BtnPedidosLocal.AnimationHoverSpeed = 0.07F;
            this.BtnPedidosLocal.AnimationSpeed = 0.03F;
            this.BtnPedidosLocal.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidosLocal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidosLocal.BorderSize = 1;
            this.BtnPedidosLocal.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.BtnPedidosLocal.Size = new System.Drawing.Size(176, 42);
            this.BtnPedidosLocal.TabIndex = 1;
            this.BtnPedidosLocal.Text = "Pedidos Local";
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
            this.BtnPerfil.Size = new System.Drawing.Size(173, 42);
            this.BtnPerfil.TabIndex = 0;
            this.BtnPerfil.Text = "Perfil";
            // 
            // BtnPedidoDomi
            // 
            this.BtnPedidoDomi.AnimationHoverSpeed = 0.07F;
            this.BtnPedidoDomi.AnimationSpeed = 0.03F;
            this.BtnPedidoDomi.BaseColor = System.Drawing.Color.Empty;
            this.BtnPedidoDomi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPedidoDomi.BorderSize = 1;
            this.BtnPedidoDomi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPedidoDomi.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPedidoDomi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnPedidoDomi.Size = new System.Drawing.Size(173, 42);
            this.BtnPedidoDomi.TabIndex = 1;
            this.BtnPedidoDomi.Text = "Pedidos Domicilio";
            // 
            // BtnCajero
            // 
            this.BtnCajero.AnimationHoverSpeed = 0.07F;
            this.BtnCajero.AnimationSpeed = 0.03F;
            this.BtnCajero.BaseColor = System.Drawing.Color.Empty;
            this.BtnCajero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCajero.BorderSize = 1;
            this.BtnCajero.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCajero.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCajero.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCajero.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnCajero.ForeColor = System.Drawing.Color.Black;
            this.BtnCajero.Image = ((System.Drawing.Image)(resources.GetObject("BtnCajero.Image")));
            this.BtnCajero.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCajero.Location = new System.Drawing.Point(0, 0);
            this.BtnCajero.Name = "BtnCajero";
            this.BtnCajero.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCajero.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCajero.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnCajero.OnHoverImage = null;
            this.BtnCajero.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCajero.Size = new System.Drawing.Size(173, 42);
            this.BtnCajero.TabIndex = 0;
            this.BtnCajero.Text = "Cajero";
            // 
            // BtnProductos
            // 
            this.BtnProductos.AnimationHoverSpeed = 0.07F;
            this.BtnProductos.AnimationSpeed = 0.03F;
            this.BtnProductos.BaseColor = System.Drawing.Color.Empty;
            this.BtnProductos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnProductos.BorderSize = 1;
            this.BtnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.BtnProductos.Size = new System.Drawing.Size(176, 42);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "Productos";
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
            this.BtnPersonal.Size = new System.Drawing.Size(173, 42);
            this.BtnPersonal.TabIndex = 0;
            this.BtnPersonal.Text = "Personal";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(83)))));
            this.gunaPanel1.BackgroundImage = global::GUI.Properties.Resources.Captura_de_pantalla__78__removebg_preview_removebg_preview;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(173, 167);
            this.gunaPanel1.TabIndex = 0;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 557);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.PanelBarraInferior);
            this.Controls.Add(this.PanelBarra);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.PanelMenu.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.PanelBarra.ResumeLayout(false);
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
        private Guna.UI.WinForms.GunaButton BtnCajero;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton BtnProductos;
        private Guna.UI.WinForms.GunaButton BtnPersonal;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private FontAwesome.Sharp.IconButton IconMaximizar;
        private FontAwesome.Sharp.IconButton IconRestaurar;
        private FontAwesome.Sharp.IconButton IconMinimizar;
        private FontAwesome.Sharp.IconButton IconCerrar;
    }
}