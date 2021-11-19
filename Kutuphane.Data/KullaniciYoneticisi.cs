using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Data
{
    public class KullaniciYoneticisi
    {

        public List<Kullanici> Kullanicilar { get; set; } = new List<Kullanici>();

        public void KayitOlma(string adSoyad,string kullaniciAdi,string parola)
        {
            Kullanici yeniKullanici = new Kullanici()
            {
                AdSoyad = adSoyad,
                KullaniciAdi= kullaniciAdi,
                Parola =parola
            };
            Kullanicilar.Add(yeniKullanici);
        }

        public bool KullaniciVarMi(string kullaniciAdi)
        {
            return Kullanicilar.Any(x => x.KullaniciAdi == kullaniciAdi);
        }

        public Kullanici OturumAcma(string kullaniciAdi,string parola)
        {
            foreach (var item in Kullanicilar)
            {
                if (item.KullaniciAdi == kullaniciAdi && item.Parola == parola)
                    return item;
            }

            return null;

            //return Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Parola == parola);
        }

    }
}
