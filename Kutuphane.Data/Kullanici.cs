using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Data
{
    public class Kullanici
    {
        

        public Guid Id { get; set; } = Guid.NewGuid();

        public string AdSoyad { get; set; }

        public string KullaniciAdi { get; set; }

        public string Parola { get; set; }

        public List<Kitap> OduncAlinanKitaplar { get; set; } = new List<Kitap>();
    }
}
