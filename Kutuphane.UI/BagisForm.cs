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
    public partial class BagisForm : Form
    {
        private readonly KutuphaneYoneticisi khY;

        public BagisForm(KutuphaneYoneticisi khY)
        {
            this.khY = khY;
            InitializeComponent();
            TurEkleme();
        }

        private void TurEkleme()
        {
            foreach (var item in Enum.GetValues(typeof(KitapTur)))
            {
                cboKitapTur.Items.Add(item);
            }

            // cboTurler in özelliklerindeki DropDownStyle ı DropDownList yaptık ve ilk değeri seçili hale getirdik
            cboKitapTur.SelectedIndex = 0;
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            if (txtKitapAdi.Text != "" && txtYazarAd.Text != "" && txtAciklama.Text != "")
            {
                Kitap kitap = new Kitap();
                kitap.Ad = txtKitapAdi.Text.Trim();
                kitap.BasimTarihi = dtpBasimTarihi.Value;
                kitap.KitapTur = (KitapTur)cboKitapTur.SelectedItem;
                kitap.YazarAd = txtYazarAd.Text.Trim();
                kitap.Aciklama = txtAciklama.Text.Trim();
                kitap.SayfaSayisi = (int)nudSayfaSayisi.Value;

                int adet = (int)nudAdet.Value;

                khY.KitapBagisYapma(kitap, adet);

                Close();
            }
            else
            {
                MessageBox.Show("Kitap Adı, Yazar Adı, Açıklama alanları boş bırakılamaz");
            }

        }
    }
}
