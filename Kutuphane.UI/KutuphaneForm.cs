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
    public partial class KutuphaneForm : Form
    {

        KutuphaneYoneticisi khY;
        private readonly Kullanici girisYapan;


        public KutuphaneForm(Kullanici girisYapan)
        {
            this.girisYapan = girisYapan;
            InitializeComponent();
            VerileriOku();
            TurEkleme();
            DataGuncelle(khY.Kitaplar); // Bagis yaptiktan sonra, kitap ödünc aldıktan sonra çalıştırılıcak bu yüzden metodlaştırdık
        }

        private void DataGuncelle(List<Kitap> kitaplar)
        {
            dgvKutuphane.DataSource = null;
            dgvKutuphane.DataSource = kitaplar;

            dgvKutuphane.Columns[0].Visible = false;
            dgvKutuphane.Columns[7].Visible = false;
        }

        private void TurEkleme()
        {
            cboTurler.Items.Add("Hepsi");

            foreach (var item in Enum.GetValues(typeof(KitapTur)))
            {
                cboTurler.Items.Add(item);
            }

            // cboTurler in özelliklerindeki DropDownStyle ı DropDownList yaptık ve ilk değeri seçili hale getirdik
            cboTurler.SelectedIndex = 0;
        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("kutuphaneYoneticisi.json");
                khY = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(json);

            }
            catch (Exception)
            {
                khY = new KutuphaneYoneticisi();
            }
        }

        private void KutuphaneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(khY);
            File.WriteAllText("kutuphaneYoneticisi.json", json);
        }

        private void tsmiCikisYap_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tsmiKitapOduncAl_Click(object sender, EventArgs e)
        {
            // Kütüphaneden seçili kitabı kaldırıcam ve o an ki login olmuş kullanıcının ödünç aldığı kitaplara eklicem
            // Ve o anki tarih bilgisini kitabın ödünç alınma tarihine eklicem

            // 1. adım seçili kitabı bulcam
            // 2. adım bulduğum kitabı kullanıcının ödünc aldığıkitaplar listesine ekliyecem
            // 3. adım bulduğum kitabı kütüphanedeki kitaplardan silcem

            if (dgvKutuphane.SelectedRows.Count==0)
            {
                return;
            }

            Kitap kitap = (Kitap)dgvKutuphane.SelectedRows[0].DataBoundItem;
            kitap.AlinmaTarihi = DateTime.Now;

            girisYapan.OduncAlinanKitaplar.Add(kitap);
            khY.Kitaplar.Remove(kitap);


            DataGuncelle(khY.Kitaplar);
        }

        private void dgvKutuphane_MouseClick(object sender, MouseEventArgs e)
        {
            // Sağ click
            if (e.Button == MouseButtons.Right)
            {
                // sadece index'e tıklandığında göstersin, boş alana tıklanınca göstermesin
                var position = dgvKutuphane.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    contextMenuStrip1.Show(dgvKutuphane, new Point(e.X, e.Y));


                    //*****************************************
                    dgvKutuphane.Rows[position].Selected = true;    // Sağ click ile seçili satırı sağ click yapılan satır yapmak için
                }
            }
        }

        private void tsmiHesabim_Click(object sender, EventArgs e)
        {
            HesabimForm hesabimForm = new HesabimForm(girisYapan, khY);

            hesabimForm.KitapTeslimEdildi += HesabimForm_KitapTeslimEdildi;

            hesabimForm.ShowDialog();

            DataGuncelle(khY.Kitaplar);// Boşa düşmüş olabilir event ile alt form'dan anlık şekilde güncellendiği için kapatınca güncellemeye gerek kalmadı
        }

        private void HesabimForm_KitapTeslimEdildi()
        {
            DataGuncelle(khY.Kitaplar);
        }

        private void tsmiBagisYap_Click(object sender, EventArgs e)
        {
            BagisForm bagisForm = new BagisForm(khY);
            bagisForm.ShowDialog();
            DataGuncelle(khY.Kitaplar);
        }

        private void tsmiKitabiImhaEt_Click(object sender, EventArgs e)
        {
            if (dgvKutuphane.SelectedRows.Count == 0)
            {
                return;
            }

            Kitap kitap = (Kitap)dgvKutuphane.SelectedRows[0].DataBoundItem;

            khY.Kitaplar.Remove(kitap);

            DataGuncelle(khY.Kitaplar);
        }



        private void cboTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            KitapArama();
        }

        private void KitapArama()
        {
            List<Kitap> seciliKitaplar = new List<Kitap>();
            string aranan = txtArama.Text.ToLower().Trim();

            seciliKitaplar.Clear();

            if (txtArama.Text != "" && cboTurler.SelectedIndex != 0)
            {
                seciliKitaplar = khY.Kitaplar.Select(x => x).Where(x => x.Ad.ToLower().StartsWith(aranan) && x.KitapTur == (KitapTur)cboTurler.SelectedItem).ToList();

                DataGuncelle(seciliKitaplar);
            }
            else if (cboTurler.SelectedIndex != 0)
            {
                seciliKitaplar = khY.Kitaplar.Select(x => x).Where(x => x.KitapTur == (KitapTur)cboTurler.SelectedItem).ToList();

                DataGuncelle(seciliKitaplar);
            }
            else if (txtArama.Text != "")
            {
                seciliKitaplar = khY.Kitaplar.Select(x => x).Where(x => x.Ad.ToLower().StartsWith(aranan)).ToList();

                DataGuncelle(seciliKitaplar);
            }
            else
            {
                DataGuncelle(khY.Kitaplar);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            KitapArama();
        }
    }
}
