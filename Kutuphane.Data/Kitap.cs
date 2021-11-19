using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Data
{
    public class Kitap
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Ad { get; set; }

        public DateTime BasimTarihi { get; set; }

        public KitapTur KitapTur { get; set; }

        public string YazarAd { get; set; }

        public int SayfaSayisi { get; set; }

        public string Aciklama { get; set; }

        public DateTime? AlinmaTarihi { get; set; }
        
    }
}
