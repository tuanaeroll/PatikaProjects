using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKütüphanesi
{
    // Class: Kitap nesnesini tanımlayan şablon. Kitap sınıfı, kitaplarla ilgili bilgileri tutmak ve işlemleri gerçekleştirmek için kullanılır.
    public class Kitap
    {
        // Property: Sınıfın her bir özelliğini temsil eder. Bu özellikler Kitap nesnelerine ait bilgileri tutar.
        public string Ad;
        public string YazarAdi;
        public string YayinEvi;
        public int SayfaSayisi;
        private string YazarSoyadi { get; set; }
        private DateTime KayitTarihi { get; set; }

        // Constructor: Kitap sınıfının parametresiz yapıcı metodu. Bir nesne oluşturulduğunda varsayılan değerleri atar ve Olustur() metodunu çağırır.
        public Kitap()
        {

        }

        // Constructor: Kitap sınıfının parametreli yapıcı metodu. Kitap adı, yazar adı, yayınevi ve sayfa sayısını alarak bu değerleri nesneye atar.
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
