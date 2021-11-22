
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesabımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKutuphane = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cboTurler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutuphane)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesabımToolStripMenuItem,
            this.bağışYapToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesabımToolStripMenuItem
            // 
            this.hesabımToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hesabımToolStripMenuItem.Name = "hesabımToolStripMenuItem";
            this.hesabımToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.hesabımToolStripMenuItem.Text = "Hesabım";
            // 
            // bağışYapToolStripMenuItem
            // 
            this.bağışYapToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bağışYapToolStripMenuItem.Name = "bağışYapToolStripMenuItem";
            this.bağışYapToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.bağışYapToolStripMenuItem.Text = "Bağış Yap";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
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
            this.dgvKutuphane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKutuphane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKutuphane.Location = new System.Drawing.Point(0, 114);
            this.dgvKutuphane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKutuphane.Name = "dgvKutuphane";
            this.dgvKutuphane.Size = new System.Drawing.Size(914, 459);
            this.dgvKutuphane.TabIndex = 2;
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
            this.cboTurler.FormattingEnabled = true;
            this.cboTurler.Location = new System.Drawing.Point(664, 46);
            this.cboTurler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTurler.Name = "cboTurler";
            this.cboTurler.Size = new System.Drawing.Size(180, 28);
            this.cboTurler.TabIndex = 5;
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
            this.Text = "KutuphaneForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKutuphane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesabımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKutuphane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cboTurler;
        private System.Windows.Forms.Label label3;
    }
}