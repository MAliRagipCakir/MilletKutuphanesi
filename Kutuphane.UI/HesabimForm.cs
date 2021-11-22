using Kutuphane.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public delegate void KitapTeslimEventHandler();

    public partial class HesabimForm : Form
    {
        private readonly Kullanici girisYapan;
        private readonly KutuphaneYoneticisi khY;

        
        public event KitapTeslimEventHandler KitapTeslimEdildi;

        public HesabimForm(Kullanici girisYapan, KutuphaneYoneticisi khY)
        {
            this.girisYapan = girisYapan;
            this.khY = khY;
            InitializeComponent();

            KullaniciVerileriniOku();
            ListeGuncelle();

            // Şifre Değiştirme formu eklenebilir
        }

        private void KullaniciVerileriniOku()
        {
            lblId.Text = $"ID : {girisYapan.Id}";
            lblAdSoyad.Text = $"Ad Soyad: {girisYapan.AdSoyad}";
            lblKullaniciAd.Text = $"Kullanıcı Adı: {girisYapan.KullaniciAdi}";
            lblParola.Text = $"Parola: {girisYapan.Parola}";
        }

        private void ListeGuncelle()
        {
            dgvOduncAlinanKitaplar.DataSource = null;
            dgvOduncAlinanKitaplar.DataSource = girisYapan.OduncAlinanKitaplar;
        }

        private void btnKitapTeslimEt_Click(object sender, EventArgs e)
        {
            if (dgvOduncAlinanKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen teslim edilecek kitabı seçiniz");
                return;
            }

            Kitap kitap = (Kitap)dgvOduncAlinanKitaplar.SelectedRows[0].DataBoundItem;

            
            khY.Kitaplar.Add(kitap);
            girisYapan.OduncAlinanKitaplar.Remove(kitap);


            ListeGuncelle();

            if (KitapTeslimEdildi != null)
            {
                KitapTeslimEdildi();
            }

        }

        private void dgvOduncAlinanKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOduncAlinanKitaplar.SelectedRows.Count == 0)
            {
                dtpSonTeslimTarihi.Value = DateTime.Now;
                return;
            }

            Kitap kitap = (Kitap)dgvOduncAlinanKitaplar.SelectedRows[0].DataBoundItem;
            dtpSonTeslimTarihi.Value = (DateTime)kitap.AlinmaTarihi.Value;
            dtpSonTeslimTarihi.Value = dtpSonTeslimTarihi.Value.AddDays(14);
        }
    }
}
