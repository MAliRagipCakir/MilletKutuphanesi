using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Data
{
    public class KutuphaneYoneticisi
    {

        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();

        public void KitapBagisYapma(Kitap kitap,int adet)
        {
            for (int i = 1; i <= adet; i++)
            {
                Kitaplar.Add(kitap);
            }
        }

        public void KitapTeslimEtme(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }
}
