
namespace Kutuphane.UI
{
    partial class KutuphaneForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHesabim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBagisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKutuphane = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cboTurler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiKitapOduncAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKitabiImhaEt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutuphane)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHesabim,
            this.tsmiBagisYap,
            this.tsmiCikisYap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHesabim
            // 
            this.tsmiHesabim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiHesabim.Name = "tsmiHesabim";
            this.tsmiHesabim.Size = new System.Drawing.Size(83, 25);
            this.tsmiHesabim.Text = "Hesabım";
            this.tsmiHesabim.Click += new System.EventHandler(this.tsmiHesabim_Click);
            // 
            // tsmiBagisYap
            // 
            this.tsmiBagisYap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiBagisYap.Name = "tsmiBagisYap";
            this.tsmiBagisYap.Size = new System.Drawing.Size(88, 25);
            this.tsmiBagisYap.Text = "Bağış Yap";
            this.tsmiBagisYap.Click += new System.EventHandler(this.tsmiBagisYap_Click);
            // 
            // tsmiCikisYap
            // 
            this.tsmiCikisYap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiCikisYap.Name = "tsmiCikisYap";
            this.tsmiCikisYap.Size = new System.Drawing.Size(84, 25);
            this.tsmiCikisYap.Text = "Çıkış Yap";
            this.tsmiCikisYap.Click += new System.EventHandler(this.tsmiCikisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphane";
            // 
            // dgvKutuphane
            // 
            this.dgvKutuphane.AllowUserToAddRows = false;
            this.dgvKutuphane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKutuphane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKutuphane.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKutuphane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKutuphane.Location = new System.Drawing.Point(0, 114);
            this.dgvKutuphane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKutuphane.MultiSelect = false;
            this.dgvKutuphane.Name = "dgvKutuphane";
            this.dgvKutuphane.ReadOnly = true;
            this.dgvKutuphane.RowHeadersVisible = false;
            this.dgvKutuphane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKutuphane.Size = new System.Drawing.Size(914, 459);
            this.dgvKutuphane.TabIndex = 2;
            this.dgvKutuphane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKutuphane_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(302, 46);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(148, 26);
            this.txtArama.TabIndex = 4;
            // 
            // cboTurler
            // 
            this.cboTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurler.FormattingEnabled = true;
            this.cboTurler.Location = new System.Drawing.Point(664, 46);
            this.cboTurler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTurler.Name = "cboTurler";
            this.cboTurler.Size = new System.Drawing.Size(180, 28);
            this.cboTurler.TabIndex = 5;
            this.cboTurler.SelectedIndexChanged += new System.EventHandler(this.cboTurler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Türler";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKitapOduncAl,
            this.tsmiKitabiImhaEt});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // tsmiKitapOduncAl
            // 
            this.tsmiKitapOduncAl.Name = "tsmiKitapOduncAl";
            this.tsmiKitapOduncAl.Size = new System.Drawing.Size(180, 22);
            this.tsmiKitapOduncAl.Text = "Kitap Ödünç Al";
            this.tsmiKitapOduncAl.Click += new System.EventHandler(this.tsmiKitapOduncAl_Click);
            // 
            // tsmiKitabiImhaEt
            // 
            this.tsmiKitabiImhaEt.Name = "tsmiKitabiImhaEt";
            this.tsmiKitabiImhaEt.Size = new System.Drawing.Size(180, 22);
            this.tsmiKitabiImhaEt.Text = "Kitabı İmha Et";
            this.tsmiKitabiImhaEt.Click += new System.EventHandler(this.tsmiKitabiImhaEt_Click);
            // 
            // KutuphaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTurler);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKutuphane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KutuphaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KutuphaneForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KutuphaneForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutuphane)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHesabim;
        private System.Windows.Forms.ToolStripMenuItem tsmiBagisYap;
        private System.Windows.Forms.ToolStripMenuItem tsmiCikisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKutuphane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cboTurler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapOduncAl;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitabiImhaEt;
    }
}