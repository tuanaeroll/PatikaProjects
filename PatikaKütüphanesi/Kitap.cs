using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKütüphanesi
{
    public class Kitap
    {
        public string Ad;
        public string YazarAdi;
        public string YayinEvi;
        public int SayfaSayisi;
        private string YazarSoyadi { get; set; }
        private DateTime KayitTarihi { get; set; }

        public Kitap()
        {

        }

        public Kitap(string ad, string yazarAdi, string yayinEvi,  int sayfaSayisi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YayinEvi = yayinEvi;
            SayfaSayisi = sayfaSayisi;
            Olustur();
        }

        public void Olustur()
        {
            KayitTarihi = DateTime.Now;
            Console.WriteLine($"{YazarAdi} tarafından yazılan ve {YayinEvi} tarafından sunulan {Ad}, {KayitTarihi}'de satışa çıkmıştır. Kitap {SayfaSayisi} sayfa sayısına sahiptir.");
        }

    }
}
