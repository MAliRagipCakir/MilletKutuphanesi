﻿
namespace Kutuphane.UI
{
    partial class BagisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.dtpBasimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKitapTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnBagisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(113, 123);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(120, 26);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // dtpBasimTarihi
            // 
            this.dtpBasimTarihi.Location = new System.Drawing.Point(113, 167);
            this.dtpBasimTarihi.Name = "dtpBasimTarihi";
            this.dtpBasimTarihi.Size = new System.Drawing.Size(223, 26);
            this.dtpBasimTarihi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Basım Tarihi";
            // 
            // cboKitapTur
            // 
            this.cboKitapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKitapTur.FormattingEnabled = true;
            this.cboKitapTur.Location = new System.Drawing.Point(113, 216);
            this.cboKitapTur.Name = "cboKitapTur";
            this.cboKitapTur.Size = new System.Drawing.Size(120, 28);
            this.cboKitapTur.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap Türü";
            // 
            // nudSayfaSayisi
            // 
            this.nudSayfaSayisi.Location = new System.Drawing.Point(113, 324);
            this.nudSayfaSayisi.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudSayfaSayisi.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSayfaSayisi.Name = "nudSayfaSayisi";
            this.nudSayfaSayisi.Size = new System.Drawing.Size(120, 26);
            this.nudSayfaSayisi.TabIndex = 7;
            this.nudSayfaSayisi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(113, 425);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(223, 138);
            this.txtAciklama.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adet";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(113, 375);
            this.nudAdet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(120, 26);
            this.nudAdet.TabIndex = 9;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBagisYap
            // 
            this.btnBagisYap.Location = new System.Drawing.Point(217, 578);
            this.btnBagisYap.Name = "btnBagisYap";
            this.btnBagisYap.Size = new System.Drawing.Size(119, 34);
            this.btnBagisYap.TabIndex = 10;
            this.btnBagisYap.Text = "Bağış Yap";
            this.btnBagisYap.UseVisualStyleBackColor = true;
            this.btnBagisYap.Click += new System.EventHandler(this.btnBagisYap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane.UI.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(126, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(113, 268);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(120, 26);
            this.txtYazarAd.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Yazar Adı";
            // 
            // BagisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 659);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBagisYap);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.nudSayfaSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboKitapTur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBasimTarihi);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BagisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BagisForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.DateTimePicker dtpBasimTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKitapTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSayfaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnBagisYap;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Label label7;
    }
}