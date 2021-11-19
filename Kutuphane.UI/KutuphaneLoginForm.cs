using Kutuphane.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class KutuphaneLoginForm : Form
    {
        KutuphaneYoneticisi khY;
        KullaniciYoneticisi kY;

        public KutuphaneLoginForm()
        {
            
            InitializeComponent();
            VerileriOku();

        }

        

        private void liblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlForm kayitOlForm = new KayitOlForm(kY);
            kayitOlForm.ShowDialog();
            
        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("kullaniYoneticisi.json");
                string json2 = File.ReadAllText("kutuphaneYoneticisi.json");
                kY = JsonConvert.DeserializeObject<KullaniciYoneticisi>(json);
                khY = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(json2);

            }
            catch (Exception)
            {
                kY = new KullaniciYoneticisi();
                khY = new KutuphaneYoneticisi();
            }
        }

        private void KutuphaneLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(kY);
            File.WriteAllText("kullaniYoneticisi.json", json);

            string json2 = JsonConvert.SerializeObject(khY);
            File.WriteAllText("kutuphaneYoneticisi.json", json2);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAd.Text.Trim();
            string parola = txtParola.Text.Trim();

            Kullanici girisYapan = kY.OturumAcma(kullaniciAdi, parola);

            if (girisYapan==null)
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış");
            }
            else
            {
                MessageBox.Show($"{girisYapan.KullaniciAdi} Hoşgeldiniz!");
                //TODO: giriş işlemleri sonrası kütüphaneForm açılacak
            }


        }
    }
}
