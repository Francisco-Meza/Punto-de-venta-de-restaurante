
namespace GUI.SALON
{
    partial class FrmAgregarNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarNota));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.gunaPanel1.Controls.Add(this.txtNota);
            this.gunaPanel1.Controls.Add(this.btnGuardar);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 450);
            this.gunaPanel1.TabIndex = 1;
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
            this.btnGuardar.Location = new System.Drawing.Point(324, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(162)))), ((int)(((byte)(68)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Radius = 20;
            this.btnGuardar.Size = new System.Drawing.Size(160, 42);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notas";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(40, 64);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(726, 295);
            this.txtNota.TabIndex = 4;
            // 
            // FrmAgregarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarNota";
            this.Text = "FrmAgregarNota";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota;
    }
}