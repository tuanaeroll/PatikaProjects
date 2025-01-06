using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    // Bebek sınıfını tanımlıyoruz.
    public class Bebek
    {
        // Bebek sınıfının özelliklerini tanımlıyoruz. Bunlara erişilmesi için get ve set ekliyoruz. 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        // DogumTarihi özelliğini sadece bu sınıf içerisinde set edilebilir olarak tanımlıyoruz.
        public DateTime DogumTarihi { get; private set; }

        // Bebek sınıfının yapıcı metodu. Bu metot çağrıldığında, Bebek sınıfından bir nesne oluşturulduğunda çalışır.
        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            Dogum();
        }

        // Bebek sınıfının parametresiz yapıcı metodunu yazıyoruz. Ad ve soyadı ekrana yazdıracağımız için bu metodu çağırırken ad ve soyadı bilinmiyor olarak tanımlıyoruz.
        public Bebek()
        {
            Ad = "Bilinmiyor";
            Soyad = "Bilinmiyor";
            Dogum();
        }

        // Doğum metodu ile bebeğe doğum tarihini atıyoruz ve bilgilerini ekrana yazdırıyoruz.
        public void Dogum()
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine($"Ingaaaa, bebişimiz {DogumTarihi}'de dünyaya geldi.");
        }

    }
}
