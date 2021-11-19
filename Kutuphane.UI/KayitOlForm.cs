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
    public partial class KayitOlForm : Form
    {
        private readonly KullaniciYoneticisi kY;
        private bool parolaKontrol;

        public KayitOlForm(KullaniciYoneticisi kY)
        {
            this.kY = kY;


            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            string adSoyad = txtAdSoyad.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string parola = txtParola.Text.Trim();
            string parola2 = txtParolaTekrar.Text.Trim();

            if (parola==""||parola2==""||adSoyad==""||kullaniciAdi=="")
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz");
            }
            else
            {
                if (!parolaKontrol)
                {
                    MessageBox.Show("Parola Eşleşmiyor");
                    return;
                }

                if (kY.KullaniciVarMi(kullaniciAdi))
                {
                    MessageBox.Show("Bu Kullanıcı adı zaten mevcut lütfen farklı bir Kullanıcı Adı girin");
                    return;
                }


                kY.KayitOlma(adSoyad, kullaniciAdi, parola);
                MessageBox.Show("Kayıt Başarılı");
                this.Close();
            }
        }

        
        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            if (txtParola.Text == txtParolaTekrar.Text)
            {
                lblKontrol.Text = "parola eşleşiyor";
                lblKontrol.ForeColor = Color.Green;
                parolaKontrol = true;
            }
            else
            {
                lblKontrol.Text = "parola eşleşmiyor";
                lblKontrol.ForeColor = Color.Red;
                parolaKontrol = false;
            }
        }



    }
}
