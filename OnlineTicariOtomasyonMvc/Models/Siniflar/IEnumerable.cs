using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyonMvc.Models.Siniflar
{
    public class IEnumerable
    {
        public IEnumerable<Urun> Uruns { get; set; }
        public IEnumerable<UrunDetay> UrunDetays { get; set; }
        public IEnumerable<Cari> Caris { get; set; }
    }
}