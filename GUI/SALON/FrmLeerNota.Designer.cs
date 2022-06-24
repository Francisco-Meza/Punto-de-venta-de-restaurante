
namespace GUI.SALON
{
    partial class FrmLeerNota
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.gunaPanel1.Controls.Add(this.txtNota);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 450);
            this.gunaPanel1.TabIndex = 2;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(40, 64);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(726, 295);
            this.txtNota.TabIndex = 4;
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
            // FrmLeerNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLeerNota";
            this.Text = "FrmLeerNota";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
    }
}