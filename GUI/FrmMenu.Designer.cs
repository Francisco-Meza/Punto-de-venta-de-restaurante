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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.GunaBtnPersonal = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Green;
            this.gunaPanel1.Controls.Add(this.GunaBtnPersonal);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(162, 450);
            this.gunaPanel1.TabIndex = 0;
            // 
            // GunaBtnPersonal
            // 
            this.GunaBtnPersonal.AnimationHoverSpeed = 0.07F;
            this.GunaBtnPersonal.AnimationSpeed = 0.03F;
            this.GunaBtnPersonal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GunaBtnPersonal.BorderColor = System.Drawing.Color.Black;
            this.GunaBtnPersonal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaBtnPersonal.FocusedColor = System.Drawing.Color.Empty;
            this.GunaBtnPersonal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaBtnPersonal.ForeColor = System.Drawing.Color.White;
            this.GunaBtnPersonal.Image = ((System.Drawing.Image)(resources.GetObject("GunaBtnPersonal.Image")));
            this.GunaBtnPersonal.ImageSize = new System.Drawing.Size(20, 20);
            this.GunaBtnPersonal.Location = new System.Drawing.Point(0, 54);
            this.GunaBtnPersonal.Name = "GunaBtnPersonal";
            this.GunaBtnPersonal.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.GunaBtnPersonal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaBtnPersonal.OnHoverForeColor = System.Drawing.Color.White;
            this.GunaBtnPersonal.OnHoverImage = null;
            this.GunaBtnPersonal.OnPressedColor = System.Drawing.Color.Black;
            this.GunaBtnPersonal.Size = new System.Drawing.Size(160, 42);
            this.GunaBtnPersonal.TabIndex = 0;
            this.GunaBtnPersonal.Text = "Personal";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton GunaBtnPersonal;
    }
}