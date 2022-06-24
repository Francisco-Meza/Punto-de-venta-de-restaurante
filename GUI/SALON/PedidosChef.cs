using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_DE_NEGOCIOS;
using Guna.UI.WinForms;

namespace GUI.SALON
{
    public partial class PedidosChef : Form
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

        private const string preparacion = "PROCESO";
        private const string realizado = "REALIZADO";

        private ClsChef_N datos;
        private GunaDataGridView[] dg;
        private GunaLabel[] lblAtendio;
        private GunaLabel[] lblPedido;
        private GunaButton[] btnNota;
        private GunaGroupBox[] groupBox;
        private Panel[] panel;
        private int[] pedidosID;
        private string[] atendio;
        private string[] nota;
        private DataTable source;
        private Color colorClic;
        private int checkPedido;
        private Panel anterior;
        private string msj;
        private FrmMenu menu;
        public PedidosChef(FrmMenu menu)
        {
            InitializeComponent();
            datos = new ClsChef_N();
            Panel[] panel = { panel1, panel2, panel3, panel4 };
            this.panel = panel;
            anterior = null;
            checkPedido = -1;
            colorClic = Color.FromArgb(37, 162, 68);
            IniciarDatos();
            this.menu = menu;
        }

        private void IniciarDatos()
        {
            pedidosID = datos.Pedidos;
            atendio = datos.Atendio;
            nota = datos.Nota;
            btnNota = new GunaButton[pedidosID.Length];
            groupBox = new GunaGroupBox[pedidosID.Length];
            lblAtendio = new GunaLabel[pedidosID.Length];
            lblPedido = new GunaLabel[pedidosID.Length];
            dg = new GunaDataGridView[pedidosID.Length];
            for (int i = 0; i < 4; i++)
            {
                if (i < pedidosID.Length)
                {
                    source = datos.Read(pedidosID[i]);
                    lblPedido[i] = new GunaLabel();
                    GenerarLblNumero(panel[i], lblPedido[i], pedidosID[i].ToString());
                    //Atendio
                    lblAtendio[i] = new GunaLabel();
                    GenerarLblAtendio(panel[i], lblAtendio[i], atendio[i].ToString());
                    //Notas
                    if (nota[i] != string.Empty)
                    {
                        btnNota[i] = new GunaButton();
                        btnNota[i].Name = i.ToString();
                        btnNota[i].Click += LeerNota;
                        GenerarBotonNota(panel[i], btnNota[i]);
                    }
                    //DataGridView
                    dg[i] = new GunaDataGridView();
                    groupBox[i] = new GunaGroupBox();
                    GenerarDataGriView(panel[i], groupBox[i], dg[i], source);
                    panel[i].Visible = true;
                    panel[i].Enabled = true;
                }
                else
                {
                    panel[i].Visible = false;
                    panel[i].Enabled = false;
                }
            }
        }
        private void LeerNota(object sender, EventArgs e)
        {
            GunaButton control = sender as GunaButton;
            FrmLeerNota a = new FrmLeerNota(this.nota[Convert.ToInt32(control.Name)]);
            a.ShowDialog();
        }
        private int Tamanio()
        {
            if (menu.Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                return 6;
            }
            return 4;
        }

        private void GenerarBotonNota(Panel panel, GunaButton button)
        {
            button.BackColor = Color.LightCyan;
            button.BaseColor = Color.FromArgb(45, 198, 83);
            button.OnHoverBaseColor = Color.ForestGreen;
            button.SetBounds(1, 1, 53, 18);
            button.Location = new Point(218, 48);
            button.Image = null;
            button.Text = "Nota";
            panel.Controls.Add(button);
        }
        private void GenerarLblAtendio(Panel panel, GunaLabel label, string valor)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(8, 36);
            label.Size = new System.Drawing.Size(123, 21);
            label.TabIndex = 8;
            label.Text = "Atendido por: "+valor;
            panel.Controls.Add(label);
        }
        private void GenerarLblNumero(Panel panel, GunaLabel label, string valor)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(4, 9);
            label.Size = new System.Drawing.Size(165, 21);
            label.TabIndex = 4;
            label.Text = "Número de pedido: "+valor;
            panel.Controls.Add(label);
        }
        private void GenerarDataGriView(Panel panel,GunaGroupBox groupBox, GunaDataGridView dataGridView, DataTable source)
        {
            //GroupBox
            groupBox.BackColor = System.Drawing.Color.Transparent;
            groupBox.BaseColor = System.Drawing.Color.LightCyan;
            groupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            groupBox.BorderSize = 2;
            groupBox.LineColor = System.Drawing.Color.Transparent;
            groupBox.Location = new System.Drawing.Point(8, 69);
            groupBox.Name = "groupPedido";
            groupBox.Size = new System.Drawing.Size(260, 240);
            groupBox.TabIndex = 0;
            groupBox.TextLocation = new System.Drawing.Point(10, 8);
            //DataDrigView
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 20;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            dataGridView.Location = new System.Drawing.Point(4, 3);
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new System.Drawing.Size(253, 234);
            dataGridView.TabIndex = 0;
            dataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ThemeStyle.HeaderStyle.Height = 20;
            dataGridView.ThemeStyle.ReadOnly = true;
            dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView.ThemeStyle.RowsStyle.Height = 22;
            dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            //ADD
            dataGridView.DataSource = source;
            groupBox.Controls.Add(dataGridView);
            panel.Controls.Add(groupBox);
        }
        private void clicPanel(Panel panel, int id)
        {
            if (anterior != null) anterior.BackColor = Color.LightCyan;
            panel.BackColor = colorClic;
            checkPedido = id;
            anterior = panel;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            clicPanel(panel1,0);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            clicPanel(panel2, 1);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            clicPanel(panel3, 2);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            clicPanel(panel4, 3);
        }

        private void BtnPreparacion_Click(object sender, EventArgs e)
        {
            if (checkPedido != -1)
            {
                DialogResult res = MessageBox.Show("Se cambiara de estado el pedido: " + pedidosID[checkPedido], "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    msj = datos.Update(checkPedido, preparacion);
                    if (msj.Equals("OK"))
                    {
                        MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualizar();
                    }
                    else if (msj.Equals("NO"))
                    {
                        MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un pedido primero", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDespacho_Click(object sender, EventArgs e)
        {
            if (checkPedido != -1)
            {
                DialogResult res = MessageBox.Show("Se cambiara de estado el pedido: "+pedidosID[checkPedido], "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    msj = datos.Update(checkPedido, realizado);
                    if (msj.Equals("OK"))
                    {
                        MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualizar();
                    }
                    else if (msj.Equals("NO"))
                    {
                        MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un pedido primero", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Actualizar()
        {
            datos.IniciarDatos();
            IniciarDatos();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if(checkPedido != -1)
            {
                panel[checkPedido].BackColor = Color.LightCyan;
                checkPedido = -1;
            }
            Actualizar();
        }
    }
}
